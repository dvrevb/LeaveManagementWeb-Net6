using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "292e0d87-1298-47d0-9491-fab5b628eadf", "2fe4bfce-1ced-4697-ab13-d53953c1f6ec", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e8cfe9d-7008-433e-aba5-df3dadcaa269", "43eb5cf8-eebf-4b73-bdc5-28b454838059", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a90b4249-2190-43bb-81bd-cf99453e80ad", 0, "4c42fd7d-f411-4c92-9f51-98dd6c5edaf6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEO3JrzTKyJuG6lpnB+iYaqJwVDSC3I8y7hQEc2HjQreX/fAb6WFh1bWmYKG9Uf+mKg==", null, false, "f77b6eec-13ea-4bcc-8fb9-57f58c3bf2a3", null, false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8e8cfe9d-7008-433e-aba5-df3dadcaa269", "a90b4249-2190-43bb-81bd-cf99453e80ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292e0d87-1298-47d0-9491-fab5b628eadf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e8cfe9d-7008-433e-aba5-df3dadcaa269", "a90b4249-2190-43bb-81bd-cf99453e80ad" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e8cfe9d-7008-433e-aba5-df3dadcaa269");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a90b4249-2190-43bb-81bd-cf99453e80ad");
        }
    }
}
