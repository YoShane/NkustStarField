using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Identity;

namespace EquipmentManagement.Controllers
{
    public class EquipmentsShowController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly string connectionString;

        public EquipmentsShowController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // GET: EquipmentsShow
        public async Task<IActionResult> Index()
        {
            List<Equipment> equipments = new List<Equipment>();
            bool member_fee = false;

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();

                String sqlQuery = "select (Quantity-total_lead) as Surplus,[Location].[Name] as tmpName,* from (" +
                "select Equipment.Id, 0 as \"total_lead\"" +
               "from Equipment where Id not in (select BorrowRecord.Item_id " +
                "from BorrowRecord inner join BorrowOrder " +
                "on BorrowRecord.Order_id = BorrowOrder.Id " +
                "where BorrowOrder.Restore_state = 0 /* 排除沒還 */) union " +
                "(select Item_id, SUM(Quantuty) as total_lead " +
                "from BorrowRecord inner join BorrowOrder " +
               "on BorrowRecord.Order_id = BorrowOrder.Id " +
                "where BorrowOrder.Restore_state = 0 " +
                "group by Item_id /* 找還沒還 */)) as adjTable " +
                "inner join Equipment on Equipment.Id = adjTable.Id " +
                "inner join [Location] on [Location].Location_code = Equipment.Location_code";


                SqlCommand command = new SqlCommand(sqlQuery, connection);
                using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                    while (await dataReader.ReadAsync()) {
                        Equipment equipment = new Equipment();
                        equipment.Id = Convert.ToInt32(dataReader["Id"]);
                        equipment.Img = (byte[])dataReader["Img"];
                        equipment.Name = Convert.ToString(dataReader["Name"]);
                        equipment.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                        equipment.Price_non_member = Convert.ToInt32(dataReader["Price_non_member"]);
                        equipment.Price_member = Convert.ToInt32(dataReader["Price_member"]);
                        equipment.Surplus = Convert.ToInt32(dataReader["Surplus"]);
                        equipment.Source = Convert.ToString(dataReader["tmpName"]);

                        equipments.Add(equipment);
                    }
                }
            }

            if (_signInManager.IsSignedIn(User)) { //取得是否繳交社費
                var user = await _userManager.GetUserAsync(User);
                if (user == null) {
                    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                }

                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    await connection.OpenAsync();
                    String sqlQuery = $"SELECT Member_fee FROM dbo.Member WHERE Stu_mail = '{user.UserName}'";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                        if (dataReader.HasRows) {
                            dataReader.Read();
                            member_fee = Convert.ToBoolean(dataReader["Member_fee"]);
                            }
                    }
                }
            }
               ViewBag.isMember = member_fee;
                return View(equipments);
        }

    }
}
