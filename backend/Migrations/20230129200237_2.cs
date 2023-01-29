using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b58ff28-382a-45b3-b121-96b756393a39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45a75585-afc9-44dd-891d-a802bc351384");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "466c3603-3904-425f-b161-2505b1fec505");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b83e937-2bce-4b5a-9589-30e79cd4672d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "653dcdc0-dbfc-457b-8611-7a0160ed7852");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6e0eeb2-9882-4aa7-84c5-dc7c5af41964");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9d9a3a2-305f-4bec-82b2-41d8fa5f7f6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d608fa44-ca70-45fe-9f17-9fd2aa2afd4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb0d4571-f8a1-4e92-8402-a978d0f2c157");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "0f6e2c3a-0e5f-4616-b9f6-45ebfa8de5bf", 0, "3c1353fa-af9d-49ea-9b69-d9c68e418b43", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "efbb77c6-f89d-4882-b3a9-a2a4a86004d2", false, "Artiest3", "Test3", "Artiest3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "3a32ad7d-7322-4636-b9d8-f7504428b62f", 0, "090a9637-a45f-41ed-a316-91d2bed3ff61", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "ed21fea7-e9b2-4bc8-84c0-53f29c208892", false, "Jan3", "Test3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "3cff8772-f457-4f93-9e99-6a8a6f38f954", 0, "603c69c6-f895-4717-8b1e-efe2e260c204", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "4f0eeac1-5d57-44db-9e35-1b2b3b41ac5a", false, "Artiest4", "Test4", "Artiest4" },
                    { "5aeff7ff-75a8-4dcb-8637-7be48799db0a", 0, "fdf785b5-0b35-46b5-8fd9-29e5f897e8f0", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "924e36fd-9a28-4e59-8e93-9a6ce9aba7a3", false, "Artiest1", "Test1", "Artiest1" },
                    { "8ceb4422-8492-441f-9678-9f42256507b3", 0, "a02e334e-bffb-426e-8a83-064d73b0d0b7", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "1fd2ad67-32ec-48ac-b657-4d502cd17b5f", false, "Artiest2", "Test2", "Artiest2" },
                    { "c2c39bbe-b73b-494e-9631-9c6d481fc618", 0, "2abd0dfe-a8e8-4676-975b-79a0d0964b56", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "60b2a7b7-cf7e-4708-8d70-1bf71939edb5", false, "Artiest5", "Test5", "Artiest5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "ca8cc35f-8ffe-4661-a303-9bbef810bbd0", 0, "1e1251fc-e7a8-4b39-99cf-f510698a131d", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "497bad59-de51-46f8-a5dc-1ce912a9d18d", 1000, false, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[,]
                {
                    { "d9fb8668-a59e-4629-99f2-b1caf6bd3b99", 0, "c07ca54b-808a-4fcc-bf7a-12d85b70e3e7", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "2f92245f-943d-40bb-a509-4594246b7174", false, "Jan4", "Test4" },
                    { "f9d22672-c1cd-43b6-b102-4bd401112c4d", 0, "9df8795a-abe4-4aec-849c-8c4324b5165b", "Gebruiker", "test2@email.com", false, false, null, null, null, null, null, false, "57f6ea41-a5f7-4c92-a8a2-16de6496c6e7", false, "Jan2", "Test2" }
                });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 21, 2, 36, 753, DateTimeKind.Local).AddTicks(1769), new DateTime(2023, 1, 29, 21, 2, 36, 753, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 21, 2, 36, 753, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 1, 29, 21, 2, 36, 753, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 21, 2, 36, 753, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 1, 29, 21, 2, 36, 753, DateTimeKind.Local).AddTicks(1817) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f6e2c3a-0e5f-4616-b9f6-45ebfa8de5bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a32ad7d-7322-4636-b9d8-f7504428b62f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cff8772-f457-4f93-9e99-6a8a6f38f954");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aeff7ff-75a8-4dcb-8637-7be48799db0a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ceb4422-8492-441f-9678-9f42256507b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2c39bbe-b73b-494e-9631-9c6d481fc618");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca8cc35f-8ffe-4661-a303-9bbef810bbd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9fb8668-a59e-4629-99f2-b1caf6bd3b99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9d22672-c1cd-43b6-b102-4bd401112c4d");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "1b58ff28-382a-45b3-b121-96b756393a39", 0, "087c870f-aef4-4a17-a307-6466bb9b30e1", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "c19ce46d-dd6b-4f70-8a10-7972be2baa8c", false, 7, "Artiest3", "Test3", null },
                    { "45a75585-afc9-44dd-891d-a802bc351384", 0, "8fc796bd-44d5-471a-9c89-f643af5cb539", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "9f5f60eb-8735-4c0d-8d64-bfcadebb8566", false, 6, "Artiest2", "Test2", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[,]
                {
                    { "466c3603-3904-425f-b161-2505b1fec505", 0, "1e265a59-fe1e-4efa-a1a9-5e061ba4e350", "Gebruiker", "test2@email.com", false, false, null, null, null, null, null, false, "1a55d6e8-0d4e-40c9-86dc-71180681243a", false, 2, "Jan2", "Test2" },
                    { "4b83e937-2bce-4b5a-9589-30e79cd4672d", 0, "fab52f5a-7c9d-4a44-8c44-563c9a17616a", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "ba32b64f-bdb1-4300-a907-32b8a406baba", false, 3, "Jan3", "Test3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "653dcdc0-dbfc-457b-8611-7a0160ed7852", 0, "54a4e20c-ec9c-4ab8-bd70-fd2396b1609c", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "91cecc3d-d0f1-414c-9b6b-4db2146f7a0a", false, 5, "Artiest1", "Test1", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[] { "a6e0eeb2-9882-4aa7-84c5-dc7c5af41964", 0, "8b9cb56a-3a99-4a23-801e-843ca546a969", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "4a0b278c-6b16-4b18-8e1e-1ced04164ed5", false, 4, "Jan4", "Test4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "a9d9a3a2-305f-4bec-82b2-41d8fa5f7f6e", 0, "0c49b2cd-e499-491b-9ab8-5950e93ec91b", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "935156f7-8164-4523-a4f2-13078a8ee75c", false, 9, "Artiest5", "Test5", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[] { "d608fa44-ca70-45fe-9f17-9fd2aa2afd4f", 0, "b503b628-b83f-4cba-8853-075d79665171", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "0393fbe7-1fa3-4c65-b847-614a469594dd", 1000, false, 1, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "eb0d4571-f8a1-4e92-8402-a978d0f2c157", 0, "cc16f17c-898c-40ba-91d1-4c008921c2f1", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "c9679969-0b19-4814-b1d4-8ce0c6221cbb", false, 8, "Artiest4", "Test4", null });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 20, 29, 22, 695, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 1, 29, 20, 29, 22, 695, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 20, 29, 22, 695, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 1, 29, 20, 29, 22, 695, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 20, 29, 22, 695, DateTimeKind.Local).AddTicks(989), new DateTime(2023, 1, 29, 20, 29, 22, 695, DateTimeKind.Local).AddTicks(991) });
        }
    }
}
