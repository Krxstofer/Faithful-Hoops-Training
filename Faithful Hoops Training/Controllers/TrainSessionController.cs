using FaithfulHoopsTraining.Data;
using FaithfulHoopsTraining.Interfaces;
using FaithfulHoopsTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FaithfulHoopsTraining.Controllers
{
    public class TrainSessionController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ITrainSessionRepository _trainSessionRepository;

        public TrainSessionController(ITrainSessionRepository trainSessionRepository)
        {
            _trainSessionRepository = trainSessionRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<TrainSession> trainSessions = await _trainSessionRepository.GetAll();
            return View(trainSessions);
        }
        public async Task<IActionResult> TrainDetail(int id)
        {
            TrainSession trainSession = await _trainSessionRepository.GetByIdAsync(id);
            return View(trainSession);
        }
    }
}
