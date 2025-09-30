using System.ComponentModel.DataAnnotations;

namespace DataSurvey.Models
{
    public class StudentSurvey
    {
        [Required(ErrorMessage = "Student name is required.")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Student ID is required.")]
        [Range(900000000, 999999999, ErrorMessage = "Student ID must be between 900000000 and 999999999.")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "You must select at least one instructor.")]
        public List<string> SelectedInstructors { get; set; }
    }

    public class TeacherSurvey
    {
        [Required(ErrorMessage = "Teacher name is required.")]
        public string TeacherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "You must select at least one student.")]
        public List<string> SelectedStudents { get; set; }
    }
}
