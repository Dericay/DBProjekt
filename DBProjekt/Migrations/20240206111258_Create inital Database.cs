using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBProjekt.Migrations
{
    public partial class CreateinitalDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeparmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeparmentID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentClass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    YearsWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staffs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DeparmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolInfo",
                columns: table => new
                {
                    SchoolInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    GradeTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInfo", x => x.SchoolInfoID);
                    table.ForeignKey(
                        name: "FK_SchoolInfo_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolInfo_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolInfo_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolInfo_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseType" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Science" },
                    { 3, "Math" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeparmentID", "Deparment" },
                values: new object[,]
                {
                    { 1, "Teacher" },
                    { 2, "Admin" },
                    { 3, "IT" },
                    { 4, "HeadMaster" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "FName", "LName", "PersonalNumber", "StudentClass" },
                values: new object[,]
                {
                    { 1, "Anton", "Larsson", "9309302312", "A" },
                    { 2, "Alfred", "Larsson", "9502152255", "B" },
                    { 3, "Maureen", "Supit", "93121926677", "A" },
                    { 4, "Sara", "Lövström", "9505252222", "B" },
                    { 5, "Daniel", "Strömsson", "9607109888", "C" },
                    { 6, "Emma", "Svensson", "9604051111", "C" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffID", "DepartmentId", "FirstName", "LastName", "Salary", "YearsWorked" },
                values: new object[,]
                {
                    { 1, 3, "Anas", "Qlok", 31500, 3 },
                    { 2, 3, "Tobias", "KloQ", 30500, 6 },
                    { 3, 2, "Reinar", "SöderLund", 29400, 2 },
                    { 4, 1, "Margareta", "Danielsson", 28500, 8 },
                    { 5, 1, "Lukas", "Andersson", 26500, 3 },
                    { 6, 1, "Pontus", "Lövgren", 23500, 5 },
                    { 7, 4, "Svante", "Svanslös", 38500, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInfo_CourseId",
                table: "SchoolInfo",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInfo_GradeId",
                table: "SchoolInfo",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInfo_StaffId",
                table: "SchoolInfo",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInfo_StudentId",
                table: "SchoolInfo",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DepartmentId",
                table: "Staffs",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolInfo");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
