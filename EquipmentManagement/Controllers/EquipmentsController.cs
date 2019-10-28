using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EquipmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string connectionString;

        public EquipmentsController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // GET: Equipments
        public async Task<IActionResult> Index()
        {
            List<Equipment> equipments = new List<Equipment>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();

                String sqlQuery = "select (Quantity-total_lead) as Surplus,* from ("+
                "select Equipment.Id, 0 as \"total_lead\"" +
               "from Equipment where Id not in (select BorrowRecord.Item_id "+
                "from BorrowRecord inner join BorrowOrder "+
                "on BorrowRecord.Order_id = BorrowOrder.Id "+
                "where BorrowOrder.Restore_state = 0 /* 排除沒還 */) union "+
                "(select Item_id, SUM(Quantuty) as total_lead "+
                "from BorrowRecord inner join BorrowOrder "+
               "on BorrowRecord.Order_id = BorrowOrder.Id "+
                "where BorrowOrder.Restore_state = 0 "+
                "group by Item_id /* 找還沒還 */)) as adjTable "+
                "inner join Equipment on Equipment.Id = adjTable.Id";


                SqlCommand command = new SqlCommand(sqlQuery, connection);
                using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                    while (await dataReader.ReadAsync()) {
                        Equipment equipment = new Equipment();
                        equipment.Id = Convert.ToInt32(dataReader["Id"]);
                        try {
                            equipment.Img = (byte[])dataReader["Img"];
                        }
                        catch {
                            equipment.Img =null;
                        }
                        equipment.Name = Convert.ToString(dataReader["Name"]);
                        equipment.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                        equipment.Price_non_member = Convert.ToInt32(dataReader["Price_non_member"]);
                        equipment.Price_member = Convert.ToInt32(dataReader["Price_member"]);
                        equipment.Source = Convert.ToString(dataReader["Source"]);
                        equipment.Special = Convert.ToBoolean(dataReader["Special"]);
                        equipment.Period_time = Convert.ToDateTime(dataReader["Period_time"]);
                        equipment.Location_code = Convert.ToString(dataReader["Location_code"]);
                        equipment.Surplus = Convert.ToInt32(dataReader["Surplus"]);

                        equipments.Add(equipment);
                    }
                }

            }
            return View(equipments);
        }

        // GET: Equipments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Equipment equipment = new Equipment();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();

                String sqlQuery = "select (Quantity-total_lead) as Surplus,[Location].[Name] as tmpName,*  " +
"from (select Equipment.Id, 0 as total_lead " +
$"from Equipment where Id = {id} and Id not in (select BorrowRecord.Item_id " +
"from BorrowRecord inner join BorrowOrder " +
"on BorrowRecord.Order_id = BorrowOrder.Id " +
"where BorrowOrder.Restore_state = 0/* 補回來 */) union " +
"(select Item_id, SUM(Quantuty) as total_lead " +
"from BorrowRecord inner join BorrowOrder " +
"on BorrowRecord.Order_id = BorrowOrder.Id " +
$"where BorrowOrder.Restore_state = 0 and Item_id = {id} " +
"group by Item_id /* 找還沒還 */)) as adjTable " +
"inner join Equipment on Equipment.Id = adjTable.id " +
"inner join [Location] on [Location].Location_code = Equipment.Location_code";


                SqlCommand command = new SqlCommand(sqlQuery, connection);
                using (SqlDataReader dataReader = await command.ExecuteReaderAsync()) {
                    if (dataReader.HasRows) {
                        dataReader.Read();
                        equipment.Id = Convert.ToInt32(dataReader["Id"]);
                        equipment.Img = (byte[])dataReader["Img"];
                        equipment.Name = Convert.ToString(dataReader["Name"]);
                        equipment.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                        equipment.Price_non_member = Convert.ToInt32(dataReader["Price_non_member"]);
                        equipment.Price_member = Convert.ToInt32(dataReader["Price_member"]);
                        equipment.Source = Convert.ToString(dataReader["Source"]);
                        equipment.Special = Convert.ToBoolean(dataReader["Special"]);
                        equipment.Period_time = Convert.ToDateTime(dataReader["Period_time"]); 
                        equipment.Location_code = Convert.ToString(dataReader["tmpName"]);
                        equipment.Surplus = Convert.ToInt32(dataReader["Surplus"]);
                    }
                }

            }

            return View(equipment);
        }

        // GET: Equipments/Create
        public async Task<IActionResult> Create()
        {

            List<string> item = new List<string>();
            List<string> itemValue = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();
                String sqlQuery = "SELECT * FROM dbo.Location ORDER BY Name ASC";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                using (SqlDataReader dataReader = await command.ExecuteReaderAsync(CommandBehavior.SequentialAccess)) {
                    while (await dataReader.ReadAsync()) {
                        itemValue.Add(Convert.ToString(dataReader["Location_code"]));
                        item.Add(Convert.ToString(dataReader["Name"]));
                    }
                }
            }

            Equipment equipment = new Equipment();
            equipment.List = item;
            equipment.ListValue = itemValue;
            equipment.Quantity = 1;
            var plusTime = DateTime.Now.Date.AddYears(10);
            equipment.Period_time = plusTime;
 
            return View(equipment);
        }

        // POST: Equipments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Img,Name,Quantity,Price_non_member,Price_member,Source,Special,Period_time,Location_code")] Equipment equipment, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null) {
                    if (Image.Length > 0 && Image.Length/ 1048576.0 < 3)
                    //Convert Image to byte and save to database(3MB以內)
                    {
                        byte[] p1 = null;
                        using (var fs1 = Image.OpenReadStream())
                        using (var ms1 = new MemoryStream()) {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                        equipment.Img = p1;
                    }
                } 
                _context.Add(equipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipment);
        }

        // GET: Equipments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipment.FindAsync(id);
          
            if (equipment == null)
            {
                return NotFound();
            }
  
            return View(equipment);
        }

        // POST: Equipments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity,Price_non_member,Price_member,Source,Special,Period_time,Location_code")] Equipment equipment, IFormFile Image)
        {
            if (id != equipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (equipment.Source == null) {
                    equipment.Source = "''"; //補符號
                }
                int tmpBit = 0;
                if (equipment.Special) tmpBit = 1;
                try
                {
                    if (Image != null) {
                        if (Image.Length > 0 && Image.Length / 1048576.0 < 3)
                       //Convert Image to byte and save to database
                       {
                            byte[] p1 = null;
                            using (var fs1 = Image.OpenReadStream())
                            using (var ms1 = new MemoryStream()) {
                                fs1.CopyTo(ms1);
                                p1 = ms1.ToArray();
                            }
                            equipment.Img = p1;
                        }
                        String sqlQuery = $"UPDATE dbo.Equipment SET Img = @img, Period_time = @d," +
$" Name = @name, Source =  @source, Location_code = @code, Quantity = {equipment.Quantity}, Price_non_member = {equipment.Price_non_member}, Price_member = {equipment.Price_member}, Special = {tmpBit} WHERE Id = {id}";

                        using (SqlConnection connection = new SqlConnection(connectionString)) {

                            using (SqlCommand command = new SqlCommand(sqlQuery, connection)) {
                                await connection.OpenAsync();
                                command.Parameters.Add("@d", SqlDbType.DateTime2).Value = equipment.Period_time;
                                command.Parameters.Add("@img", SqlDbType.Binary).Value = equipment.Img;
                                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = equipment.Name;
                                command.Parameters.Add("@code", SqlDbType.NVarChar).Value = equipment.Location_code;
                                command.Parameters.Add("@source", SqlDbType.NVarChar).Value = equipment.Source;

                                try {
                                    await command.ExecuteNonQueryAsync();
                                }
                                catch (SqlException ex) {
                                    Console.WriteLine("Operation got error:" + ex.Message);
                                }
                                connection.Close();
                            }
                        }
                    } else {
                        String sqlQuery = $"UPDATE dbo.Equipment SET Name = @name, Period_time = @d," +
                    $" Source =  @source, Location_code = @code, Quantity = {equipment.Quantity}, Price_non_member = {equipment.Price_non_member}, Price_member = {equipment.Price_member}, Special = {tmpBit} WHERE Id = {id}";

                        using (SqlConnection connection = new SqlConnection(connectionString)) {

                            using (SqlCommand command = new SqlCommand(sqlQuery, connection)) {
                                await connection.OpenAsync();
                                command.Parameters.Add("@d", SqlDbType.DateTime2).Value = equipment.Period_time;
                                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = equipment.Name;
                                command.Parameters.Add("@code", SqlDbType.NVarChar).Value = equipment.Location_code;
                                command.Parameters.Add("@source", SqlDbType.NVarChar).Value = equipment.Source;

                                try {
                                    await command.ExecuteNonQueryAsync();
                                }
                                catch (SqlException ex) {
                                    Console.WriteLine("Operation got error:" + ex.Message);
                                }
                                connection.Close();
                            }
                        }
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentExists(equipment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(equipment);
        }

        // GET: Equipments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }

        // POST: Equipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipment = await _context.Equipment.FindAsync(id);
            _context.Equipment.Remove(equipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentExists(int id)
        {
            return _context.Equipment.Any(e => e.Id == id);
        }


    }
}
