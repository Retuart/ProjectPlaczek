using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class SuperAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "844b5e8a-a148-40cd-ab6c-b589d2e9dc2b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43da5ab7-8857-4e02-a128-4116944ffcf7", "c2d1e1a4-41ae-4df3-9aee-6246898b5121" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43da5ab7-8857-4e02-a128-4116944ffcf7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12e7adef-0441-448e-838b-380a73502234", null, "member", "MEMBER" },
                    { "cd1c19ff-191b-489f-8532-1a5895145a05", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a9983ec3-52b5-4d94-aeef-9d83bff18ea9", 0, "888cbb3e-cab6-48e0-a1f4-76fdd8808eef", "admin@localhost", true, false, null, "ADMIN@LOCALHOST", "SUPERADMIN", "AQAAAAIAAYagAAAAEE2WO8npEdRX4OFXNdHX8Q+lkbi2Ztvuno68a+tBkNsNB89RmcMq8+d6cAdMc76sRQ==", null, false, "cddac0b8-3b7e-4faa-a09c-bd5c1f3d82aa", false, "SuperAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cd1c19ff-191b-489f-8532-1a5895145a05", "a9983ec3-52b5-4d94-aeef-9d83bff18ea9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12e7adef-0441-448e-838b-380a73502234");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd1c19ff-191b-489f-8532-1a5895145a05", "a9983ec3-52b5-4d94-aeef-9d83bff18ea9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd1c19ff-191b-489f-8532-1a5895145a05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9983ec3-52b5-4d94-aeef-9d83bff18ea9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43da5ab7-8857-4e02-a128-4116944ffcf7", null, "admin", "ADMIN" },
                    { "844b5e8a-a148-40cd-ab6c-b589d2e9dc2b", null, "member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43da5ab7-8857-4e02-a128-4116944ffcf7", "c2d1e1a4-41ae-4df3-9aee-6246898b5121" });
        }
    }
}
