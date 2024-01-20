using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class TicketModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "end",
                table: "seances");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15882aa6-0c25-4a81-bd43-646767e7c6b1", null, "member", "MEMBER" },
                    { "7941513e-2558-44e3-b1d0-373265ed4fce", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "823414fc-e4aa-4caf-9b62-b06fd4c0f9ef", 0, "bcc7ab04-2da3-4817-8f2f-afb3eb834854", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEGHKri3+nCBwG8xv3s8HrLPcmDVOJ0bBn5x8cSg+/gyRydbbkGiM/OhI3rU5DT84wA==", null, false, "0d8fd117-f2c5-4564-9981-b38180bc530c", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7941513e-2558-44e3-b1d0-373265ed4fce", "823414fc-e4aa-4caf-9b62-b06fd4c0f9ef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15882aa6-0c25-4a81-bd43-646767e7c6b1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7941513e-2558-44e3-b1d0-373265ed4fce", "823414fc-e4aa-4caf-9b62-b06fd4c0f9ef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7941513e-2558-44e3-b1d0-373265ed4fce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "823414fc-e4aa-4caf-9b62-b06fd4c0f9ef");

            migrationBuilder.AddColumn<DateTime>(
                name: "end",
                table: "seances",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
