using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class migrationhahaikbeneenmigratie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stoelrij",
                columns: table => new
                {
                    rijid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rangnummer = table.Column<int>(type: "int", nullable: false),
                    Aantalstoelen = table.Column<int>(name: "Aantal_stoelen", type: "int", nullable: false),
                    Zaalnr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoelrij", x => x.rijid);
                });

            migrationBuilder.InsertData(
                table: "Stoelrij",
                columns: new[] { "rijid", "Aantal_stoelen", "Rangnummer", "Zaalnr" },
                values: new object[,]
                {
                    { 11, 20, 1, 1 },
                    { 12, 100, 2, 1 },
                    { 13, 120, 3, 1 },
                    { 21, 2, 1, 2 },
                    { 22, 160, 2, 2 },
                    { 31, 10, 1, 3 },
                    { 32, 80, 2, 3 },
                    { 41, 40, 1, 4 },
                    { 42, 200, 2, 4 },
                    { 43, 200, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "Naam", "Username", "Wachtwoord" },
                values: new object[,]
                {
                    { 5, "Gebruiker", "artiestmail1@email.com", "Artiest1", "Artiest1", "Test1" },
                    { 6, "Gebruiker", "artiestmail2@email.com", "Artiest2", "Artiest2", "Test2" },
                    { 7, "Gebruiker", "artiestmail3@email.com", "Artiest3", "Artiest3", "Test3" },
                    { 8, "Gebruiker", "artiestmail4@email.com", "Artiest4", "Artiest4", "Test4" },
                    { 9, "Gebruiker", "artiestmail5@email.com", "Artiest5", "Artiest5", "Test5" }
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
                table: "zalen",
                columns: new[] { "Zaalnr", "Aantal_stoelen", "Naam" },
                values: new object[,]
                {
                    { 1, 240, "Zaal 1" },
                    { 2, 180, "Zaal 2" },
                    { 3, 90, "Zaal 3" },
                    { 4, 440, "Zaal 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stoelrij");

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ruimtes",
                keyColumn: "RuimteNr",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 4);
        }
    }
}
