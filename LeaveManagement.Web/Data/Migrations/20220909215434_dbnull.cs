using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class dbnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf",
                column: "ConcurrencyStamp",
                value: "c8ee67e7-f742-4c9f-a553-6389fea953b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269",
                column: "ConcurrencyStamp",
                value: "a905d4d7-ada7-43a9-98cd-7526c3804674");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cefa1944-2ef0-4484-af12-9b55623a0bac", "AQAAAAEAACcQAAAAENVfBkEziM+a54yh3ZW6Xz3UTiXBjb3lXprKDJeVcr7rLEvg5Xhed+psJUqkMQR1lw==", "64081d67-b780-4487-9e90-bf379fb7cc4e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
