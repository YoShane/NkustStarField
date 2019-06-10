﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using EquipmentManagement.Models;
using EquipmentManagement.Data;

namespace borrowOrderManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BorrowOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string connectionString;

        public BorrowOrdersController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // GET: BorrowOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.BorrowOrder.ToListAsync());
        }

        // GET: BorrowOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BorrowOrder borrowOrder = new BorrowOrder();
            Member member = new Member();
            List<BorrowRecord> borrowRecords = new List<BorrowRecord>();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();
                String sqlQuery = $"SELECT * FROM dbo.BorrowOrder "+
                            "inner join Member "+
                            "on Member.Stu_mail = BorrowOrder.Stu_mail "+
                            $"WHERE BorrowOrder.Id = {id}";
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
                    }
                }
                
                sqlQuery = "SELECT * FROM dbo.BorrowRecord "+
                                            "inner join Equipment "+
                                            "on Equipment.Id = BorrowRecord.Item_id "+
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

        // GET: BorrowOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BorrowOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Stu_mail,Borrow_time,Restore_time,Restore_state,Remark")] BorrowOrder borrowOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrowOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(borrowOrder);
        }

        // GET: BorrowOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowOrder = await _context.BorrowOrder.FindAsync(id);
            if (borrowOrder == null)
            {
                return NotFound();
            }
            return View(borrowOrder);
        }

        // POST: BorrowOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Stu_mail,Borrow_time,Restore_time,Restore_state,Remark")] BorrowOrder borrowOrder)
        {
            if (id != borrowOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrowOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowOrderExists(borrowOrder.Id))
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
            return View(borrowOrder);
        }

        // GET: BorrowOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowOrder = await _context.BorrowOrder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowOrder == null)
            {
                return NotFound();
            }

            return View(borrowOrder);
        }

        // POST: BorrowOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var borrowOrder = await _context.BorrowOrder.FindAsync(id);
            _context.BorrowOrder.Remove(borrowOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorrowOrderExists(int id)
        {
            return _context.BorrowOrder.Any(e => e.Id == id);
        }
    }
}
