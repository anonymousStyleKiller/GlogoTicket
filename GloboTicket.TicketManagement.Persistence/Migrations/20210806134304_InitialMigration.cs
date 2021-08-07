using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GloboTicket.TicketManagement.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false),
                    OrderTotal = table.Column<int>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false),
                    OrderPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Artist = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("8c75c1d9-9cb2-471d-b070-dfe51e64bfef"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Concerts" },
                    { new Guid("265fc0e1-a6e0-4e8c-a7a0-69a40d90397e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Musicals" },
                    { new Guid("fea0cc6f-18fe-47a8-a1d1-9d7a879861ec"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Plays" },
                    { new Guid("baf50fd4-7e94-474a-96c9-754ab1399c79"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Conferences" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "OrderPaid", "OrderPlaced", "OrderTotal", "UserId" },
                values: new object[,]
                {
                    { new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 8, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(6545), 400, new Guid("a441eb40-9636-4ee6-be49-a66c5ec1330b") },
                    { new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 8, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(7346), 135, new Guid("ac3cfaf5-34fd-4e4d-bc04-ad1083ddc340") },
                    { new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true, new DateTime(2021, 8, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(7375), 85, new Guid("d97a15fc-0d32-41c6-9ddf-62f0735c4c1c") }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "CreatedBy", "CreatedDate", "Date", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "Price" },
                values: new object[] { new Guid("0278b527-42cf-49a8-aca3-98143880aec7"), "Моргенштерн", new Guid("8c75c1d9-9cb2-471d-b070-dfe51e64bfef"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 16, 43, 4, 349, DateTimeKind.Local).AddTicks(3895), "Моргенште́рн (настоящее имя — Алише́р Таги́рович Моргенште́рн, урожд. — Вале́ев[комм 2]; род. 17 февраля 1998, Уфа) — российский рэп-исполнитель и музыкант. Ранее вёл активную видеоблогерскую деятельность на видеохостинге YouTube.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Morgenshtern_%283%29_%D0%BD%D0%B0_%D0%92%D0%B8%D0%B4%D1%84%D0%B5%D1%81%D1%82_2018_%D0%B2_%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5_%28cropped%29.jpg/274px-Morgenshtern_%283%29_%D0%BD%D0%B0_%D0%92%D0%B8%D0%B4%D1%84%D0%B5%D1%81%D1%82_2018_%D0%B2_%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5_%28cropped%29.jpg", null, null, "Алише́р Таги́рович Моргенште́рн", 80 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "CreatedBy", "CreatedDate", "Date", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "Price" },
                values: new object[] { new Guid("0278b527-42cf-49a8-aca3-98143880aec3"), "Скриптонит", new Guid("265fc0e1-a6e0-4e8c-a7a0-69a40d90397e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(5071), "Скриптони́т (англ. Scriptonite) — казахстанский исполнитель и музыкальный продюсер, основатель лейбла Musica36[10].", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Scriptonite.jpg/300px-Scriptonite.jpg", null, null, "Ади́ль Оралбе́кович Жале́лов", 65 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Artist", "CategoryId", "CreatedBy", "CreatedDate", "Date", "Description", "ImageUrl", "LastModifiedBy", "LastModifiedDate", "Name", "Price" },
                values: new object[] { new Guid("0278b527-42cf-49a8-aca3-98143880aec4"), "Oxxxymiron", new Guid("fea0cc6f-18fe-47a8-a1d1-9d7a879861ec"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 16, 43, 4, 350, DateTimeKind.Local).AddTicks(5119), "Oxxxymiron (Оксимиро́н; настоящее имя — Миро́н Я́нович Фёдоров (англ. Miron Yanovich Fyodorov); род. 31 января 1985 года, Ленинград, РСФСР, СССР) — российский хип-хоп-исполнитель и бывший исполнительный директор букинг-агентства Booking Machine", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Oxxxymiron._Reebok.png/250px-Oxxxymiron._Reebok.png", null, null, "Миро́н Я́нович Фёдоров", 70 });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
