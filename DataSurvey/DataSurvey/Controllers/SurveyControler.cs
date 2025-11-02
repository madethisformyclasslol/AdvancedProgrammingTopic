using Microsoft.AspNetCore.Mvc;
using DataSurvey.Models;
using System.Linq;

namespace DataSurvey.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyContext _context;

        public SurveyController(SurveyContext context)
        {
            _context = context;
        }

        // GET: /Survey/Survey
        public IActionResult Survey()
        {
            var surveys = _context.Surveys.ToList();
            return View(surveys);
        }

        // GET: /Survey/TakeSurvey/5
        public IActionResult TakeSurvey(int id)
        {
            var survey = _context.Surveys.FirstOrDefault(s => s.SurveyId == id);
            if (survey == null)
            {
                return NotFound();
            }
            return View(survey);
        }
    }
}
