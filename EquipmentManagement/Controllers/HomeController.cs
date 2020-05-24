using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EquipmentManagement.Models;
using EquipmentManagement.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace EquipmentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string connectionString;
        public HomeController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IActionResult> Index()
        {
            List<Equipment> equipments = new List<Equipment>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();

                String sqlQuery = "select top(8) Id,Img,[Name] " +
                                "from Equipment, " +
                         "(select Item_id, SUM(Quantuty) as total_lead " +
                         "from BorrowRecord " +
                         "inner join BorrowOrder " +
                         "on BorrowRecord.Order_id = BorrowOrder.Id " +
                         "where BorrowOrder.Restore_state = 0 " +
                         "group by Item_id /* 找還沒還 */) as tmp " +
                        "where Equipment.Id = tmp.Item_id " +
                        "order by Quantity desc";  //取租借前八名


                SqlCommand command = new SqlCommand(sqlQuery, connection);
                using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                    while (await dataReader.ReadAsync()) {
                        Equipment equipment = new Equipment();
                        equipment.Id = Convert.ToInt32(dataReader["Id"]);
                        if(dataReader["Img"] != DBNull.Value) {
                            equipment.Img = (byte[])dataReader["Img"];
                        } else {
                            equipment.Img = null;
                        }
                        equipment.Name = Convert.ToString(dataReader["Name"]);
                        equipments.Add(equipment);
                    }
                }

            }
            return View(equipments);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
