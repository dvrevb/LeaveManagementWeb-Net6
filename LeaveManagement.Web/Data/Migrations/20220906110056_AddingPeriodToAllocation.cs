using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "28ca2470-93a1-4b7a-b044-4b3e6fea47f9", "ADMİNİSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38577a93-adb0-40b0-a73f-f5df99b4cf47", "AQAAAAEAACcQAAAAEDHue8SzBt4JnRE+YrwFrgG35A4AbXJT/Mg3IkOCu3XYTLY0fg21I1U0HWw483e/Tg==", "cc53475f-091b-4814-b23b-0513477e74bc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c67d2d31-b821-4e6d-9db3-4b7d29498b63", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e1e668d-e79a-477e-a7ce-0dfec94df943", "AQAAAAEAACcQAAAAEFhw92xoGwLX6xxYtp3WeQujZxcZOa1x+lKwHMKzPNP2Iwa2CNG1TUIUI3pg3nKsqw==", "c5a7b2d9-08cb-45a8-a397-129589e98062" });
        }
    }
}
