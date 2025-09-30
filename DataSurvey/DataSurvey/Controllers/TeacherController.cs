using Microsoft.AspNetCore.Mvc;
using DataSurvey.Models;

namespace DataSurvey.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Teacher()
        {
            var model = new TeacherSurvey();
            return View(model);
        }

        [HttpPost]
        public IActionResult Teacher(TeacherSurvey model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View("TeachSurvey", model);
        }

        public IActionResult TeachSurvey(TeacherSurvey model)
        {
            return View(model);
        }
    }
}
