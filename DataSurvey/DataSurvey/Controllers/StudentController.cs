using Microsoft.AspNetCore.Mvc;
using DataSurvey.Models;

namespace DataSurvey.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            var model = new StudentSurvey();
            return View(model);
        }

        [HttpPost]
        public IActionResult Student(StudentSurvey model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("StuSurvey", model);
        }

        public IActionResult StuSurvey(StudentSurvey model)
        {
            return View(model);
        }
    }
}
