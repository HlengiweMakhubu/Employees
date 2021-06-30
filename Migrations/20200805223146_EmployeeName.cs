using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Migrations
{
    public partial class EmployeeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "EmployeeInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "EmployeeInfo");
        }
    }
}
