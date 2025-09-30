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

        public IActionResult Privacy()
        {
            return View();
        }
    }
}