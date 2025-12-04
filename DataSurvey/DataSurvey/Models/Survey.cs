using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataSurvey.Models
{
    public class Survey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }  // now auto-increment PK
        //Main survey class, SurveyName matches the question being surveyed eg "Which student in Welding program is a star student?"
        public string SurveyId { get; set; }
        public string SurveyName { get; set; }
        public bool StudentSurvey { get; set; }
        public bool InstructorSurvey { get; set; }
    }
}
