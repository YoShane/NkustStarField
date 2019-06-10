using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;

namespace EquipmentManagement.Controllers
{
    public class BorrowRecordsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BorrowRecordsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BorrowRecords
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.BorrowRecord.Include(b => b.BorrowOrder).Include(b => b.Equipment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: BorrowRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowRecord = await _context.BorrowRecord
                .Include(b => b.BorrowOrder)
                .Include(b => b.Equipment)
                .FirstOrDefaultAsync(m => m.id == id);
            if (borrowRecord == null)
            {
                return NotFound();
            }

            return View(borrowRecord);
        }

        // GET: BorrowRecords/Create
        public IActionResult Create()
        {
            ViewData["Order_id"] = new SelectList(_context.BorrowOrder, "Id", "Id");
            ViewData["Item_id"] = new SelectList(_context.Equipment, "Id", "Name");

            return View();
        }

        // POST: BorrowRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Order_id,Item_id,Quantuty,Price,Remark")] BorrowRecord borrowRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrowRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Order_id"] = new SelectList(_context.BorrowOrder, "Id", "Id", borrowRecord.Order_id);
            ViewData["Item_id"] = new SelectList(_context.Equipment, "Id", "Name", borrowRecord.Item_id);
            return View(borrowRecord);
        }

        // GET: BorrowRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowRecord = await _context.BorrowRecord.FindAsync(id);
            if (borrowRecord == null)
            {
                return NotFound();
            }
            ViewData["Order_id"] = new SelectList(_context.BorrowOrder, "Id", "Id", borrowRecord.Order_id);
            ViewData["Item_id"] = new SelectList(_context.Equipment, "Id", "Name", borrowRecord.Item_id);
            return View(borrowRecord);
        }

        // POST: BorrowRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Order_id,Item_id,Quantuty,Price,Remark")] BorrowRecord borrowRecord)
        {
            if (id != borrowRecord.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrowRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowRecordExists(borrowRecord.id))
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
            ViewData["Order_id"] = new SelectList(_context.BorrowOrder, "Id", "Id", borrowRecord.Order_id);
            ViewData["Item_id"] = new SelectList(_context.Equipment, "Id", "Name", borrowRecord.Item_id);
            return View(borrowRecord);
        }

        // GET: BorrowRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowRecord = await _context.BorrowRecord
                .Include(b => b.BorrowOrder)
                .Include(b => b.Equipment)
                .FirstOrDefaultAsync(m => m.id == id);
            if (borrowRecord == null)
            {
                return NotFound();
            }

            return View(borrowRecord);
        }

        // POST: BorrowRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var borrowRecord = await _context.BorrowRecord.FindAsync(id);
            _context.BorrowRecord.Remove(borrowRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorrowRecordExists(int id)
        {
            return _context.BorrowRecord.Any(e => e.id == id);
        }
    }
}
