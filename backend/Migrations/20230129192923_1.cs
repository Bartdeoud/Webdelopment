using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
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
                keyValue: "0a2fc4df-4156-4746-a5c9-f4d91cd7c503");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "356ff5b6-4d93-4a39-b896-f984760effc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35d873e1-729b-4f4c-8153-7c246b17dc38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "417ca7f8-f0e3-4680-bc19-9213521a8f6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b3d21ac-5292-4dee-b4cb-9edb67b38e88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72460b90-c1e7-4033-880e-213709b26f20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a244c26a-ee98-4fd7-af12-6207e8b54b6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c24d7dee-d214-4a07-bc18-ee175301c0e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f82dbf8d-cf99-44c1-b4c3-2be386aa482d");

            migrationBuilder.DropColumn(
                name: "Naam",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "1b58ff28-382a-45b3-b121-96b756393a39", 0, "087c870f-aef4-4a17-a307-6466bb9b30e1", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "c19ce46d-dd6b-4f70-8a10-7972be2baa8c", false, 7, "Artiest3", "Test3", "Artiest3" },
                    { "45a75585-afc9-44dd-891d-a802bc351384", 0, "8fc796bd-44d5-471a-9c89-f643af5cb539", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "9f5f60eb-8735-4c0d-8d64-bfcadebb8566", false, 6, "Artiest2", "Test2", "Artiest2" }
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
                values: new object[] { "653dcdc0-dbfc-457b-8611-7a0160ed7852", 0, "54a4e20c-ec9c-4ab8-bd70-fd2396b1609c", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "91cecc3d-d0f1-414c-9b6b-4db2146f7a0a", false, 5, "Artiest1", "Test1", "Artiest1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[] { "a6e0eeb2-9882-4aa7-84c5-dc7c5af41964", 0, "8b9cb56a-3a99-4a23-801e-843ca546a969", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "4a0b278c-6b16-4b18-8e1e-1ced04164ed5", false, 4, "Jan4", "Test4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "a9d9a3a2-305f-4bec-82b2-41d8fa5f7f6e", 0, "0c49b2cd-e499-491b-9ab8-5950e93ec91b", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "935156f7-8164-4523-a4f2-13078a8ee75c", false, 9, "Artiest5", "Test5", "Artiest5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[] { "d608fa44-ca70-45fe-9f17-9fd2aa2afd4f", 0, "b503b628-b83f-4cba-8853-075d79665171", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "0393fbe7-1fa3-4c65-b847-614a469594dd", 1000, false, 1, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "eb0d4571-f8a1-4e92-8402-a978d0f2c157", 0, "cc16f17c-898c-40ba-91d1-4c008921c2f1", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "c9679969-0b19-4814-b1d4-8ce0c6221cbb", false, 8, "Artiest4", "Test4", "Artiest4" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[] { "0a2fc4df-4156-4746-a5c9-f4d91cd7c503", 0, "c044d82f-8f8a-4c6d-9bcd-77f259758e70", "Donateur", "test1@email.com", false, false, null, "Jan1", null, null, null, null, false, "1e68f8c0-77ca-4cdb-87e6-86b73c2ad9b0", 1000, false, 1, null, "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "356ff5b6-4d93-4a39-b896-f984760effc7", 0, "17585997-1872-4180-9fb7-538e0a8fb187", "Artiest", "artiestmail2@email.com", false, null, false, null, "Artiest2", null, null, null, null, false, "6539edf2-592f-4501-b97d-bdee077f53dc", false, 6, null, "Test2", null },
                    { "35d873e1-729b-4f4c-8153-7c246b17dc38", 0, "90dc1fa9-0afa-4b65-b8fe-0e712d202bdc", "Artiest", "artiestmail4@email.com", false, null, false, null, "Artiest4", null, null, null, null, false, "fd99516a-4dee-4e3c-a789-7ebd7afa3bc6", false, 8, null, "Test4", null },
                    { "417ca7f8-f0e3-4680-bc19-9213521a8f6e", 0, "41eafd92-a97c-4ffe-9154-a99182e09471", "Artiest", "artiestmail1@email.com", false, null, false, null, "Artiest1", null, null, null, null, false, "f219d035-0732-4176-9c6b-cca6b075136f", false, 5, null, "Test1", null },
                    { "6b3d21ac-5292-4dee-b4cb-9edb67b38e88", 0, "5942b8ab-96c9-4864-89e5-c30af260965f", "Artiest", "artiestmail5@email.com", false, null, false, null, "Artiest5", null, null, null, null, false, "f9aeaaaa-4361-4a16-ad08-8382fa17ccc7", false, 9, null, "Test5", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord" },
                values: new object[,]
                {
                    { "72460b90-c1e7-4033-880e-213709b26f20", 0, "58765d9a-4371-4ff8-9401-84532d74dad2", "Gebruiker", "test3@email.com", false, false, null, "Jan3", null, null, null, null, false, "b02995b7-20ee-4480-bd6a-c63bfddc6065", false, 3, null, "Test3" },
                    { "a244c26a-ee98-4fd7-af12-6207e8b54b6a", 0, "79871082-cbee-4eaf-b278-a4348e237750", "Gebruiker", "test4@email.com", false, false, null, "Jan4", null, null, null, null, false, "c3e6d05c-2618-47dc-a528-2effa1a3e9ab", false, 4, null, "Test4" },
                    { "c24d7dee-d214-4a07-bc18-ee175301c0e9", 0, "97a6d0d1-885c-4aec-8b07-1353d9ee77bd", "Gebruiker", "test2@email.com", false, false, null, "Jan2", null, null, null, null, false, "17ffcf4c-dcdf-49ab-928c-5ee98875b9ae", false, 2, null, "Test2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "Naam", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "f82dbf8d-cf99-44c1-b4c3-2be386aa482d", 0, "110e537c-feca-42cb-903c-bfb4fbffc2b1", "Artiest", "artiestmail3@email.com", false, null, false, null, "Artiest3", null, null, null, null, false, "d8a30b10-ef88-4f15-adc2-70b0f8536b41", false, 7, null, "Test3", null });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7245), new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7249), new DateTime(2023, 1, 29, 11, 47, 30, 452, DateTimeKind.Local).AddTicks(7250) });
        }
    }
}
