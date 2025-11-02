using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DataSurvey.Models;

namespace DataSurvey.Controllers
{
    public class TeacherController : Controller
    {
        private readonly SurveyContext _context;

        public TeacherController(SurveyContext context)
        {
            _context = context;
        }

        public IActionResult Teacher(int? instructorId)
        {
            // Get all instructors
            var allInstructors = _context.Instructors.OrderBy(t => t.Name).ToList();
            ViewBag.Teachers = allInstructors;

            // Default to empty list of students
            List<Student> students = new List<Student>();

            if (instructorId.HasValue && instructorId.Value > 0)
            {
                var teacher = _context.Instructors.FirstOrDefault(t => t.InstructorId == instructorId.Value);
                if (teacher != null)
                {
                    students = _context.Students
                        .Where(s =>
                            (s.Programming && teacher.Programming) ||
                            (s.Welding && teacher.Welding) ||
                            (s.CyberSecurity && teacher.CyberSecurity) ||
                            (s.CulinaryArts && teacher.CulinaryArts))
                        .OrderBy(s => s.Name)
                        .ToList();
                }
            }

            ViewBag.Students = students;
            ViewBag.SelectedInstructorId = instructorId ?? 0;

            return View();
        }


        [HttpGet]
        public IActionResult TeachSurvey()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitSurvey(int InstructorId, List<int> SelectedStudents)
        {
            if (InstructorId == 0 || SelectedStudents == null || !SelectedStudents.Any())
            {
                TempData["Error"] = "Please select an instructor and at least one student.";
                ViewBag.Teachers = _context.Instructors.OrderBy(i => i.Name).ToList();
                ViewBag.Students = _context.Students.ToList();
                ViewBag.SelectedInstructorId = InstructorId;
                return View("MakeSurvey");
            }

            var instructor = _context.Instructors.FirstOrDefault(i => i.InstructorId == InstructorId);
            var model = new TeacherSurvey
            {
                InstructorId = InstructorId,
                TeacherName = instructor?.Name ?? "",
                SelectedStudents = SelectedStudents
            };

            ViewBag.AllStudents = _context.Students.ToList();

            return View("TeachSurvey", model);
        }
    }
}
