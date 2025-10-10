using Microsoft.EntityFrameworkCore;
namespace DataSurvey.Models
{
    public class SurveyContext : DbContext
    {
        public SurveyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = null;
        public DbSet<Instructor> Instructors { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 900000001,
                    Name = "Jack Shurling",
                    Username = "jshurling",
                    Password = "password1",
                    Email = "jshurlin@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Student
                {
                    StudentId = 900000002,
                    Name = "Jane Doe",
                    Username = "jdoe",
                    Password = "password2",
                    Email = "jdoe@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = true,
                    CulinaryArts = true
                },

                new Student
                {
                    StudentId = 900000003,
                    Name = "John Doe",
                    Username = "jdoe1",
                    Password = "password3",
                    Email = "johndoe@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = true,
                    CyberSecurity = false,
                    CulinaryArts = true
                },

                new Student
                {
                    StudentId = 900000004,
                    Name = "Lebron James",
                    Username = "ljames",
                    Password = "password4",
                    Email = "ljames@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = true,
                    CulinaryArts = false
                },

                new Student
                {
                    StudentId = 900000005,
                    Name = "Willy Wonka",
                    Username = "wwonka",
                    Password = "password5",
                    Email = "wwonka@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = true
                },

                new Student
                {
                    StudentId = 900000006,
                    Name = "First Last",
                    Username = "flast",
                    Password = "password6",
                    Email = "flast@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = false,
                    CyberSecurity = true,
                    CulinaryArts = false
                },

                new Student
                {
                    StudentId = 900000007,
                    Name = "Welding Student",
                    Username = "wstudent",
                    Password = "password7",
                    Email = "wstudent@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = true,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Student
                {
                    StudentId = 900000008,
                    Name = "Gordon Ramsey",
                    Username = "gramsey",
                    Password = "password8",
                    Email = "gramsey@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = true
                },

                new Student
                {
                    StudentId = 900000009,
                    Name = "Outta Ideas",
                    Username = "oideas",
                    Password = "password9",
                    Email = "oideas@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = true,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Student
                {
                    StudentId = 900000010,
                    Name = "Over Achiever",
                    Username = "oachiever",
                    Password = "password10",
                    Email = "oachiever@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = true,
                    CyberSecurity = true,
                    CulinaryArts = true
                }

            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    InstructorId = 1,
                    Name = "Tenario Powell",
                    Username = "tpowell",
                    Password = "password1",
                    Email = "tpowell@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Instructor
                {
                    InstructorId = 2,
                    Name = "Alton Brown",
                    Username = "abrown",
                    Password = "password2",
                    Email = "abrown@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = true
                },

                new Instructor
                {
                    InstructorId = 3,
                    Name = "Script Kiddy",
                    Username = "skiddy",
                    Password = "password3",
                    Email = "skiddy@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = false,
                    CyberSecurity = true,
                    CulinaryArts = false
                },

                new Instructor
                {
                    InstructorId = 4,
                    Name = "Weld One",
                    Username = "wone",
                    Password = "password4",
                    Email = "wone@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = true,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Instructor
                {
                    InstructorId = 5,
                    Name = "Programming Instructor",
                    Username = "pinstructor",
                    Password = "password5",
                    Email = "pinstructor@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Instructor
                {
                    InstructorId = 6,
                    Name = "Welding Instructor",
                    Username = "jshurling",
                    Password = "password6",
                    Email = "winstructor@smartweb.augustatech.edu",
                    Programming = true,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = false
                },

                new Instructor
                {
                    InstructorId = 7,
                    Name = "CyberSecurity Instructor",
                    Username = "cyinstructor",
                    Password = "password7",
                    Email = "cinstructor@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = false,
                    CyberSecurity = true,
                    CulinaryArts = false
                },

                new Instructor
                {
                    InstructorId = 8,
                    Name = "CulinaryArts Instructor",
                    Username = "cainstructor",
                    Password = "password8",
                    Email = "cainstructor@smartweb.augustatech.edu",
                    Programming = false,
                    Welding = false,
                    CyberSecurity = false,
                    CulinaryArts = true
                }
            );

        }
        
    }
}
