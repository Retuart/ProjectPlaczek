using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class temp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48606d03-6fe8-4de2-bd2a-58dbb21538b8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c36483ff-1849-404a-949e-8e70b086262b", "3aba7f73-cd78-4a3f-8a9a-53b24c3a63d3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c36483ff-1849-404a-949e-8e70b086262b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aba7f73-cd78-4a3f-8a9a-53b24c3a63d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cc04e7f1-e1ca-47ff-85ab-9999398e7855", null, "member", "MEMBER" },
                    { "ebb126cd-6245-4387-8464-ef19cbf5e6c3", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb08947-ad81-4e63-943b-84d5187787e5", 0, "2633f53e-fc66-4e91-bda9-94f51a7acffc", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEKM1sH0EoNtYS08Uj9KIIKEG56jJ2U8mlN7iKTA6GQOGDYR1/0DNCzBVmZetmLKXig==", null, false, "90fb3a3f-7819-466d-b2ca-b572dfc449bf", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ebb126cd-6245-4387-8464-ef19cbf5e6c3", "bcb08947-ad81-4e63-943b-84d5187787e5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc04e7f1-e1ca-47ff-85ab-9999398e7855");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebb126cd-6245-4387-8464-ef19cbf5e6c3", "bcb08947-ad81-4e63-943b-84d5187787e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebb126cd-6245-4387-8464-ef19cbf5e6c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb08947-ad81-4e63-943b-84d5187787e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48606d03-6fe8-4de2-bd2a-58dbb21538b8", null, "member", "MEMBER" },
                    { "c36483ff-1849-404a-949e-8e70b086262b", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3aba7f73-cd78-4a3f-8a9a-53b24c3a63d3", 0, "ed77fb57-f1ca-4c28-ba74-9234b8c42672", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEFPhJU0u6yOsfm79QFRyM8HmbAWxtf05hp+1LQ/TSkExQ8gyr0XW/eh8J5dziq2/cQ==", null, false, "7941b14f-0b56-4004-b490-167114514d89", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c36483ff-1849-404a-949e-8e70b086262b", "3aba7f73-cd78-4a3f-8a9a-53b24c3a63d3" });
        }
    }
}
