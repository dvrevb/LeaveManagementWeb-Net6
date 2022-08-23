using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ChangeHashPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf",
                column: "ConcurrencyStamp",
                value: "d503aa11-0922-4e18-9a3d-998150b3cacb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269",
                column: "ConcurrencyStamp",
                value: "c67d2d31-b821-4e6d-9db3-4b7d29498b63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e1e668d-e79a-477e-a7ce-0dfec94df943", "AQAAAAEAACcQAAAAEFhw92xoGwLX6xxYtp3WeQujZxcZOa1x+lKwHMKzPNP2Iwa2CNG1TUIUI3pg3nKsqw==", "c5a7b2d9-08cb-45a8-a397-129589e98062" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf",
                column: "ConcurrencyStamp",
                value: "2fe4bfce-1ced-4697-ab13-d53953c1f6ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269",
                column: "ConcurrencyStamp",
                value: "43eb5cf8-eebf-4b73-bdc5-28b454838059");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c42fd7d-f411-4c92-9f51-98dd6c5edaf6", "AQAAAAEAACcQAAAAEO3JrzTKyJuG6lpnB+iYaqJwVDSC3I8y7hQEc2HjQreX/fAb6WFh1bWmYKG9Uf+mKg==", "f77b6eec-13ea-4bcc-8fb9-57f58c3bf2a3" });
        }
    }
}
