using System.ComponentModel.DataAnnotations;

namespace DataSurvey.Models
{
    public class StudentSurvey
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public List<int> SelectedInstructors { get; set; } = new List<int>();
    }


    public class TeacherSurvey
    {
        public int InstructorId { get; set; }
        public string TeacherName { get; set; } = string.Empty;
        public List<int> SelectedStudents { get; set; } = new List<int>();
    }
}
