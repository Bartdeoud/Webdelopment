﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230130102450_3")]
    partial class _3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Band", b =>
                {
                    b.Property<int>("IdBand")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBand"));

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Omschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBand");

                    b.ToTable("bands");
                });

            modelBuilder.Entity("Gebruiker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Gebruiker");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = "cf435ea1-bd7e-4793-b560-b8645b0d4212",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce284083-5342-4afb-921d-0f9c04556b0c",
                            Email = "test2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ad6d16a-1ded-4eb7-af11-59c9794583d2",
                            TwoFactorEnabled = false,
                            UserName = "Jan2",
                            Wachtwoord = "Test2"
                        },
                        new
                        {
                            Id = "fe60c67f-df6b-4f3b-b24b-b11281d00861",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac7dda76-b647-44bc-b17c-9f17852f2c4b",
                            Email = "test3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "87492a41-0e9e-4b3c-a0f8-b6f5ba3c1b5f",
                            TwoFactorEnabled = false,
                            UserName = "Jan3",
                            Wachtwoord = "Test3"
                        },
                        new
                        {
                            Id = "0b89514b-614d-417f-8006-b44526bf511c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b7d937c-9e42-489c-913e-ac86a4a14160",
                            Email = "test4@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c5f1b983-8708-4669-a573-ecdc50cb45ae",
                            TwoFactorEnabled = false,
                            UserName = "Jan4",
                            Wachtwoord = "Test4"
                        });
                });

            modelBuilder.Entity("Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("genres");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            Naam = "Horror"
                        },
                        new
                        {
                            GenreID = 2,
                            Naam = "Comedy"
                        },
                        new
                        {
                            GenreID = 3,
                            Naam = "Drama"
                        },
                        new
                        {
                            GenreID = 4,
                            Naam = "Action"
                        },
                        new
                        {
                            GenreID = 5,
                            Naam = "Romance"
                        },
                        new
                        {
                            GenreID = 6,
                            Naam = "Adventure"
                        },
                        new
                        {
                            GenreID = 7,
                            Naam = "Mystery"
                        },
                        new
                        {
                            GenreID = 8,
                            Naam = "Family"
                        },
                        new
                        {
                            GenreID = 9,
                            Naam = "Music"
                        },
                        new
                        {
                            GenreID = 10,
                            Naam = "History"
                        },
                        new
                        {
                            GenreID = 11,
                            Naam = "War"
                        },
                        new
                        {
                            GenreID = 12,
                            Naam = "Western"
                        },
                        new
                        {
                            GenreID = 13,
                            Naam = "Sport"
                        });
                });

            modelBuilder.Entity("Huren", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RuimteNr")
                        .HasColumnType("int");

                    b.Property<int>("VerhuurdeId")
                        .HasColumnType("int");

                    b.Property<int?>("Zaalnr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("reserveringen");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("leden");
                });

            modelBuilder.Entity("Leeftijdsgroep", b =>
                {
                    b.Property<int>("LeeftijdsgroepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeeftijdsgroepID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeeftijdsgroepID");

                    b.ToTable("leeftijdsgroepen");

                    b.HasData(
                        new
                        {
                            LeeftijdsgroepID = 1,
                            Naam = "Alle leeftijden"
                        },
                        new
                        {
                            LeeftijdsgroepID = 2,
                            Naam = "Onder de 18"
                        },
                        new
                        {
                            LeeftijdsgroepID = 3,
                            Naam = "18-65"
                        },
                        new
                        {
                            LeeftijdsgroepID = 4,
                            Naam = "65+"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Ruimte", b =>
                {
                    b.Property<int>("RuimteNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RuimteNr"));

                    b.Property<int>("Capaciteit")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuimteNr");

                    b.ToTable("ruimtes");

                    b.HasData(
                        new
                        {
                            RuimteNr = 1,
                            Capaciteit = 30,
                            Naam = "Ruimte 1"
                        },
                        new
                        {
                            RuimteNr = 2,
                            Capaciteit = 30,
                            Naam = "Ruimte 2"
                        },
                        new
                        {
                            RuimteNr = 3,
                            Capaciteit = 30,
                            Naam = "Ruimte 3"
                        },
                        new
                        {
                            RuimteNr = 4,
                            Capaciteit = 30,
                            Naam = "Ruimte 4"
                        },
                        new
                        {
                            RuimteNr = 5,
                            Capaciteit = 30,
                            Naam = "Ruimte 5"
                        },
                        new
                        {
                            RuimteNr = 6,
                            Capaciteit = 30,
                            Naam = "Ruimte 6"
                        },
                        new
                        {
                            RuimteNr = 7,
                            Capaciteit = 30,
                            Naam = "Ruimte 7"
                        },
                        new
                        {
                            RuimteNr = 8,
                            Capaciteit = 30,
                            Naam = "Ruimte 8"
                        },
                        new
                        {
                            RuimteNr = 9,
                            Capaciteit = 30,
                            Naam = "Ruimte 9"
                        },
                        new
                        {
                            RuimteNr = 10,
                            Capaciteit = 30,
                            Naam = "Ruimte 10"
                        });
                });

            modelBuilder.Entity("SessionId", b =>
                {
                    b.Property<string>("Session")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("ticketData")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Session");

                    b.ToTable("sessionIds");
                });

            modelBuilder.Entity("Show", b =>
                {
                    b.Property<int>("Shownr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shownr"));

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BeginTijd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EindTijd")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Genre")
                        .HasColumnType("int");

                    b.Property<int?>("Leeftijdsgroep")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Zaal")
                        .HasColumnType("int");

                    b.HasKey("Shownr");

                    b.ToTable("shows");

                    b.HasData(
                        new
                        {
                            Shownr = 1,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9410),
                            EindTijd = new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9480),
                            Genre = 1,
                            Leeftijdsgroep = 1,
                            Naam = "Show 1",
                            Zaal = 1
                        },
                        new
                        {
                            Shownr = 2,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9489),
                            EindTijd = new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9491),
                            Genre = 2,
                            Leeftijdsgroep = 2,
                            Naam = "Show 2",
                            Zaal = 2
                        },
                        new
                        {
                            Shownr = 3,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9495),
                            EindTijd = new DateTime(2023, 1, 30, 11, 24, 50, 119, DateTimeKind.Local).AddTicks(9498),
                            Genre = 3,
                            Leeftijdsgroep = 3,
                            Naam = "Show 3",
                            Zaal = 3
                        });
                });

            modelBuilder.Entity("Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketID"));

                    b.Property<int>("Rang")
                        .HasColumnType("int");

                    b.Property<int>("Shownr")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stoelNr")
                        .HasColumnType("int");

                    b.HasKey("TicketID");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("Zaal", b =>
                {
                    b.Property<int>("Zaalnr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Zaalnr"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rang1")
                        .HasColumnType("int");

                    b.Property<int?>("Rang2")
                        .HasColumnType("int");

                    b.Property<int?>("Rang3")
                        .HasColumnType("int");

                    b.Property<int?>("Rang4")
                        .HasColumnType("int");

                    b.Property<int?>("invalideplaatsen")
                        .HasColumnType("int");

                    b.HasKey("Zaalnr");

                    b.ToTable("zalen");

                    b.HasData(
                        new
                        {
                            Zaalnr = 1,
                            Naam = "Zaal 1",
                            Rang1 = 120,
                            Rang2 = 98,
                            Rang3 = 20,
                            invalideplaatsen = 2
                        },
                        new
                        {
                            Zaalnr = 2,
                            Naam = "Zaal 2",
                            Rang1 = 100,
                            Rang2 = 80
                        },
                        new
                        {
                            Zaalnr = 3,
                            Naam = "Zaal 3",
                            Rang1 = 30,
                            Rang2 = 30,
                            Rang3 = 20,
                            Rang4 = 10
                        },
                        new
                        {
                            Zaalnr = 4,
                            Naam = "Zaal 4",
                            Rang1 = 210,
                            Rang2 = 115,
                            Rang3 = 90,
                            Rang4 = 20,
                            invalideplaatsen = 5
                        });
                });

            modelBuilder.Entity("Artiest", b =>
                {
                    b.HasBaseType("Gebruiker");

                    b.Property<int?>("LedenId")
                        .HasColumnType("int");

                    b.Property<string>("artiest_naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("LedenId");

                    b.HasDiscriminator().HasValue("Artiest");

                    b.HasData(
                        new
                        {
                            Id = "7393a1a6-295f-4399-b304-8c3e2b31256c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e2723f9e-3374-477c-809c-695dd505c4d0",
                            Email = "artiestmail1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "75c5ed1e-fd39-40e4-9947-7fd8abd17b55",
                            TwoFactorEnabled = false,
                            UserName = "Artiest1",
                            Wachtwoord = "Test1",
                            artiestnaam = "Artiest1"
                        },
                        new
                        {
                            Id = "4c6a678a-effe-477e-9fcb-1f58a60787ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6ba2e8fc-c25b-4c19-a33a-1e8ca14a332c",
                            Email = "artiestmail2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8c934eb0-fb23-42be-9b0c-83c99844e471",
                            TwoFactorEnabled = false,
                            UserName = "Artiest2",
                            Wachtwoord = "Test2",
                            artiestnaam = "Artiest2"
                        },
                        new
                        {
                            Id = "87357f28-c8c0-4a35-af6d-b84414bd53c8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a91976b-4718-4184-8523-a813ed92bec3",
                            Email = "artiestmail3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "afab3c1b-5f3a-4ec1-85ac-4ae3ec53d3c0",
                            TwoFactorEnabled = false,
                            UserName = "Artiest3",
                            Wachtwoord = "Test3",
                            artiestnaam = "Artiest3"
                        },
                        new
                        {
                            Id = "0a7119d8-ac79-4b5d-b256-89e4166af296",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a24edec6-8eae-4423-ba15-759fa81b795c",
                            Email = "artiestmail4@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "01a72132-a33d-4fd6-b619-83621d622829",
                            TwoFactorEnabled = false,
                            UserName = "Artiest4",
                            Wachtwoord = "Test4",
                            artiestnaam = "Artiest4"
                        },
                        new
                        {
                            Id = "e42b56d5-31af-43aa-9e7a-b988d3a0eaf1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8fcc52d1-e929-4e0e-a98f-fb578d8ffa54",
                            Email = "artiestmail5@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3c8c3783-022b-4a4c-9931-b5bf0ebf9bfb",
                            TwoFactorEnabled = false,
                            UserName = "Artiest5",
                            Wachtwoord = "Test5",
                            artiestnaam = "Artiest5"
                        });
                });

            modelBuilder.Entity("Donateur", b =>
                {
                    b.HasBaseType("Gebruiker");

                    b.Property<int>("TotaleDonatie")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Donateur");

                    b.HasData(
                        new
                        {
                            Id = "bb05fa31-ca3d-4d44-80c0-617c3ea61cb7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d139a075-da0c-42da-ba0c-df2a40f916e3",
                            Email = "test1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "00d4e240-1df2-4e10-aafc-2bd9c9a21334",
                            TwoFactorEnabled = false,
                            UserName = "Jan1",
                            Wachtwoord = "Test1",
                            TotaleDonatie = 1000
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Artiest", b =>
                {
                    b.HasOne("Leden", null)
                        .WithMany("artiesten")
                        .HasForeignKey("LedenId");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Navigation("artiesten");
                });
#pragma warning restore 612, 618
        }
    }
}
