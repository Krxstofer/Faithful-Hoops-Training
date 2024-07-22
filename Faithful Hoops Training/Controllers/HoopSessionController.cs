using Microsoft.AspNetCore.Mvc;

namespace FaithfulHoopsTraining.Controllers
{
    public class HoopSessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
