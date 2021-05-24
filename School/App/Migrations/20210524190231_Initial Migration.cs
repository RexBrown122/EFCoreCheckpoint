using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    ClassYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentID = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseName = table.Column<string>(type: "TEXT", nullable: true),
                    Grade = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "ClassYear", "FirstName", "LastName" },
                values: new object[] { 1, 15, 0, "Mark", "Flores" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "ClassYear", "FirstName", "LastName" },
                values: new object[] { 2, 16, 1, "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "ClassYear", "FirstName", "LastName" },
                values: new object[] { 3, 17, 2, "Jessica", "Robinson" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "ClassYear", "FirstName", "LastName" },
                values: new object[] { 4, 18, 3, "Rex", "Brown" });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "CourseName", "Grade", "StudentID" },
                values: new object[] { 1, "English", 80f, 1 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "CourseName", "Grade", "StudentID" },
                values: new object[] { 2, "Math", 60f, 2 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "CourseName", "Grade", "StudentID" },
                values: new object[] { 3, "Science", 75f, 3 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "ID", "CourseName", "Grade", "StudentID" },
                values: new object[] { 4, "Government", 90f, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentID",
                table: "Grades",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
