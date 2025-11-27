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
        [HttpGet]
        public IActionResult TakeSurvey(string id)
        {
            var survey = _context.Surveys.FirstOrDefault(s => s.SurveyId == id);
            List<SurveyOptions> options = new List<SurveyOptions>();
            options = _context.SurveyOptions.Where(o => o.SurveyId == id).OrderBy(o => o.OptionName).ToList();
            ViewBag.Options = options;
            SurveyViewModel model = new SurveyViewModel
            {
                SelectedSurvey = _context.Surveys.FirstOrDefault(s => s.SurveyId == id),
                SurveyOptions = _context.SurveyOptions.FirstOrDefault(s => s.SurveyId == id),
                SurveyResponses = _context.SurveyResponses.FirstOrDefault(s => s.SurveyId == id)
            };
            ViewBag.Survey = _context.Surveys.FirstOrDefault(s => s.SurveyId == id);
            ViewBag.SurveyOptions = _context.SurveyOptions.FirstOrDefault(s => s.SurveyId == id);
            if (survey == null)
            {
                return NotFound();
            }
            return View(model);
        }


        [HttpPost]
        public IActionResult TakeSurvey(SurveyViewModel model)
        {
            var responseid = Guid.NewGuid();
            SurveyResponses responses = new SurveyResponses()
            {
                SurveyResponsesId = responseid.ToString(),
                SurveyId = model.SelectedSurvey.SurveyId,
                OptionId = model.SurveyOptions.OptionId
            };
            _context.Add(responses);
            _context.SaveChanges();
            return View("SurveySubmitted", model);
        }
    }
}
