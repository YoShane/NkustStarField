using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EquipmentManagement.Models;
using EquipmentManagement.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EquipmentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Equipment.ToListAsync());
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
