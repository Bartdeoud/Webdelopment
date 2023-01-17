using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations
{
    public partial class Migrations_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bands",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Omschrijving = table.Column<string>(type: "TEXT", nullable: false),
                    Afbeelding = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "leden",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BandId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reserveringen",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VerhuurdeId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserveringen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ruimtes",
                columns: table => new
                {
                    RuimteNr = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Capaciteit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ruimtes", x => x.RuimteNr);
                });

            migrationBuilder.CreateTable(
                name: "shows",
                columns: table => new
                {
                    Shownr = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Afbeelding = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Leeftijdsgroep = table.Column<string>(type: "TEXT", nullable: false),
                    BeginTijd = table.Column<int>(type: "INTEGER", nullable: false),
                    EindTijd = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shows", x => x.Shownr);
                });

            migrationBuilder.CreateTable(
                name: "zalen",
                columns: table => new
                {
                    Zaalnr = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: false),
                    Aantal_stoelen = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zalen", x => x.Zaalnr);
                });

            migrationBuilder.CreateTable(
                name: "gebruikers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Wachtwoord = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    artiest_naam = table.Column<string>(type: "TEXT", nullable: true),
                    LedenId = table.Column<string>(type: "TEXT", nullable: true),
                    TotaleDonatie = table.Column<int>(type: "INTEGER", nullable: true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    stoelNr = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Wachtwoord = table.Column<string>(type: "TEXT", nullable: false),
                    GebruikerUserID = table.Column<int>(type: "INTEGER", nullable: true),
                    Id = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
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
                columns: new[] { "UserID", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Id", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { 1, 0, "cc6bdd53-5f06-4dd6-ba68-4d040f36c635", "Gebruiker", "test1@email.com", false, "b4f4d66e-6c3c-4d45-a10e-29115d9e56c0", false, null, "Jan1", null, null, null, null, false, "160de5bd-1b95-46bf-843e-77198a93c053", false, null, "Test1" });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Id", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { 2, 0, "de869b06-1797-44c6-aed8-18a6f465a747", "Gebruiker", "test2@email.com", false, "28da8461-1a24-4242-a383-aa94de4d0908", false, null, "Jan2", null, null, null, null, false, "25d65ad3-41df-4ad0-9b66-c84d93047b85", false, null, "Test2" });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Id", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { 3, 0, "382f5e2a-2a16-41db-9496-f814430e002f", "Gebruiker", "test3@email.com", false, "6db07288-4dd9-49a0-a207-71c7da7b3db1", false, null, "Jan3", null, null, null, null, false, "68d43203-a81f-40eb-b316-48015d9d727b", false, null, "Test3" });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Id", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { 4, 0, "b065dbcd-75c2-4d69-a821-9bd6d9dbf16a", "Gebruiker", "test4@email.com", false, "2173bfc4-29fb-44e6-82ba-08800d4f24cf", false, null, "Jan4", null, null, null, null, false, "7abebdcc-abd3-42fd-b070-fc392f87a32d", false, null, "Test4" });

            migrationBuilder.CreateIndex(
                name: "IX_gebruikers_LedenId",
                table: "gebruikers",
                column: "LedenId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_GebruikerUserID",
                table: "tickets",
                column: "GebruikerUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bands");

            migrationBuilder.DropTable(
                name: "reserveringen");

            migrationBuilder.DropTable(
                name: "ruimtes");

            migrationBuilder.DropTable(
                name: "shows");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "zalen");

            migrationBuilder.DropTable(
                name: "gebruikers");

            migrationBuilder.DropTable(
                name: "leden");
        }
    }
}
