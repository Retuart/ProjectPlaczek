using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Seances_SeanceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketOrders_Orders_OrderId",
                table: "TicketOrders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f84409c-0aea-4de7-ab27-4ad5983ab622");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "284636bc-0a1a-4911-8544-2b09d28dbbb3", "e7c49414-64d7-47f9-ba9d-efd6a944830b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "284636bc-0a1a-4911-8544-2b09d28dbbb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7c49414-64d7-47f9-ba9d-efd6a944830b");

            migrationBuilder.DropColumn(
                name: "TicketOrderIds",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "TicketOrders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Seances",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Seances",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int[]>(
                name: "OrdersIds",
                table: "Seances",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeanceId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int[]>(
                name: "OrderDetailsIds",
                table: "Orders",
                type: "integer[]",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Seances_SeanceId",
                table: "Orders",
                column: "SeanceId",
                principalTable: "Seances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOrders_Orders_OrderId",
                table: "TicketOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Seances_SeanceId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketOrders_Orders_OrderId",
                table: "TicketOrders");

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

            migrationBuilder.DropColumn(
                name: "OrdersIds",
                table: "Seances");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDetailsIds",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "TicketOrders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Seances",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Seances",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "SeanceId",
                table: "Orders",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int[]>(
                name: "TicketOrderIds",
                table: "Orders",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "284636bc-0a1a-4911-8544-2b09d28dbbb3", null, "admin", "ADMIN" },
                    { "3f84409c-0aea-4de7-ab27-4ad5983ab622", null, "member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e7c49414-64d7-47f9-ba9d-efd6a944830b", 0, "e70b0496-66b3-4d3a-9054-fbc38901e10f", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEOWlwksjC8XYyuz02JNfJqdNC/XDKLKs9QZdH00iFMTxWImeUyojh0CQXYLsH83X2Q==", null, false, "b13cb3f9-2c77-41ed-a4ae-586543d9cf11", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "284636bc-0a1a-4911-8544-2b09d28dbbb3", "e7c49414-64d7-47f9-ba9d-efd6a944830b" });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Seances_SeanceId",
                table: "Orders",
                column: "SeanceId",
                principalTable: "Seances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOrders_Orders_OrderId",
                table: "TicketOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
