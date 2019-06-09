using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace EquipmentManagement.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string connectionString;

        public LocationsController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            this.connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // GET: Locations
        public async Task<IActionResult> Index()
        {
            List<Location> locations = new List<Location>();
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                //SqlDataReader
                await connection.OpenAsync();
                String sqlQuery = "SELECT * FROM dbo.Location ORDER BY Name ASC";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                using (SqlDataReader dataReader = await command.ExecuteReaderAsync(CommandBehavior.SequentialAccess)) {
                    while (await dataReader.ReadAsync()) {
                        Location location = new Location();
                        location.Location_code = Convert.ToString(dataReader["Location_code"]);
                        location.Name = Convert.ToString(dataReader["Name"]);
                        locations.Add(location);
                    }
                }

            }

            return View(locations);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Location_code,Name")] Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Location_code,Name")] Location location)
        {
            if (id != location.Location_code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(location);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationExists(location.Location_code))
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
            return View(location);
        }

        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.Location_code == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var location = await _context.Location.FindAsync(id);
            _context.Location.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationExists(string id)
        {
            return _context.Location.Any(e => e.Location_code == id);
        }


    }
}
