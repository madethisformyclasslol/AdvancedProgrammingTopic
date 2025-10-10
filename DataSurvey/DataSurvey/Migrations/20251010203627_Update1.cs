using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataSurvey.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CulinaryArts", "CyberSecurity", "Email", "Name", "Password", "Programming", "Username", "Welding" },
                values: new object[,]
                {
                    { 900000001, false, false, "jshurlin@smartweb.augustatech.edu", "Jack Shurling", "password1", true, "jshurling", false },
                    { 900000002, true, true, "jdoe@smartweb.augustatech.edu", "Jane Doe", "password2", true, "jdoe", false },
                    { 900000003, true, false, "johndoe@smartweb.augustatech.edu", "John Doe", "password3", false, "jdoe1", true },
                    { 900000004, false, true, "ljames@smartweb.augustatech.edu", "Lebron James", "password4", true, "ljames", false },
                    { 900000005, true, false, "wwonka@smartweb.augustatech.edu", "Willy Wonka", "password5", true, "wwonka", false },
                    { 900000006, false, true, "flast@smartweb.augustatech.edu", "First Last", "password6", false, "flast", false },
                    { 900000007, false, false, "wstudent@smartweb.augustatech.edu", "Welding Student", "password7", false, "wstudent", true },
                    { 900000008, true, false, "gramsey@smartweb.augustatech.edu", "Gordon Ramsey", "password8", false, "gramsey", false },
                    { 900000009, false, false, "oideas@smartweb.augustatech.edu", "Outta Ideas", "password9", true, "oideas", true },
                    { 900000010, true, true, "oachiever@smartweb.augustatech.edu", "Over Achiever", "password10", true, "oachiever", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000003);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 900000010);

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
    }
}
