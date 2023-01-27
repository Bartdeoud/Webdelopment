using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "expiration",
                table: "sessionIds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                values: new object[] { new DateTime(2023, 1, 27, 15, 3, 42, 961, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 1, 27, 15, 3, 42, 961, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 27, 15, 3, 42, 961, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 1, 27, 15, 3, 42, 961, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 27, 15, 3, 42, 961, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 1, 27, 15, 3, 42, 961, DateTimeKind.Local).AddTicks(4264) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "expiration",
                table: "sessionIds");

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
                values: new object[] { new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8463), new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8467), new DateTime(2023, 1, 26, 19, 3, 47, 396, DateTimeKind.Local).AddTicks(8469) });
        }
    }
}
