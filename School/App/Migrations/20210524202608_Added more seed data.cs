using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class Addedmoreseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "CourseName", "Grade", "StudentID" },
                values: new object[] { 5, "English", 100f, 2 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "ClassYear", "FirstName", "LastName" },
                values: new object[] { 5, 18, 3, "Amanda", "Johnson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
