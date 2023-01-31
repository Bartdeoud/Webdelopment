using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotaleDonatie",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotaleDonatie",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
