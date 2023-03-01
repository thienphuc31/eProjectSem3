using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eProject1.Migrations
{
    public partial class eProject1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    admin_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    admin_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    admin_password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    department_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    department_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    event_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    event_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    event_request = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    event_startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    event_enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.event_id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    news_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    news_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    news_subtitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    news_img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    news_text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    news_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.news_id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    employee_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    employee_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    employee_password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    employee_DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employee_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    department_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.employee_id);
                    table.ForeignKey(
                        name: "FK_Employee_Department_department_id",
                        column: x => x.department_id,
                        principalTable: "Department",
                        principalColumn: "department_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bell",
                columns: table => new
                {
                    bell_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bell", x => x.bell_id);
                    table.ForeignKey(
                        name: "FK_Bell_Employee_employee_id",
                        column: x => x.employee_id,
                        principalTable: "Employee",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    contact_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contact_title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    contact_text = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    employee_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.contact_id);
                    table.ForeignKey(
                        name: "FK_Contact_Employee_employee_id",
                        column: x => x.employee_id,
                        principalTable: "Employee",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEvent",
                columns: table => new
                {
                    EE_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    event_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEvent", x => x.EE_id);
                    table.ForeignKey(
                        name: "FK_EmployeeEvent_Employee_employee_id",
                        column: x => x.employee_id,
                        principalTable: "Employee",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeEvent_Event_event_id",
                        column: x => x.event_id,
                        principalTable: "Event",
                        principalColumn: "event_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bell_employee_id",
                table: "Bell",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_employee_id",
                table: "Contact",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_department_id",
                table: "Employee",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEvent_employee_id",
                table: "EmployeeEvent",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEvent_event_id",
                table: "EmployeeEvent",
                column: "event_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Bell");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "EmployeeEvent");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
