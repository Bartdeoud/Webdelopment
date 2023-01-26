using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stoelrijen");

            migrationBuilder.RenameColumn(
                name: "Aantal_stoelen",
                table: "zalen",
                newName: "Rang1");

            migrationBuilder.AddColumn<int>(
                name: "Rang2",
                table: "zalen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rang3",
                table: "zalen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rang4",
                table: "zalen",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "invalideplaatsen",
                table: "zalen",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Leeftijdsgroep",
                table: "shows",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Genre",
                table: "shows",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "sessionIds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 5,
                column: "artiest_naam",
                value: "Artiest1");

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 6,
                column: "artiest_naam",
                value: "Artiest2");

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 7,
                column: "artiest_naam",
                value: "Artiest3");

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 8,
                column: "artiest_naam",
                value: "Artiest4");

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 9,
                column: "artiest_naam",
                value: "Artiest5");

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

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep" },
                values: new object[] { new DateTime(2023, 1, 26, 19, 0, 50, 166, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 1, 26, 19, 0, 50, 166, DateTimeKind.Local).AddTicks(7110), 2, 3 });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep" },
                values: new object[] { new DateTime(2023, 1, 26, 19, 0, 50, 166, DateTimeKind.Local).AddTicks(7113), new DateTime(2023, 1, 26, 19, 0, 50, 166, DateTimeKind.Local).AddTicks(7114), 2, 3 });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep" },
                values: new object[] { new DateTime(2023, 1, 26, 19, 0, 50, 166, DateTimeKind.Local).AddTicks(7117), new DateTime(2023, 1, 26, 19, 0, 50, 166, DateTimeKind.Local).AddTicks(7118), 2, 3 });

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 1,
                columns: new[] { "Rang1", "Rang2", "Rang3", "Rang4", "invalideplaatsen" },
                values: new object[] { 120, 98, 20, null, 2 });

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 2,
                columns: new[] { "Rang1", "Rang2", "Rang3", "Rang4", "invalideplaatsen" },
                values: new object[] { 100, 80, null, null, null });

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 3,
                columns: new[] { "Rang1", "Rang2", "Rang3", "Rang4", "invalideplaatsen" },
                values: new object[] { 30, 30, 20, 10, null });

            migrationBuilder.UpdateData(
                table: "zalen",
                keyColumn: "Zaalnr",
                keyValue: 4,
                columns: new[] { "Rang1", "Rang2", "Rang3", "Rang4", "invalideplaatsen" },
                values: new object[] { 210, 115, 90, 20, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "leeftijdsgroepen");

            migrationBuilder.DropColumn(
                name: "Rang2",
                table: "zalen");

            migrationBuilder.DropColumn(
                name: "Rang3",
                table: "zalen");

            migrationBuilder.DropColumn(
                name: "Rang4",
                table: "zalen");

            migrationBuilder.DropColumn(
                name: "invalideplaatsen",
                table: "zalen");

            migrationBuilder.RenameColumn(
                name: "Rang1",
                table: "zalen",
                newName: "Aantal_stoelen");

            migrationBuilder.AlterColumn<string>(
                name: "Leeftijdsgroep",
                table: "shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "sessionIds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "stoelrijen",
                columns: table => new
                {
                    rijid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aantalstoelen = table.Column<int>(name: "Aantal_stoelen", type: "int", nullable: false),
                    Rangnummer = table.Column<int>(type: "int", nullable: false),
                    Zaalnr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stoelrijen", x => x.rijid);
                });

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 5,
                column: "artiest_naam",
                value: null);

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 6,
                column: "artiest_naam",
                value: null);

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 7,
                column: "artiest_naam",
                value: null);

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 8,
                column: "artiest_naam",
                value: null);

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 9,
                column: "artiest_naam",
                value: null);

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 29, 46, 20, DateTimeKind.Local).AddTicks(7819), new DateTime(2023, 1, 26, 14, 29, 46, 20, DateTimeKind.Local).AddTicks(7855), "Horor", "18" });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 29, 46, 20, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 1, 26, 14, 29, 46, 20, DateTimeKind.Local).AddTicks(7860), "Horor", "18" });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd", "Genre", "Leeftijdsgroep" },
                values: new object[] { new DateTime(2023, 1, 26, 14, 29, 46, 20, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 1, 26, 14, 29, 46, 20, DateTimeKind.Local).AddTicks(7864), "Horor", "18" });

            migrationBuilder.InsertData(
                table: "stoelrijen",
                columns: new[] { "rijid", "Aantal_stoelen", "Rangnummer", "Zaalnr" },
                values: new object[,]
                {
                    { 11, 0, 1, 1 },
                    { 12, 0, 2, 1 },
                    { 13, 0, 3, 1 },
                    { 21, 0, 1, 2 },
                    { 22, 0, 2, 2 },
                    { 31, 0, 1, 3 },
                    { 32, 0, 2, 3 },
                    { 41, 0, 1, 4 },
                    { 42, 0, 2, 4 },
                    { 43, 0, 3, 4 }
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
