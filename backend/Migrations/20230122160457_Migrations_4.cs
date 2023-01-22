using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Migrations4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EindTijd",
                table: "shows",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BeginTijd",
                table: "shows",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 4, 57, 313, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 1, 22, 17, 4, 57, 313, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 4, 57, 313, DateTimeKind.Local).AddTicks(1630), new DateTime(2023, 1, 22, 17, 4, 57, 313, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 22, 17, 4, 57, 313, DateTimeKind.Local).AddTicks(1640), new DateTime(2023, 1, 22, 17, 4, 57, 313, DateTimeKind.Local).AddTicks(1644) });

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
            migrationBuilder.AlterColumn<int>(
                name: "EindTijd",
                table: "shows",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "BeginTijd",
                table: "shows",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { 5, 6 });

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 11,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 12,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 13,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 21,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 22,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 31,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 32,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 41,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 42,
                column: "Aantal_stoelen",
                value: 0);

            migrationBuilder.UpdateData(
                table: "stoelrijen",
                keyColumn: "rijid",
                keyValue: 43,
                column: "Aantal_stoelen",
                value: 0);

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
