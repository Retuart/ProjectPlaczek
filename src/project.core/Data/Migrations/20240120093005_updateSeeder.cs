using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class updateSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1756f896-3ad5-40d7-89d0-928fee66a7bb", null, "member", "MEMBER" },
                    { "c7ed2873-1bd2-4774-bead-bc635c32369e", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cedecd70-a335-42d9-ba47-b695972fcc28", 0, "918405e4-0f36-4c69-bc28-678750f10ab0", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAENlhnYmOoy8x955tYWsf2T0yhoK/wD5G3UmegfQaxbBsAURI1iotWcg0Wf64smbFNA==", null, false, "ade7856a-2d98-458d-bc9a-0d9d40d09560", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7ed2873-1bd2-4774-bead-bc635c32369e", "cedecd70-a335-42d9-ba47-b695972fcc28" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1756f896-3ad5-40d7-89d0-928fee66a7bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7ed2873-1bd2-4774-bead-bc635c32369e", "cedecd70-a335-42d9-ba47-b695972fcc28" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ed2873-1bd2-4774-bead-bc635c32369e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cedecd70-a335-42d9-ba47-b695972fcc28");

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
    }
}
