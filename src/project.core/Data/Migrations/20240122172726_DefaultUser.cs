using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class DefaultUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6b473aa-9ab7-4d43-9ef9-286bb0b22c64");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ffbd84c0-b5c6-4249-bb4e-c324cad1bc32", "3f7209d0-a4e0-4467-9cc0-7b9bcedf9582" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffbd84c0-b5c6-4249-bb4e-c324cad1bc32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f7209d0-a4e0-4467-9cc0-7b9bcedf9582");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79e2a27c-35d9-4654-b3a3-5434ee75fccf", null, "Admin", "ADMIN" },
                    { "9d320530-5afe-4a2d-b387-be331eabc6b8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ca41e1d-6398-40a5-85f2-ddaf65154c00", 0, "bf7291aa-c051-48ea-bf4d-99c4f6ffde36", "user@localhost", true, false, null, "USER@LOCALHOST", "USER@LOCALHOST", "AQAAAAIAAYagAAAAENL2QFHZO552NNaaS6EEnGdStZ/kr5HJKwrQJbi4YTIf4mUKVbzd8dqdZ/uRwatm9Q==", null, false, "8c90a04f-186a-4b00-be4f-1530caba1781", false, "user@localhost" },
                    { "d112403b-e53f-4c79-b675-121e70839a26", 0, "4a4ec720-df43-42e5-81a6-377729a58705", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEEy3BedO621ZeLQK9ZiPGBwHUxJHrQAkwZ3R7yr0WuBTQnmzQ9QQaqSMl9AknYN4qQ==", null, false, "0dde9e79-58e0-4f2b-a1c6-7eaf7a989472", false, "superadmin@localhost" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9d320530-5afe-4a2d-b387-be331eabc6b8", "3ca41e1d-6398-40a5-85f2-ddaf65154c00" },
                    { "79e2a27c-35d9-4654-b3a3-5434ee75fccf", "d112403b-e53f-4c79-b675-121e70839a26" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d320530-5afe-4a2d-b387-be331eabc6b8", "3ca41e1d-6398-40a5-85f2-ddaf65154c00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79e2a27c-35d9-4654-b3a3-5434ee75fccf", "d112403b-e53f-4c79-b675-121e70839a26" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79e2a27c-35d9-4654-b3a3-5434ee75fccf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d320530-5afe-4a2d-b387-be331eabc6b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ca41e1d-6398-40a5-85f2-ddaf65154c00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d112403b-e53f-4c79-b675-121e70839a26");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a6b473aa-9ab7-4d43-9ef9-286bb0b22c64", null, "member", "MEMBER" },
                    { "ffbd84c0-b5c6-4249-bb4e-c324cad1bc32", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3f7209d0-a4e0-4467-9cc0-7b9bcedf9582", 0, "a4423470-af41-4063-98c0-c61a5e9d2479", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEBwtfWAIvbN5dGN7kd1bnNpKke7Fkq88KOXxnl1xQWLtieXb32r6XdY48Z7OTdFtcQ==", null, false, "8e0be58d-b8bf-4857-8d98-17a684b0c781", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ffbd84c0-b5c6-4249-bb4e-c324cad1bc32", "3f7209d0-a4e0-4467-9cc0-7b9bcedf9582" });
        }
    }
}
