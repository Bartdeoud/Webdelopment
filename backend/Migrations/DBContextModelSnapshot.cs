﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "544e2630-3e0e-453a-8778-45731f4fe324",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20306d7f-f600-40cb-a1b7-0320d9624030",
                            Email = "test2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d89b8c85-b3a4-47f1-86b5-54774119ab95",
                            TwoFactorEnabled = false,
                            UserName = "Jan2",
                            Wachtwoord = "Test2"
                        },
                        new
                        {
                            Id = "b86c8b73-b2af-4bfd-acfa-0365e3d8b2b0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1e4b85fc-3b94-4764-a380-51cf620d497a",
                            Email = "test3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be5c8194-720a-4334-8dae-5db64acf68cc",
                            TwoFactorEnabled = false,
                            UserName = "Jan3",
                            Wachtwoord = "Test3"
                        },
                        new
                        {
                            Id = "79531cf1-99f1-4c31-925a-17248ad77393",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2c2c7fc8-ea36-4499-8566-d857f512d527",
                            Email = "test4@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "607c1eb8-77c4-4818-95ef-2fd85c630148",
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
                            BeginTijd = new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3321),
                            EindTijd = new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3352),
                            Genre = 1,
                            Leeftijdsgroep = 1,
                            Naam = "Show 1",
                            Zaal = 1
                        },
                        new
                        {
                            Shownr = 2,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3355),
                            EindTijd = new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3357),
                            Genre = 2,
                            Leeftijdsgroep = 2,
                            Naam = "Show 2",
                            Zaal = 2
                        },
                        new
                        {
                            Shownr = 3,
                            Afbeelding = "",
                            BeginTijd = new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3360),
                            EindTijd = new DateTime(2023, 1, 31, 14, 40, 18, 675, DateTimeKind.Local).AddTicks(3362),
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
                            Id = "917caade-565e-4105-9272-c2cfadb2b53d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca5fe9f6-e3fb-49a3-b362-e7e7c210826e",
                            Email = "artiestmail1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "93fcfa16-c141-4279-8d17-977687f19bb4",
                            TwoFactorEnabled = false,
                            UserName = "Artiest1",
                            Wachtwoord = "Test1",
                            artiestnaam = "Artiest1"
                        },
                        new
                        {
                            Id = "8fdaf54c-90bc-43d7-874e-45cb9a70ed53",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0da18a50-3f7a-4c61-82e5-7544fa92cc82",
                            Email = "artiestmail2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e6dc03b3-99eb-4661-8fe0-f8855e1a41bb",
                            TwoFactorEnabled = false,
                            UserName = "Artiest2",
                            Wachtwoord = "Test2",
                            artiestnaam = "Artiest2"
                        },
                        new
                        {
                            Id = "eb5b10de-edc7-469c-abca-f7a5c5c7738d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "47140611-b589-48e0-8df2-46aee2e1f432",
                            Email = "artiestmail3@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f8b5a574-822e-4a49-8a32-adb75b63245e",
                            TwoFactorEnabled = false,
                            UserName = "Artiest3",
                            Wachtwoord = "Test3",
                            artiestnaam = "Artiest3"
                        },
                        new
                        {
                            Id = "159ba6d4-7286-4cf8-a79d-f93ba2d33f45",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de68ba32-423b-44af-84ef-1f6bba414565",
                            Email = "artiestmail4@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9773bb5d-9ae1-4b03-8722-4e8a4872865b",
                            TwoFactorEnabled = false,
                            UserName = "Artiest4",
                            Wachtwoord = "Test4",
                            artiestnaam = "Artiest4"
                        },
                        new
                        {
                            Id = "9e91501e-ad72-4334-8820-da52d3280b4c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc4bda97-31d2-4dd3-8afc-579182224616",
                            Email = "artiestmail5@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6cac4571-ac00-40c6-b3b0-c2613c207c2d",
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
                            Id = "527037d3-93cc-41ef-8e53-079e587d4f90",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6fd1858c-5f7f-4bee-8a45-257bb8243497",
                            Email = "test1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "138fde59-a095-48be-b568-2b2fcdbc6957",
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
