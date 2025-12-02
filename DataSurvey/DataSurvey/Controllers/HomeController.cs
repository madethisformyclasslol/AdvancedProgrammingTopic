using DataSurvey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DataSurvey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public readonly SurveyContext _context;

        public HomeController(SurveyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Database()
        {
            var surveys = _context.Surveys.ToList();
            return View(surveys);
        }

        public IActionResult SurveyAnalytics(string id) 
        {
            var survey = _context.Surveys.FirstOrDefault(s => s.SurveyId == id);
            List<SurveyResponses> responses = new List<SurveyResponses>();
            responses = _context.SurveyResponses
                .Where(r => r.SurveyId == id)
                .ToList();
            int count = 0;
            string name;
            Dictionary<string, int> surveydata = new Dictionary<string, int>();
            foreach (var response in responses) { 
                count = responses
                    .Where(r => r.OptionId == response.OptionId)
                    .Count();
                name = response.OptionName;
                surveydata[name] = count;
                ViewBag.Name = name;
            }
            
            ViewBag.SurveyData = surveydata;
            ViewBag.SurveyName = survey.SurveyName;
            return View(responses);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}