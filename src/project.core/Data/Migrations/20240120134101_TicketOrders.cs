using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace project.core.Migrations
{
    /// <inheritdoc />
    public partial class TicketOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seances_movies_movieid",
                table: "seances");

            migrationBuilder.DropForeignKey(
                name: "FK_seances_rooms_roomid",
                table: "seances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_seances",
                table: "seances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rooms",
                table: "rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                table: "movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

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

            migrationBuilder.RenameTable(
                name: "seances",
                newName: "Seances");

            migrationBuilder.RenameTable(
                name: "rooms",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "movies",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameColumn(
                name: "start",
                table: "Seances",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "roomid",
                table: "Seances",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "movieid",
                table: "Seances",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "id_room",
                table: "Seances",
                newName: "Id_room");

            migrationBuilder.RenameColumn(
                name: "id_movie",
                table: "Seances",
                newName: "Id_movie");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Seances",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_seances_roomid",
                table: "Seances",
                newName: "IX_Seances_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_seances_movieid",
                table: "Seances",
                newName: "IX_Seances_MovieId");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "Rooms",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Movies",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Movies",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Movies",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seances",
                table: "Seances",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TicketOrderIds = table.Column<int[]>(type: "integer[]", nullable: false),
                    SeanceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Seances_SeanceId",
                        column: x => x.SeanceId,
                        principalTable: "Seances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TicketOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TicketId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TicketOrders_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a02edd2-79d1-4934-be12-fc6579b61727", null, "admin", "ADMIN" },
                    { "0e99788d-2665-4877-949b-6506a644237e", null, "member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40f63771-9abc-460b-a758-2de35d7b6af3", 0, "178abaef-a5e9-4ade-b461-b9dba01e55e9", "superadmin@localhost", true, false, null, "SUPERADMIN@LOCALHOST", "SUPERADMIN@LOCALHOST", "AQAAAAIAAYagAAAAEHxCqaRgnxS3zVw9Cq/fpfiDdKyo/6JHLHkPTrNvEmJLINM76c/8EipK0IgXf0Baig==", null, false, "780e3136-9fbc-47c3-b7a5-de289ac00104", false, "superadmin@localhost" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0a02edd2-79d1-4934-be12-fc6579b61727", "40f63771-9abc-460b-a758-2de35d7b6af3" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SeanceId",
                table: "Orders",
                column: "SeanceId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrders_OrderId",
                table: "TicketOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrders_TicketId",
                table: "TicketOrders",
                column: "TicketId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Movies_MovieId",
                table: "Seances");

            migrationBuilder.DropForeignKey(
                name: "FK_Seances_Rooms_RoomId",
                table: "Seances");

            migrationBuilder.DropTable(
                name: "TicketOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seances",
                table: "Seances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e99788d-2665-4877-949b-6506a644237e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a02edd2-79d1-4934-be12-fc6579b61727", "40f63771-9abc-460b-a758-2de35d7b6af3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a02edd2-79d1-4934-be12-fc6579b61727");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40f63771-9abc-460b-a758-2de35d7b6af3");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Seances",
                newName: "seances");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "rooms");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "movies");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "seances",
                newName: "start");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "seances",
                newName: "roomid");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "seances",
                newName: "movieid");

            migrationBuilder.RenameColumn(
                name: "Id_room",
                table: "seances",
                newName: "id_room");

            migrationBuilder.RenameColumn(
                name: "Id_movie",
                table: "seances",
                newName: "id_movie");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "seances",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Seances_RoomId",
                table: "seances",
                newName: "IX_seances_roomid");

            migrationBuilder.RenameIndex(
                name: "IX_Seances_MovieId",
                table: "seances",
                newName: "IX_seances_movieid");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "rooms",
                newName: "capacity");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "rooms",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "movies",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "movies",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "movies",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "movies",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "movies",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_seances",
                table: "seances",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rooms",
                table: "rooms",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                table: "movies",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_seances_movies_movieid",
                table: "seances",
                column: "movieid",
                principalTable: "movies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_seances_rooms_roomid",
                table: "seances",
                column: "roomid",
                principalTable: "rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
