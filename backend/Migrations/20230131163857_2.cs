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
            migrationBuilder.RenameColumn(
                name: "ticketData",
                table: "sessionIds",
                newName: "Data");

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 38, 56, 746, DateTimeKind.Local).AddTicks(4967), new DateTime(2023, 1, 31, 17, 38, 56, 746, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 38, 56, 746, DateTimeKind.Local).AddTicks(5026), new DateTime(2023, 1, 31, 17, 38, 56, 746, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 17, 38, 56, 746, DateTimeKind.Local).AddTicks(5030), new DateTime(2023, 1, 31, 17, 38, 56, 746, DateTimeKind.Local).AddTicks(5031) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "sessionIds",
                newName: "ticketData");

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 9, 32, 3, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 1, 31, 15, 9, 32, 3, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 9, 32, 3, DateTimeKind.Local).AddTicks(9075), new DateTime(2023, 1, 31, 15, 9, 32, 3, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 15, 9, 32, 3, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 1, 31, 15, 9, 32, 3, DateTimeKind.Local).AddTicks(9081) });
        }
    }
}
