using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeInfo",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNum = table.Column<int>(nullable: false),
                    EmployeeDate = table.Column<DateTime>(nullable: false),
                    Terminated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInfo", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeInfo");
        }
    }
}
