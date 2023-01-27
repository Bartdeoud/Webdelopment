using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bands",
                columns: table => new
                {
                    IdBand = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bands", x => x.IdBand);
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "leden",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BandId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "leeftijdsgroepen",
                columns: table => new
                {
                    LeeftijdsgroepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leeftijdsgroepen", x => x.LeeftijdsgroepID);
                });

            migrationBuilder.CreateTable(
                name: "reserveringen",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerhuurdeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zaalnr = table.Column<int>(type: "int", nullable: true),
                    RuimteNr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserveringen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ruimtes",
                columns: table => new
                {
                    RuimteNr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capaciteit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ruimtes", x => x.RuimteNr);
                });

            migrationBuilder.CreateTable(
                name: "sessionIds",
                columns: table => new
                {
                    Session = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessionIds", x => x.Session);
                });

            migrationBuilder.CreateTable(
                name: "shows",
                columns: table => new
                {
                    Shownr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeginTijd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EindTijd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Zaal = table.Column<int>(type: "int", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: true),
                    Leeftijdsgroep = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shows", x => x.Shownr);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stoelNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shownr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.TicketID);
                });

            migrationBuilder.CreateTable(
                name: "zalen",
                columns: table => new
                {
                    Zaalnr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rang1 = table.Column<int>(type: "int", nullable: false),
                    Rang2 = table.Column<int>(type: "int", nullable: true),
                    Rang3 = table.Column<int>(type: "int", nullable: true),
                    Rang4 = table.Column<int>(type: "int", nullable: true),
                    invalideplaatsen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zalen", x => x.Zaalnr);
                });

            migrationBuilder.CreateTable(
                name: "gebruikers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artiestnaam = table.Column<string>(name: "artiest_naam", type: "nvarchar(max)", nullable: true),
                    LedenId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotaleDonatie = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gebruikers", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_gebruikers_leden_LedenId",
                        column: x => x.LedenId,
                        principalTable: "leden",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "Naam", "TotaleDonatie", "Username", "Wachtwoord" },
                values: new object[] { 1, "Donateur", "test1@email.com", "Jan1", 1000, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "Naam", "Username", "Wachtwoord" },
                values: new object[,]
                {
                    { 2, "Gebruiker", "test2@email.com", "Jan2", "Jan2", "Test2" },
                    { 3, "Gebruiker", "test3@email.com", "Jan3", "Jan3", "Test3" },
                    { 4, "Gebruiker", "test4@email.com", "Jan4", "Jan4", "Test4" }
                });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "LedenId", "Naam", "Username", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { 5, "Artiest", "artiestmail1@email.com", null, "Artiest1", "Artiest1", "Test1", "Artiest1" },
                    { 6, "Artiest", "artiestmail2@email.com", null, "Artiest2", "Artiest2", "Test2", "Artiest2" },
                    { 7, "Artiest", "artiestmail3@email.com", null, "Artiest3", "Artiest3", "Test3", "Artiest3" },
                    { 8, "Artiest", "artiestmail4@email.com", null, "Artiest4", "Artiest4", "Test4", "Artiest4" },
                    { 9, "Artiest", "artiestmail5@email.com", null, "Artiest5", "Artiest5", "Test5", "Artiest5" }
                });

            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "GenreID", "Naam" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Comedy" },
                    { 3, "Drama" },
                    { 4, "Action" },
                    { 5, "Romance" },
                    { 6, "Adventure" },
                    { 7, "Mystery" },
                    { 8, "Family" },
                    { 9, "Music" },
                    { 10, "History" },
                    { 11, "War" },
                    { 12, "Western" },
                    { 13, "Sport" }
                });

            migrationBuilder.InsertData(
                table: "leeftijdsgroepen",
                columns: new[] { "LeeftijdsgroepID", "Naam" },
                values: new object[,]
                {
                    { 1, "Alle leeftijden" },
                    { 2, "Onder de 18" },
                    { 3, "18-65" },
                    { 4, "65+" }
                });

            migrationBuilder.InsertData(
                table: "ruimtes",
                columns: new[] { "RuimteNr", "Capaciteit", "Naam" },
                values: new object[,]
                {
                    { 1, 30, "Ruimte 1" },
                    { 2, 30, "Ruimte 2" },
                    { 3, 30, "Ruimte 3" },
                    { 4, 30, "Ruimte 4" },
                    { 5, 30, "Ruimte 5" },
                    { 6, 30, "Ruimte 6" },
                    { 7, 30, "Ruimte 7" },
                    { 8, 30, "Ruimte 8" },
                    { 9, 30, "Ruimte 9" },
                    { 10, 30, "Ruimte 10" }
                });

            migrationBuilder.InsertData(
                table: "shows",
                columns: new[] { "Shownr", "Afbeelding", "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep", "Naam", "Zaal" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8461), 1, 1, "Show 1", 1 },
                    { 2, "", new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8463), new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8465), 2, 2, "Show 2", 2 },
                    { 3, "", new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8467), new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8469), 3, 3, "Show 3", 3 }
                });

            migrationBuilder.InsertData(
                table: "zalen",
                columns: new[] { "Zaalnr", "Naam", "Rang1", "Rang2", "Rang3", "Rang4", "invalideplaatsen" },
                values: new object[,]
                {
                    { 1, "Zaal 1", 120, 98, 20, null, 2 },
                    { 2, "Zaal 2", 100, 80, null, null, null },
                    { 3, "Zaal 3", 30, 30, 20, 10, null },
                    { 4, "Zaal 4", 210, 115, 90, 20, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_gebruikers_LedenId",
                table: "gebruikers",
                column: "LedenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bands");

            migrationBuilder.DropTable(
                name: "gebruikers");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "leeftijdsgroepen");

            migrationBuilder.DropTable(
                name: "reserveringen");

            migrationBuilder.DropTable(
                name: "ruimtes");

            migrationBuilder.DropTable(
                name: "sessionIds");

            migrationBuilder.DropTable(
                name: "shows");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "zalen");

            migrationBuilder.DropTable(
                name: "leden");
        }
    }
}
