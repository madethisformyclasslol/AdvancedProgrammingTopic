namespace DataSurvey.Models
{
    public class SurveyResponses
    {
        //class for table containing responses to individual surveys.
        //When a survey is pulled from the database, responses matching the surveyId are also pulled.
        //OptionId is used as a foreign key to the options database, matching the reponse to the selected option

        int ResponseId { get; set; }

        int SurveyId{ get; set; }

        int OptionId { get; set; }
    }
}
