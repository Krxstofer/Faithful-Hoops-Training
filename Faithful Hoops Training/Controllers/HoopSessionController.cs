using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult HomeDetail(int id) 
        { 
            HoopSession hoopSession = _context.HoopSessions.FirstOrDefault(h => h.Id == id);
            return View(hoopSession);
        }
    }
}
