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
                    ViewBag.SelectedInstructor = teacher.Name;
                }
            }

            ViewBag.Students = students;
            ViewBag.SelectedInstructorId = instructorId ?? 0;
            ViewBag.Instructors = allInstructors;

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
            var surveyid = Guid.NewGuid();
            if (InstructorId == 0 || SelectedStudents == null || !SelectedStudents.Any())
            {
                TempData["Error"] = "Please select an instructor and at least one student.";
                ViewBag.Teachers = _context.Instructors.OrderBy(i => i.Name).ToList();
                ViewBag.Students = _context.Students.ToList();
                ViewBag.SelectedInstructorId = InstructorId;
                return View("Teacher");
            }

            var instructor = _context.Instructors.FirstOrDefault(i => i.InstructorId == InstructorId);
            var survey = new Survey
            {
                SurveyId = surveyid.ToString(),
                SurveyName = instructor?.Name ?? "Unknown Student",
                StudentSurvey = false,
                InstructorSurvey = true

            };
            foreach (var studentId in SelectedStudents)
            {
                var surveyOption = new SurveyOptions
                {
                    SurveyId = surveyid.ToString(),
                    OptionName = _context.Students.FirstOrDefault(s => s.StudentId == studentId)?.Name ?? ""
                };
                _context.SurveyOptions.Add(surveyOption);
            }
            _context.Surveys.Add(survey);

            ViewBag.AllStudents = _context.Students.ToList();
            _context.SaveChanges();

            return View("TeachSurvey", survey);
        }
    }
}
