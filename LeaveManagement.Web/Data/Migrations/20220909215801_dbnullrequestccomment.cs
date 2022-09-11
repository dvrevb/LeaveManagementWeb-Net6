using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class dbnullrequestccomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf",
                column: "ConcurrencyStamp",
                value: "86bfd92b-9289-4db1-a2b8-8a1889f3875b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269",
                column: "ConcurrencyStamp",
                value: "931dc7bb-1ed7-4778-b189-6e50311b177f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f93d3938-5ac0-4ea4-8e33-e1aa18839abe", "AQAAAAEAACcQAAAAEL4iKaPZhbCn4/e1mK+x1qFlQcriNrSWnUPOIO6Pmx1H3hZJmVDkceD3a6GfjWV4Jg==", "73c6b519-0316-4d37-9eaa-53dee8a6b1a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
