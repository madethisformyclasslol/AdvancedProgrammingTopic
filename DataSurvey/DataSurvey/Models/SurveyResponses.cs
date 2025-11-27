namespace DataSurvey.Models
{
    public class SurveyResponses
    {
        // Primary key
        public string SurveyResponsesId { get; set; }

        // Foreign key: which Survey this response belongs to
        public string SurveyId { get; set; }

        // Optional link to a specific option (e.g., Student or Instructor)
        public int OptionId { get; set; }

        // Optional text field if you ever add open-ended responses later
        public string? ResponseText { get; set; }
    }
}

