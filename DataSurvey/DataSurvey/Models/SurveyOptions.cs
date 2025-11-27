using System.ComponentModel.DataAnnotations;

namespace DataSurvey.Models
{
    public class SurveyOptions
    {
        //When survey is loaded, all optionId matching selected SurveyId are pulled
        //Options are created by matching the type of survey to the booleans associated with each instructor/student.
        //example: a survey for welding professors will pull welding professors as options

        [Key]
        public int OptionId { get; set; }

        //foreign key for Survey class SurveyIds
        public string SurveyId { get; set; }

        public string OptionName { get; set; } = string.Empty;
    }
}
