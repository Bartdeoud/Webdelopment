using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "stoelNr",
                table: "tickets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Rang",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VerhuurdeId",
                table: "reserveringen",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "reserveringen",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "leden",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Omschrijving",
                table: "bands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Afbeelding",
                table: "bands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "LedenId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "0a7119d8-ac79-4b5d-b256-89e4166af296", 0, "a24edec6-8eae-4423-ba15-759fa81b795c", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "01a72132-a33d-4fd6-b619-83621d622829", false, "Artiest4", "Test4", "Artiest4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "0b89514b-614d-417f-8006-b44526bf511c", 0, "8b7d937c-9e42-489c-913e-ac86a4a14160", "Gebruiker", "test4@email.com", false, false, null, null, null, null, null, false, "c5f1b983-8708-4669-a573-ecdc50cb45ae", false, "Jan4", "Test4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "4c6a678a-effe-477e-9fcb-1f58a60787ec", 0, "6ba2e8fc-c25b-4c19-a33a-1e8ca14a332c", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "8c934eb0-fb23-42be-9b0c-83c99844e471", false, "Artiest2", "Test2", "Artiest2" },
                    { "7393a1a6-295f-4399-b304-8c3e2b31256c", 0, "e2723f9e-3374-477c-809c-695dd505c4d0", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "75c5ed1e-fd39-40e4-9947-7fd8abd17b55", false, "Artiest1", "Test1", "Artiest1" },
                    { "87357f28-c8c0-4a35-af6d-b84414bd53c8", 0, "4a91976b-4718-4184-8523-a813ed92bec3", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "afab3c1b-5f3a-4ec1-85ac-4ae3ec53d3c0", false, "Artiest3", "Test3", "Artiest3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TotaleDonatie", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "bb05fa31-ca3d-4d44-80c0-617c3ea61cb7", 0, "d139a075-da0c-42da-ba0c-df2a40f916e3", "Donateur", "test1@email.com", false, false, null, null, null, null, null, false, "00d4e240-1df2-4e10-aafc-2bd9c9a21334", 1000, false, "Jan1", "Test1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "cf435ea1-bd7e-4793-b560-b8645b0d4212", 0, "ce284083-5342-4afb-921d-0f9c04556b0c", "Gebruiker", "test2@email.com", false, false, null, null, null, null, null, false, "7ad6d16a-1ded-4eb7-af11-59c9794583d2", false, "Jan2", "Test2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "e42b56d5-31af-43aa-9e7a-b988d3a0eaf1", 0, "8fcc52d1-e929-4e0e-a98f-fb578d8ffa54", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "3c8c3783-022b-4a4c-9931-b5bf0ebf9bfb", false, "Artiest5", "Test5", "Artiest5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "fe60c67f-df6b-4f3b-b24b-b11281d00861", 0, "ac7dda76-b647-44bc-b17c-9f17852f2c4b", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "87492a41-0e9e-4b3c-a0f8-b6f5ba3c1b5f", false, "Jan3", "Test3" });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 1,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 2,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "shows",
                keyColumn: "Shownr",
                keyValue: 3,
                columns: new[] { "BeginTijd", "EindTijd" },
                values: new object[] { new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9495), new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9498) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a7119d8-ac79-4b5d-b256-89e4166af296");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b89514b-614d-417f-8006-b44526bf511c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c6a678a-effe-477e-9fcb-1f58a60787ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7393a1a6-295f-4399-b304-8c3e2b31256c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87357f28-c8c0-4a35-af6d-b84414bd53c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb05fa31-ca3d-4d44-80c0-617c3ea61cb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf435ea1-bd7e-4793-b560-b8645b0d4212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e42b56d5-31af-43aa-9e7a-b988d3a0eaf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe60c67f-df6b-4f3b-b24b-b11281d00861");

            migrationBuilder.DropColumn(
                name: "Rang",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "email",
                table: "tickets");

            migrationBuilder.AlterColumn<string>(
                name: "stoelNr",
                table: "tickets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VerhuurdeId",
                table: "reserveringen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "reserveringen",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "leden",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Omschrijving",
                table: "bands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Afbeelding",
                table: "bands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LedenId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[] { "0f6e2c3a-0e5f-4616-b9f6-45ebfa8de5bf", 0, "3c1353fa-af9d-49ea-9b69-d9c68e418b43", "Artiest", "artiestmail3@email.com", false, null, false, null, null, null, null, null, false, "efbb77c6-f89d-4882-b3a9-a2a4a86004d2", false, "Artiest3", "Test3", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord" },
                values: new object[] { "3a32ad7d-7322-4636-b9d8-f7504428b62f", 0, "090a9637-a45f-41ed-a316-91d2bed3ff61", "Gebruiker", "test3@email.com", false, false, null, null, null, null, null, false, "ed21fea7-e9b2-4bc8-84c0-53f29c208892", false, "Jan3", "Test3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LedenId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wachtwoord", "artiest_naam" },
                values: new object[,]
                {
                    { "3cff8772-f457-4f93-9e99-6a8a6f38f954", 0, "603c69c6-f895-4717-8b1e-efe2e260c204", "Artiest", "artiestmail4@email.com", false, null, false, null, null, null, null, null, false, "4f0eeac1-5d57-44db-9e35-1b2b3b41ac5a", false, "Artiest4", "Test4", null },
                    { "5aeff7ff-75a8-4dcb-8637-7be48799db0a", 0, "fdf785b5-0b35-46b5-8fd9-29e5f897e8f0", "Artiest", "artiestmail1@email.com", false, null, false, null, null, null, null, null, false, "924e36fd-9a28-4e59-8e93-9a6ce9aba7a3", false, "Artiest1", "Test1", null },
                    { "8ceb4422-8492-441f-9678-9f42256507b3", 0, "a02e334e-bffb-426e-8a83-064d73b0d0b7", "Artiest", "artiestmail2@email.com", false, null, false, null, null, null, null, null, false, "1fd2ad67-32ec-48ac-b657-4d502cd17b5f", false, "Artiest2", "Test2", null },
                    { "c2c39bbe-b73b-494e-9631-9c6d481fc618", 0, "2abd0dfe-a8e8-4676-975b-79a0d0964b56", "Artiest", "artiestmail5@email.com", false, null, false, null, null, null, null, null, false, "60b2a7b7-cf7e-4708-8d70-1bf71939edb5", false, "Artiest5", "Test5", null }
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
    }
}
