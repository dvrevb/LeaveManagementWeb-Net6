using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class leaverequestadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf",
                column: "ConcurrencyStamp",
                value: "c2e3f45e-3cc3-42ad-9186-ceab68b28bcf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269",
                column: "ConcurrencyStamp",
                value: "472920e3-4535-4f0b-890d-c83902c6de02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731ba6ac-347a-419c-b88f-1a0a3f750159", "AQAAAAEAACcQAAAAEPkMo0sedn+/PR2mL5wICLSQoGqNqUdnsUMmpccgO7qfdLriv6tHvv/LNudF+oHpsg==", "02fa7b0c-0078-4be2-b1d1-5426eba635ca" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf",
                column: "ConcurrencyStamp",
                value: "a657b0de-b49a-4b22-b3f7-0d72d3f4efeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269",
                column: "ConcurrencyStamp",
                value: "28ca2470-93a1-4b7a-b044-4b3e6fea47f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38577a93-adb0-40b0-a73f-f5df99b4cf47", "AQAAAAEAACcQAAAAEDHue8SzBt4JnRE+YrwFrgG35A4AbXJT/Mg3IkOCu3XYTLY0fg21I1U0HWw483e/Tg==", "cc53475f-091b-4814-b23b-0513477e74bc" });
        }
    }
}
