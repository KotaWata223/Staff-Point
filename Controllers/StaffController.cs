using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Staff_Point.Models;

namespace Staff_Point.Controllers
{
    public class StaffController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StaffController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
