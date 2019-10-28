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
using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers
{
    public class UserOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly string connectionString;

        public UserOrdersController(ApplicationDbContext context, UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // GET: UserOrders
        public async Task<IActionResult> Index()
        {
            List<BorrowOrder> borrowOrders = new List<BorrowOrder>();
            var user = await _userManager.GetUserAsync(User);
            if (user == null) {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();
                String sqlQuery = "SELECT * FROM dbo.BorrowOrder " +
                            "inner join Member " +
                            "on Member.Stu_mail = BorrowOrder.Stu_mail "+
                            $"where BorrowOrder.Stu_mail = '{user.UserName}'";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                    while (await dataReader.ReadAsync()) {
                        BorrowOrder borrowOrder = new BorrowOrder();
                        Member member = new Member();
                        borrowOrder.Id = Convert.ToInt32(dataReader["Id"]);
                        borrowOrder.Stu_mail = Convert.ToString(dataReader["Stu_mail"]);
                        borrowOrder.Borrow_time = Convert.ToDateTime(dataReader["Borrow_time"]);
                        borrowOrder.Restore_time = Convert.ToDateTime(dataReader["Restore_time"]);
                        borrowOrder.Restore_state = Convert.ToBoolean(dataReader["Restore_state"]);
                        borrowOrder.Remark = Convert.ToString(dataReader["Remark"]);

                        //讀價格
                        sqlQuery = "SELECT * FROM dbo.BorrowRecord " +
                                          $"WHERE Order_id = {borrowOrder.Id}";
                        command = new SqlCommand(sqlQuery, connection);

                        int totalPrice = 0;
                        using (SqlDataReader dataReader2 = await command.ExecuteReaderAsync(CommandBehavior.SequentialAccess)) {
                            while (await dataReader2.ReadAsync()) {
                                totalPrice += Convert.ToInt32(dataReader2["Price"]);
                            }
                        }

                        member.Name = Convert.ToString(dataReader["Name"]);
                        member.Id = totalPrice; //把訂單價格寫進user id 方便!
                        borrowOrder.Member = member;
                        borrowOrders.Add(borrowOrder);
                    }
                }
            }
            return View(borrowOrders);
        }

        // GET: UserOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) {
                return NotFound();
            }
            var user = await _userManager.GetUserAsync(User);
            if (user == null) {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            BorrowOrder borrowOrder = new BorrowOrder();
            Member member = new Member();
            List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();
                String sqlQuery = $"SELECT * FROM dbo.BorrowOrder " +
                            "inner join Member " +
                            "on Member.Stu_mail = BorrowOrder.Stu_mail " +
                            $"WHERE BorrowOrder.Id = {id} AND BorrowOrder.Stu_mail = '{user.UserName}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                using (SqlDataReader dataReader = await command.ExecuteReaderAsync(CommandBehavior.SingleResult)) {
                    if (dataReader.HasRows) {
                        dataReader.Read();
                        borrowOrder.Id = Convert.ToInt32(dataReader["Id"]);
                        borrowOrder.Stu_mail = Convert.ToString(dataReader["Stu_mail"]);
                        borrowOrder.Borrow_time = Convert.ToDateTime(dataReader["Borrow_time"]);
                        borrowOrder.Restore_time = Convert.ToDateTime(dataReader["Restore_time"]);
                        borrowOrder.Restore_state = Convert.ToBoolean(dataReader["Restore_state"]);
                        borrowOrder.Remark = Convert.ToString(dataReader["Remark"]);

                        member.Name = Convert.ToString(dataReader["Name"]);
                        member.Hot_mail = Convert.ToString(dataReader["Hot_mail"]);
                        member.Member_fee = Convert.ToBoolean(dataReader["Member_fee"]);
                    } else {
                        return NotFound();
                    }
                }

                sqlQuery = "SELECT * FROM dbo.BorrowRecord " +
                                            "inner join Equipment " +
                                            "on Equipment.Id = BorrowRecord.Item_id " +
                                            $"WHERE Order_id = {id}";
                command = new SqlCommand(sqlQuery, connection);

                using (SqlDataReader dataReader = await command.ExecuteReaderAsync(CommandBehavior.SequentialAccess)) {
                    while (await dataReader.ReadAsync()) {
                        BorrowRecord borrowRecord = new BorrowRecord();
                        Equipment equipment = new Equipment();
                        borrowRecord.Order_id = Convert.ToInt32(dataReader["Order_id"]);
                        borrowRecord.Item_id = Convert.ToInt32(dataReader["Item_id"]);
                        borrowRecord.Quantuty = Convert.ToInt32(dataReader["Quantuty"]);
                        borrowRecord.Price = Convert.ToInt32(dataReader["Price"]);
                        borrowRecord.Remark = Convert.ToString(dataReader["Remark"]);

                        equipment.Id = Convert.ToInt32(dataReader["Id"]);
                        equipment.Img = (byte[])dataReader["Img"];
                        equipment.Name = Convert.ToString(dataReader["Name"]);
                        equipment.Price_non_member = Convert.ToInt32(dataReader["Price_non_member"]);
                        equipment.Price_member = Convert.ToInt32(dataReader["Price_member"]);
                        borrowRecord.Equipment = equipment;
                        borrowRecords.Add(borrowRecord);
                    }
                }

            }
            borrowOrder.BorrowRecords = borrowRecords;
            borrowOrder.Member = member;
            return View(borrowOrder);
        }
        }
}
