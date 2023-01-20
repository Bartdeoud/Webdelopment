using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Data.Migrations
{
    public partial class Migrations_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "gebruikers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "gebruikers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "gebruikers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "gebruikers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "cc6bdd53-5f06-4dd6-ba68-4d040f36c635", "b4f4d66e-6c3c-4d45-a10e-29115d9e56c0", "160de5bd-1b95-46bf-843e-77198a93c053" });

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "de869b06-1797-44c6-aed8-18a6f465a747", "28da8461-1a24-4242-a383-aa94de4d0908", "25d65ad3-41df-4ad0-9b66-c84d93047b85" });

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "382f5e2a-2a16-41db-9496-f814430e002f", "6db07288-4dd9-49a0-a207-71c7da7b3db1", "68d43203-a81f-40eb-b316-48015d9d727b" });

            migrationBuilder.UpdateData(
                table: "gebruikers",
                keyColumn: "UserID",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Id", "SecurityStamp" },
                values: new object[] { "b065dbcd-75c2-4d69-a821-9bd6d9dbf16a", "2173bfc4-29fb-44e6-82ba-08800d4f24cf", "7abebdcc-abd3-42fd-b070-fc392f87a32d" });
        }
    }
}
