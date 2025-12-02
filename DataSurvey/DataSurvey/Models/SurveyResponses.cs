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

        //Name of the option selected
        public string OptionName { get; set; }
    }
}

