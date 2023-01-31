using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stoelNr",
                table: "tickets",
                newName: "aantal");

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 37, 7, 876, DateTimeKind.Local).AddTicks(9300), new DateTime(2023, 1, 31, 22, 37, 7, 876, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 37, 7, 876, DateTimeKind.Local).AddTicks(9367), new DateTime(2023, 1, 31, 22, 37, 7, 876, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 22, 37, 7, 876, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 1, 31, 22, 37, 7, 876, DateTimeKind.Local).AddTicks(9377) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "aantal",
                table: "tickets",
                newName: "stoelNr");

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 1, 31, 21, 2, 51, 579, DateTimeKind.Local).AddTicks(4668) });
        }
    }
}
