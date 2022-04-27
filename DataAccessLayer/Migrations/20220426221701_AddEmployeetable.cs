using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AddEmployeetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCompanyIdentityNo = table.Column<int>(type: "int", nullable: false),
                    EmployeeCompanyStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDateOfStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeDrivinLicenseClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCompanySeniorityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCompanyDegreeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCitizenshipNo = table.Column<int>(type: "int", nullable: false),
                    EemployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeemployeeBirthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCityOfRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCountyOfRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDayOffNumber = table.Column<int>(type: "int", nullable: false),
                    EmployeeUnionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeUnionIdentityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeWage = table.Column<int>(type: "int", nullable: false),
                    EmployeeMaritalStatus = table.Column<int>(type: "int", nullable: false),
                    EmployeeNumberOfChildren = table.Column<int>(type: "int", nullable: false),
                    EmployeePartnerWorkingStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
