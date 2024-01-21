using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketOrders_Orders_OrderId",
                table: "TicketOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketOrders_Tickets_TicketId",
                table: "TicketOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketOrders",
                table: "TicketOrders");

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

            migrationBuilder.RenameTable(
                name: "TicketOrders",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_TicketOrders_TicketId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketOrders_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Tickets_TicketId",
                table: "OrderDetails",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Tickets_TicketId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

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

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "TicketOrders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_TicketId",
                table: "TicketOrders",
                newName: "IX_TicketOrders_TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "TicketOrders",
                newName: "IX_TicketOrders_OrderId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketOrders",
                table: "TicketOrders",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOrders_Tickets_TicketId",
                table: "TicketOrders",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
