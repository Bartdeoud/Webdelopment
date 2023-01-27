using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ticketData",
                table: "sessionIds",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6910), new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6951), new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6956), new DateTime(2023, 1, 27, 15, 22, 59, 400, DateTimeKind.Local).AddTicks(6958) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ticketData",
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
    }
}
