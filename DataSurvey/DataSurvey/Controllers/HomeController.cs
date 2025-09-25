using System.Diagnostics;
using DataSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataSurvey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Database()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }

        public IActionResult Teacher()
        {
            return View();
        }

        public IActionResult TeacherSelection()
        {
            return View();
        }

        public IActionResult StudentSelection()
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
