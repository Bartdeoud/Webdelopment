using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "159ba6d4-7286-4cf8-a79d-f93ba2d33f45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "527037d3-93cc-41ef-8e53-079e587d4f90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "544e2630-3e0e-453a-8778-45731f4fe324");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79531cf1-99f1-4c31-925a-17248ad77393");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fdaf54c-90bc-43d7-874e-45cb9a70ed53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "917caade-565e-4105-9272-c2cfadb2b53d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e91501e-ad72-4334-8820-da52d3280b4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b86c8b73-b2af-4bfd-acfa-0365e3d8b2b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb5b10de-edc7-469c-abca-f7a5c5c7738d");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    reviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Show = table.Column<int>(type: "int", nullable: false),
                    reviewtekst = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.reviewId);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "0589fe0a-7b1c-4f4e-8e0d-91eadb2a7235", 0, "ce1c6053-3ba9-44e4-b550-1f055ab18e91", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "86183929-dc7b-465f-a71a-c16cd1fe4712", false, "Artiest1", "Test1", "Artiest1" },
                    { "0f44928b-d9be-4433-bbf7-8d546d12419e", 0, "f2688d65-9540-426e-833c-9a02fd96b4f5", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "ed8fadd6-0354-4a05-bd88-89bfddc932e6", false, "Artiest5", "Test5", "Artiest5" },
                    { "2f49e4f8-3f90-4817-abc0-3a09846a6b95", 0, "9bb1fae8-c34d-4a09-8dd1-d1b648489601", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "17b729dd-41c0-45e0-a7ec-2345e2200b3e", false, "Artiest4", "Test4", "Artiest4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "441d4dad-c724-4401-9498-d33000ec8a36", 0, "1513f327-8632-4593-b3b1-7de4eb48aa4b", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "64edff5b-2cab-4050-bb91-5b5d2f4bbe68", false, "Jan4", "Test4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "55f68882-7a4b-4102-9af1-49fb213f42a6", 0, "a17121ac-7d34-4719-b422-0277e506d0c7", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "7d2cc785-80d6-4d6f-9aab-572cc130f820", false, "Artiest2", "Test2", "Artiest2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "5aeb91df-eec4-44f9-bb43-68e79fcc7190", 0, "0846b332-92c5-4032-b600-ee8413020b6b", "Gebruiker", "test2@email.com", false, false, null, null, null, null, null, false, "3905051c-edf9-4231-94b0-51b2e3fceef7", false, "Jan2", "Test2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "5f080ecf-badc-4131-933c-bc6d3cc315d9", 0, "062da52b-209a-41af-96ff-9aad3c86f751", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "49c732e4-3675-4b5c-9d93-d5a4c2e5635b", 1000, false, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "e8b76d29-87e0-42a5-bc38-ad421df3490a", 0, "c980ead1-fa1c-4cbb-a581-46ab02282fd3", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "81d85a94-908d-463b-91f1-e86019527381", false, "Jan3", "Test3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "fbcb8954-d743-4f2e-9e9e-fe42039ac8cd", 0, "e6b6d377-d19f-49b7-8b08-2f2dedd05489", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "7b19cfa2-bf51-401b-b398-5d67510315d6", false, "Artiest3", "Test3", "Artiest3" });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 48, 1, 774, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 1, 31, 14, 48, 1, 774, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 48, 1, 774, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 1, 31, 14, 48, 1, 774, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 48, 1, 774, DateTimeKind.Local).AddTicks(4486), new DateTime(2023, 1, 31, 14, 48, 1, 774, DateTimeKind.Local).AddTicks(4488) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0589fe0a-7b1c-4f4e-8e0d-91eadb2a7235");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f44928b-d9be-4433-bbf7-8d546d12419e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f49e4f8-3f90-4817-abc0-3a09846a6b95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "441d4dad-c724-4401-9498-d33000ec8a36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f68882-7a4b-4102-9af1-49fb213f42a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aeb91df-eec4-44f9-bb43-68e79fcc7190");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f080ecf-badc-4131-933c-bc6d3cc315d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8b76d29-87e0-42a5-bc38-ad421df3490a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbcb8954-d743-4f2e-9e9e-fe42039ac8cd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "159ba6d4-7286-4cf8-a79d-f93ba2d33f45", 0, "de68ba32-423b-44af-84ef-1f6bba414565", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "9773bb5d-9ae1-4b03-8722-4e8a4872865b", false, "Artiest4", "Test4", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "527037d3-93cc-41ef-8e53-079e587d4f90", 0, "6fd1858c-5f7f-4bee-8a45-257bb8243497", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "138fde59-a095-48be-b568-2b2fcdbc6957", 1000, false, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[,]
                {
                    { "544e2630-3e0e-453a-8778-45731f4fe324", 0, "20306d7f-f600-40cb-a1b7-0320d9624030", "Gebruiker", "test2@email.com", false, false, null, null, null, null, null, false, "d89b8c85-b3a4-47f1-86b5-54774119ab95", false, "Jan2", "Test2" },
                    { "79531cf1-99f1-4c31-925a-17248ad77393", 0, "2c2c7fc8-ea36-4499-8566-d857f512d527", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "607c1eb8-77c4-4818-95ef-2fd85c630148", false, "Jan4", "Test4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "8fdaf54c-90bc-43d7-874e-45cb9a70ed53", 0, "0da18a50-3f7a-4c61-82e5-7544fa92cc82", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "e6dc03b3-99eb-4661-8fe0-f8855e1a41bb", false, "Artiest2", "Test2", null },
                    { "917caade-565e-4105-9272-c2cfadb2b53d", 0, "ca5fe9f6-e3fb-49a3-b362-e7e7c210826e", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "93fcfa16-c141-4279-8d17-977687f19bb4", false, "Artiest1", "Test1", null },
                    { "9e91501e-ad72-4334-8820-da52d3280b4c", 0, "bc4bda97-31d2-4dd3-8afc-579182224616", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "6cac4571-ac00-40c6-b3b0-c2613c207c2d", false, "Artiest5", "Test5", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "b86c8b73-b2af-4bfd-acfa-0365e3d8b2b0", 0, "1e4b85fc-3b94-4764-a380-51cf620d497a", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "be5c8194-720a-4334-8dae-5db64acf68cc", false, "Jan3", "Test3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "eb5b10de-edc7-469c-abca-f7a5c5c7738d", 0, "47140611-b589-48e0-8df2-46aee2e1f432", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "f8b5a574-822e-4a49-8a32-adb75b63245e", false, "Artiest3", "Test3", null });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3360), new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3362) });
        }
    }
}
