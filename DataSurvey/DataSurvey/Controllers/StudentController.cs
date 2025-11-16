using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DataSurvey.Models;

namespace DataSurvey.Controllers
{
    public class StudentController : Controller
    {
        private readonly SurveyContext _context;

        public StudentController(SurveyContext context)
        {
            _context = context;
        }

        // Main survey form
        public IActionResult Student(int? studentId)
        {
            var students = _context.Students.OrderBy(s => s.Name).ToList();
            List<Instructor> instructors = new List<Instructor>();

            if (studentId.HasValue)
            {
                var student = _context.Students.FirstOrDefault(s => s.StudentId == studentId);
                if (student != null)
                {
                    instructors = _context.Instructors
                        .Where(i => (student.Programming && i.Programming) ||
                                    (student.Welding && i.Welding) ||
                                    (student.CyberSecurity && i.CyberSecurity) ||
                                    (student.CulinaryArts && i.CulinaryArts))
                        .OrderBy(i => i.Name)
                        .ToList();
                }
            }

            ViewBag.Students = students;
            ViewBag.SelectedStudentId = studentId ?? 0;
            ViewBag.Instructors = instructors;

            return View();
        }

        [HttpGet]
        public IActionResult StuSurvey()
        {
            // Return empty model if navigated directly
            return View();
        }

        [HttpPost]
        public IActionResult SubmitSurvey(int StudentId, List<int> SelectedInstructors)
        {
            if (StudentId == 0 || SelectedInstructors == null || !SelectedInstructors.Any())
            {
                TempData["Error"] = "Please select a student and at least one instructor.";
                ViewBag.Students = _context.Students.OrderBy(s => s.Name).ToList();
                ViewBag.Instructors = _context.Instructors.ToList();
                ViewBag.SelectedStudentId = StudentId;
                return View("Student");
            }

            var student = _context.Students.FirstOrDefault(s => s.StudentId == StudentId);
            var model = new StudentSurvey
            {
                StudentId = StudentId,
                StudentName = student?.Name ?? "",
                SelectedInstructors = SelectedInstructors
            };

            ViewBag.AllInstructors = _context.Instructors.ToList();

            return View("StuSurvey", model);
        }
    }
}
