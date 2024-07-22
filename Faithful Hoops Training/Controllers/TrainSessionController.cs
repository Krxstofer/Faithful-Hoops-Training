using Microsoft.AspNetCore.Mvc;

namespace FaithfulHoopsTraining.Controllers
{
    public class TrainSessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
