using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Models;
using Microsoft.AspNetCore.Mvc;

namespace FaithfulHoopsTraining.Controllers
{
    public class TrainSessionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainSessionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<TrainSession> trainSessions = _context.TrainSessions.ToList();
            return View(trainSessions);
        }
    }
}
