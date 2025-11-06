using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Staff_Point.Models;

namespace Staff_Point.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AdminController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Student_Staff()
        {
            return View();
        }
        public IActionResult Account_Manage()
        {
            return View();
        }
        public IActionResult Data_Registration()
        {
            return View();
        }
        public IActionResult Participants()
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
