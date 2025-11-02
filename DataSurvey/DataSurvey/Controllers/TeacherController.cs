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
            var teachers = _context.Instructors.OrderBy(t => t.Name).ToList();
            List<Student> students = new List<Student>();

            if (instructorId.HasValue)
            {
                var teacher = _context.Instructors.FirstOrDefault(t => t.InstructorId == instructorId); if (teacher != null)
                { 
                  // Filter students matching teacher's programs
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
            else 
            { 
                // Default: show all students
                students = _context.Students.OrderBy(s => s.Name).ToList();
            } 

            ViewBag.Teachers = teachers;
            ViewBag.Students = students;
            ViewBag.SelectedInstructorId = instructorId;

            return View(); 
        }


                    [HttpGet]
        public IActionResult TeachSurvey()
        {
            return View();
        }

        // POST: /Teacher/SubmitSurvey
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
