using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Migrations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stoelrij",
                table: "Stoelrij");

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 1);

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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "Wachtwoord",
                table: "tickets");

            migrationBuilder.RenameTable(
                name: "Stoelrij",
                newName: "stoelrijen");

            migrationBuilder.AlterColumn<string>(
                name: "zaal",
                table: "shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Leeftijdsgroep",
                table: "shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Afbeelding",
                table: "shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stoelrijen",
                table: "stoelrijen",
                column: "rijid");

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "Naam", "TotaleDonatie", "Username", "Wachtwoord" },
                values: new object[] { 1, "Donateur", "test1@email.com", "Jan1", 1000, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "LedenId", "Naam", "Shownr", "Username", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { 5, "Artiest", "artiestmail1@email.com", null, "Artiest1", null, "Artiest1", "Test1", "Artiest1" },
                    { 6, "Artiest", "artiestmail2@email.com", null, "Artiest2", null, "Artiest2", "Test2", "Artiest2" },
                    { 7, "Artiest", "artiestmail3@email.com", null, "Artiest3", null, "Artiest3", "Test3", "Artiest3" },
                    { 8, "Artiest", "artiestmail4@email.com", null, "Artiest4", null, "Artiest4", "Test4", "Artiest4" },
                    { 9, "Artiest", "artiestmail5@email.com", null, "Artiest5", null, "Artiest5", "Test5", "Artiest5" }
                });

            migrationBuilder.InsertData(
                table: "shows",
                columns: new[] { "Shownr", "Afbeelding", "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep", "Naam", "zaal" },
                values: new object[,]
                {
                    { 1, "", 2, 3, "Horor", "18", "Show 1", "zaal 1" },
                    { 2, "", 3, 4, "Horor", "18", "Show 2", "zaal 2" },
                    { 3, "", 5, 6, "Horor", "18", "Show 3", "zaal 3" }
                });

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 11,
                column: "Aantal_stoelen",
                value: 20);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 12,
                column: "Aantal_stoelen",
                value: 100);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 13,
                column: "Aantal_stoelen",
                value: 120);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 21,
                column: "Aantal_stoelen",
                value: 2);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 22,
                column: "Aantal_stoelen",
                value: 160);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 31,
                column: "Aantal_stoelen",
                value: 10);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 32,
                column: "Aantal_stoelen",
                value: 80);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 41,
                column: "Aantal_stoelen",
                value: 40);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 42,
                column: "Aantal_stoelen",
                value: 200);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 43,
                column: "Aantal_stoelen",
                value: 200);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 1,
                column: "Aantal_stoelen",
                value: 240);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 2,
                column: "Aantal_stoelen",
                value: 180);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 3,
                column: "Aantal_stoelen",
                value: 90);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 4,
                column: "Aantal_stoelen",
                value: 440);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_stoelrijen",
                table: "stoelrijen");

            migrationBuilder.DeleteData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 1);

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
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "stoelrijen",
                newName: "Stoelrij");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Wachtwoord",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "zaal",
                table: "shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Leeftijdsgroep",
                table: "shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Afbeelding",
                table: "shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stoelrij",
                table: "Stoelrij",
                column: "rijid");

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 11,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 12,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 13,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 21,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 22,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 31,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 32,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 41,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 42,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Stoelrij",
                keyColumn: "rijid",
                keyValue: 43,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.InsertData(
                table: "gebruikers",
                columns: new[] { "UserID", "Discriminator", "Email", "Naam", "Username", "Wachtwoord" },
                values: new object[,]
                {
                    { 1, "Gebruiker", "test1@email.com", "Jan1", "Jan1", "Test1" },
                    { 5, "Gebruiker", "artiestmail1@email.com", "Artiest1", "Artiest1", "Test1" },
                    { 6, "Gebruiker", "artiestmail2@email.com", "Artiest2", "Artiest2", "Test2" },
                    { 7, "Gebruiker", "artiestmail3@email.com", "Artiest3", "Artiest3", "Test3" },
                    { 8, "Gebruiker", "artiestmail4@email.com", "Artiest4", "Artiest4", "Test4" },
                    { 9, "Gebruiker", "artiestmail5@email.com", "Artiest5", "Artiest5", "Test5" }
                });

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 1,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 2,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 3,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 4,
                column: "Aantal_stoelen",
                value: 0);
        }
    }
}
