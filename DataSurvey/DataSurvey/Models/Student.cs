using System.ComponentModel.DataAnnotations;

namespace DataSurvey.Models
{
    public class Student
    {
        //Main class for students used as both users and potential options in surveys
        public int StudentId { get; set; }

        public string Name {  get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool Programming { get; set; }

        public bool Welding { get; set; }

        public bool CyberSecurity { get; set; }

        public bool CulinaryArts { get; set; }
    }
}
