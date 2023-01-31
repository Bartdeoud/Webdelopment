using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bands",
                columns: table => new
                {
                    IdBand = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Afbeelding = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerhuurdeId = table.Column<int>(type: "int", nullable: false),
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
                    expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ticketData = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    stoelNr = table.Column<int>(type: "int", nullable: false),
                    Rang = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artiestnaam = table.Column<string>(name: "artiest_naam", type: "nvarchar(max)", nullable: true),
                    LedenId = table.Column<int>(type: "int", nullable: true),
                    TotaleDonatie = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_leden_LedenId",
                        column: x => x.LedenId,
                        principalTable: "leden",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "159ba6d4-7286-4cf8-a79d-f93ba2d33f45", 0, "de68ba32-423b-44af-84ef-1f6bba414565", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "9773bb5d-9ae1-4b03-8722-4e8a4872865b", false, "Artiest4", "Test4", "Artiest4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "527037d3-93cc-41ef-8e53-079e587d4f90", 0, "6fd1858c-5f7f-4bee-8a45-257bb8243497", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "138fde59-a095-48be-b568-2b2fcdbc6957", 1000, false, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[,]
                {
                    { "544e2630-3e0e-453a-8778-45731f4fe324", 0, "20306d7f-f600-40cb-a1b7-0320d9624030", "Gebruiker", "test2@email.com", false, false, null, null, null, null, null, false, "d89b8c85-b3a4-47f1-86b5-54774119ab95", false, "Jan2", "Test2" },
                    { "79531cf1-99f1-4c31-925a-17248ad77393", 0, "2c2c7fc8-ea36-4499-8566-d857f512d527", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "607c1eb8-77c4-4818-95ef-2fd85c630148", false, "Jan4", "Test4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "8fdaf54c-90bc-43d7-874e-45cb9a70ed53", 0, "0da18a50-3f7a-4c61-82e5-7544fa92cc82", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "e6dc03b3-99eb-4661-8fe0-f8855e1a41bb", false, "Artiest2", "Test2", "Artiest2" },
                    { "917caade-565e-4105-9272-c2cfadb2b53d", 0, "ca5fe9f6-e3fb-49a3-b362-e7e7c210826e", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "93fcfa16-c141-4279-8d17-977687f19bb4", false, "Artiest1", "Test1", "Artiest1" },
                    { "9e91501e-ad72-4334-8820-da52d3280b4c", 0, "bc4bda97-31d2-4dd3-8afc-579182224616", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "6cac4571-ac00-40c6-b3b0-c2613c207c2d", false, "Artiest5", "Test5", "Artiest5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "b86c8b73-b2af-4bfd-acfa-0365e3d8b2b0", 0, "1e4b85fc-3b94-4764-a380-51cf620d497a", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "be5c8194-720a-4334-8dae-5db64acf68cc", false, "Jan3", "Test3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "eb5b10de-edc7-469c-abca-f7a5c5c7738d", 0, "47140611-b589-48e0-8df2-46aee2e1f432", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "f8b5a574-822e-4a49-8a32-adb75b63245e", false, "Artiest3", "Test3", "Artiest3" });

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
                    { 1, "", new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3352), 1, 1, "Show 1", 1 },
                    { 2, "", new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3357), 2, 2, "Show 2", 2 },
                    { 3, "", new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3360), new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3362), 3, 3, "Show 3", 3 }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LedenId",
                table: "AspNetUsers",
                column: "LedenId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bands");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "leden");
        }
    }
}
