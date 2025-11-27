namespace DataSurvey.Models
{
    public class Survey
    {
        //Main survey class, SurveyName matches the question being surveyed eg "Which student in Welding program is a star student?"
        public string SurveyId { get; set; }
        public string SurveyName { get; set; }
        public bool StudentSurvey { get; set; }
        public bool InstructorSurvey { get; set; }
    }
}
