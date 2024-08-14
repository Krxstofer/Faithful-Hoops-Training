using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Interfaces;
using FaithfulHoopsTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FaithfulHoopsTraining.Controllers
{
    public class HoopSessionController : Controller
    {
        private readonly IHoopSessionRepository _hoopSessionRepository;

        public HoopSessionController(IHoopSessionRepository hoopSessionRepository)
        {
            _hoopSessionRepository = hoopSessionRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<HoopSession> hoopSessions = await _hoopSessionRepository.GetAll();
            return View(hoopSessions);
        }
        public async Task<IActionResult> HoopDetail(int id) 
        { 
            HoopSession hoopSession = await _hoopSessionRepository.GetByIdAsync(id);
            return View(hoopSession);
        }
    }
}
