using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EquipmentManagement.Data;
using EquipmentManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace EquipmentManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BorrowOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BorrowOrdersController(ApplicationDbContext context)
        {
            _context = context;
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

            var borrowOrder = await _context.BorrowOrder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borrowOrder == null)
            {
                return NotFound();
            }

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
