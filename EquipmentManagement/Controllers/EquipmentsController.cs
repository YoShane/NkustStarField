﻿using System;
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

namespace EquipmentManagement.Controllers
{
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
            return View(await _context.Equipment.ToListAsync());

        }

        // GET: Equipments/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Equipments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Img,Name,Quantity,Price_non_member,Price_member,Source,Special,Period_time,Location")] Equipment equipment, IFormFile Image)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity,Price_non_member,Price_member,Source,Special,Period_time,Location")] Equipment equipment, IFormFile Image)
        {
            if (id != equipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                int tmpBit = 0;
                if (equipment.Special) tmpBit = 1;
                try
                {
                    String sqlQuery = "";

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
                        sqlQuery = $"UPDATE dbo.Equipment SET Img = @img, Period_time = @d," +
$" Name = '{equipment.Name}', Source = '{equipment.Source}', Location = '{equipment.Location_code}', Quantity = {equipment.Quantity}, Price_non_member = {equipment.Price_non_member}, Price_member = {equipment.Price_member}, Special = {tmpBit} WHERE Id = {id}";
                    } else {
                        sqlQuery = $"UPDATE dbo.Equipment SET Name = '{equipment.Name}', Period_time = @d," +
                    $" Source = '{equipment.Source}', Location = '{equipment.Location_code}', Quantity = {equipment.Quantity}, Price_non_member = {equipment.Price_non_member}, Price_member = {equipment.Price_member}, Special = {tmpBit} WHERE Id = {id}";
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString)) {

                        using (SqlCommand command = new SqlCommand(sqlQuery, connection)) {
                            await connection.OpenAsync();
                            command.Parameters.Add("@d", SqlDbType.DateTime2).Value = equipment.Period_time;
                            command.Parameters.Add("@img", SqlDbType.Binary).Value = equipment.Img;
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
