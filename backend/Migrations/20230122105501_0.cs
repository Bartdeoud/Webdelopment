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
                name: "reserveringen",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerhuurdeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "shows",
                columns: table => new
                {
                    Shownr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leeftijdsgroep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeginTijd = table.Column<int>(type: "int", nullable: false),
                    EindTijd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shows", x => x.Shownr);
                });

            migrationBuilder.CreateTable(
                name: "zalen",
                columns: table => new
                {
                    Zaalnr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aantalstoelen = table.Column<int>(name: "Aantal_stoelen", type: "int", nullable: false)
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
                    Shownr = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_gebruikers_shows_Shownr",
                        column: x => x.Shownr,
                        principalTable: "shows",
                        principalColumn: "Shownr");
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stoelNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GebruikerUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_tickets_gebruikers_GebruikerUserID",
                        column: x => x.GebruikerUserID,
                        principalTable: "gebruikers",
                        principalColumn: "UserID");
                });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "Naam", "Username", "Wachtwoord" },
                values: new object[,]
                {
                    { 1, "Gebruiker", "test1@email.com", "Jan1", "Jan1", "Test1" },
                    { 2, "Gebruiker", "test2@email.com", "Jan2", "Jan2", "Test2" },
                    { 3, "Gebruiker", "test3@email.com", "Jan3", "Jan3", "Test3" },
                    { 4, "Gebruiker", "test4@email.com", "Jan4", "Jan4", "Test4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_gebruikers_LedenId",
                table: "gebruikers",
                column: "LedenId");

            migrationBuilder.CreateIndex(
                name: "IX_gebruikers_Shownr",
                table: "gebruikers",
                column: "Shownr");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_GebruikerUserID",
                table: "tickets",
                column: "GebruikerUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bands");

            migrationBuilder.DropTable(
                name: "reserveringen");

            migrationBuilder.DropTable(
                name: "ruimtes");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "zalen");

            migrationBuilder.DropTable(
                name: "gebruikers");

            migrationBuilder.DropTable(
                name: "leden");

            migrationBuilder.DropTable(
                name: "shows");
        }
    }
}
