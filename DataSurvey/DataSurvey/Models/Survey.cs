namespace DataSurvey.Models
{
    public class Survey
    {
        //Main survey class, SurveyName matches the question being surveyed eg "Which student in Welding program is a star student?"
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
    }
}
