using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FaithfulHoopsTraining.Controllers
{
    public class HoopSessionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HoopSessionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<HoopSession> hoopSessions = _context.HoopSessions.ToList();
            return View(hoopSessions);
        }
        public IActionResult HoopDetail(int id) 
        { 
            HoopSession hoopSession = _context.HoopSessions.Include(a => a.Address).FirstOrDefault(h => h.Id == id);
            return View(hoopSession);
        }
    }
}
