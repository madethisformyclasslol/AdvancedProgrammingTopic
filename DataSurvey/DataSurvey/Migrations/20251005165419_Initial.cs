using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataSurvey.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Programming = table.Column<bool>(type: "bit", nullable: false),
                    Welding = table.Column<bool>(type: "bit", nullable: false),
                    CyberSecurity = table.Column<bool>(type: "bit", nullable: false),
                    CulinaryArts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Programming = table.Column<bool>(type: "bit", nullable: false),
                    Welding = table.Column<bool>(type: "bit", nullable: false),
                    CyberSecurity = table.Column<bool>(type: "bit", nullable: false),
                    CulinaryArts = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorId", "CulinaryArts", "CyberSecurity", "Email", "Name", "Password", "Programming", "Username", "Welding" },
                values: new object[,]
                {
                    { 1, false, false, "tpowell@smartweb.augustatech.edu", "Tenario Powell", "password1", true, "tpowell", false },
                    { 2, true, false, "abrown@smartweb.augustatech.edu", "Alton Brown", "password2", false, "abrown", false },
                    { 3, false, true, "skiddy@smartweb.augustatech.edu", "Script Kiddy", "password3", false, "skiddy", false },
                    { 4, false, false, "wone@smartweb.augustatech.edu", "Weld One", "password4", false, "wone", true },
                    { 5, false, false, "pinstructor@smartweb.augustatech.edu", "Programming Instructor", "password5", true, "pinstructor", false },
                    { 6, false, false, "winstructor@smartweb.augustatech.edu", "Welding Instructor", "password6", true, "jshurling", false },
                    { 7, false, true, "cinstructor@smartweb.augustatech.edu", "CyberSecurity Instructor", "password7", false, "cyinstructor", false },
                    { 8, true, false, "cainstructor@smartweb.augustatech.edu", "CulinaryArts Instructor", "password8", false, "cainstructor", false }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CulinaryArts", "CyberSecurity", "Email", "Name", "Password", "Programming", "Username", "Welding" },
                values: new object[,]
                {
                    { 1, false, false, "jshurlin@smartweb.augustatech.edu", "Jack Shurling", "password1", true, "jshurling", false },
                    { 2, true, true, "jdoe@smartweb.augustatech.edu", "Jane Doe", "password2", true, "jdoe", false },
                    { 3, true, false, "johndoe@smartweb.augustatech.edu", "John Doe", "password3", false, "jdoe1", true },
                    { 4, false, true, "ljames@smartweb.augustatech.edu", "Lebron James", "password4", true, "ljames", false },
                    { 5, true, false, "wwonka@smartweb.augustatech.edu", "Willy Wonka", "password5", true, "wwonka", false },
                    { 6, false, true, "flast@smartweb.augustatech.edu", "First Last", "password6", false, "flast", false },
                    { 7, false, false, "wstudent@smartweb.augustatech.edu", "Welding Student", "password7", false, "wstudent", true },
                    { 8, true, false, "gramsey@smartweb.augustatech.edu", "Gordon Ramsey", "password8", false, "gramsey", false },
                    { 9, false, false, "oideas@smartweb.augustatech.edu", "Outta Ideas", "password9", true, "oideas", true },
                    { 10, true, true, "oachiever@smartweb.augustatech.edu", "Over Achiever", "password10", true, "oachiever", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
