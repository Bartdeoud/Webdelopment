﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230122151132_Migrations_3")]
    partial class Migrations3
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Omschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBand");

                    b.ToTable("bands");
                });

            modelBuilder.Entity("Gebruiker", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("gebruikers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Gebruiker");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            UserID = 2,
                            Email = "test2@email.com",
                            Naam = "Jan2",
                            Username = "Jan2",
                            Wachtwoord = "Test2"
                        },
                        new
                        {
                            UserID = 3,
                            Email = "test3@email.com",
                            Naam = "Jan3",
                            Username = "Jan3",
                            Wachtwoord = "Test3"
                        },
                        new
                        {
                            UserID = 4,
                            Email = "test4@email.com",
                            Naam = "Jan4",
                            Username = "Jan4",
                            Wachtwoord = "Test4"
                        });
                });

            modelBuilder.Entity("Huren", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerhuurdeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("reserveringen");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("leden");
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

            modelBuilder.Entity("Show", b =>
                {
                    b.Property<int>("Shownr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shownr"));

                    b.Property<string>("Afbeelding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BeginTijd")
                        .HasColumnType("int");

                    b.Property<int>("EindTijd")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Leeftijdsgroep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zaal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Shownr");

                    b.ToTable("shows");

                    b.HasData(
                        new
                        {
                            Shownr = 1,
                            Afbeelding = "",
                            BeginTijd = 2,
                            EindTijd = 3,
                            Genre = "Horor",
                            Leeftijdsgroep = "18",
                            Naam = "Show 1",
                            zaal = "zaal 1"
                        },
                        new
                        {
                            Shownr = 2,
                            Afbeelding = "",
                            BeginTijd = 3,
                            EindTijd = 4,
                            Genre = "Horor",
                            Leeftijdsgroep = "18",
                            Naam = "Show 2",
                            zaal = "zaal 2"
                        },
                        new
                        {
                            Shownr = 3,
                            Afbeelding = "",
                            BeginTijd = 5,
                            EindTijd = 6,
                            Genre = "Horor",
                            Leeftijdsgroep = "18",
                            Naam = "Show 3",
                            zaal = "zaal 3"
                        });
                });

            modelBuilder.Entity("Stoelrij", b =>
                {
                    b.Property<int>("rijid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rijid"));

                    b.Property<int>("Aantal_stoelen")
                        .HasColumnType("int");

                    b.Property<int>("Rangnummer")
                        .HasColumnType("int");

                    b.Property<int>("Zaalnr")
                        .HasColumnType("int");

                    b.HasKey("rijid");

                    b.ToTable("stoelrijen");

                    b.HasData(
                        new
                        {
                            rijid = 11,
                            Aantalstoelen = 20,
                            Rangnummer = 1,
                            Zaalnr = 1
                        },
                        new
                        {
                            rijid = 12,
                            Aantalstoelen = 100,
                            Rangnummer = 2,
                            Zaalnr = 1
                        },
                        new
                        {
                            rijid = 13,
                            Aantalstoelen = 120,
                            Rangnummer = 3,
                            Zaalnr = 1
                        },
                        new
                        {
                            rijid = 21,
                            Aantalstoelen = 2,
                            Rangnummer = 1,
                            Zaalnr = 2
                        },
                        new
                        {
                            rijid = 22,
                            Aantalstoelen = 160,
                            Rangnummer = 2,
                            Zaalnr = 2
                        },
                        new
                        {
                            rijid = 31,
                            Aantalstoelen = 10,
                            Rangnummer = 1,
                            Zaalnr = 3
                        },
                        new
                        {
                            rijid = 32,
                            Aantalstoelen = 80,
                            Rangnummer = 2,
                            Zaalnr = 3
                        },
                        new
                        {
                            rijid = 41,
                            Aantalstoelen = 40,
                            Rangnummer = 1,
                            Zaalnr = 4
                        },
                        new
                        {
                            rijid = 42,
                            Aantalstoelen = 200,
                            Rangnummer = 2,
                            Zaalnr = 4
                        },
                        new
                        {
                            rijid = 43,
                            Aantalstoelen = 200,
                            Rangnummer = 3,
                            Zaalnr = 4
                        });
                });

            modelBuilder.Entity("Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketID"));

                    b.Property<int?>("GebruikerUserID")
                        .HasColumnType("int");

                    b.Property<string>("stoelNr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketID");

                    b.HasIndex("GebruikerUserID");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("Zaal", b =>
                {
                    b.Property<int>("Zaalnr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Zaalnr"));

                    b.Property<int>("Aantal_stoelen")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Zaalnr");

                    b.ToTable("zalen");

                    b.HasData(
                        new
                        {
                            Zaalnr = 1,
                            Aantalstoelen = 240,
                            Naam = "Zaal 1"
                        },
                        new
                        {
                            Zaalnr = 2,
                            Aantalstoelen = 180,
                            Naam = "Zaal 2"
                        },
                        new
                        {
                            Zaalnr = 3,
                            Aantalstoelen = 90,
                            Naam = "Zaal 3"
                        },
                        new
                        {
                            Zaalnr = 4,
                            Aantalstoelen = 440,
                            Naam = "Zaal 4"
                        });
                });

            modelBuilder.Entity("Artiest", b =>
                {
                    b.HasBaseType("Gebruiker");

                    b.Property<string>("LedenId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Shownr")
                        .HasColumnType("int");

                    b.Property<string>("artiest_naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("LedenId");

                    b.HasIndex("Shownr");

                    b.HasDiscriminator().HasValue("Artiest");

                    b.HasData(
                        new
                        {
                            UserID = 5,
                            Email = "artiestmail1@email.com",
                            Naam = "Artiest1",
                            Username = "Artiest1",
                            Wachtwoord = "Test1",
                            artiestnaam = "Artiest1"
                        },
                        new
                        {
                            UserID = 6,
                            Email = "artiestmail2@email.com",
                            Naam = "Artiest2",
                            Username = "Artiest2",
                            Wachtwoord = "Test2",
                            artiestnaam = "Artiest2"
                        },
                        new
                        {
                            UserID = 7,
                            Email = "artiestmail3@email.com",
                            Naam = "Artiest3",
                            Username = "Artiest3",
                            Wachtwoord = "Test3",
                            artiestnaam = "Artiest3"
                        },
                        new
                        {
                            UserID = 8,
                            Email = "artiestmail4@email.com",
                            Naam = "Artiest4",
                            Username = "Artiest4",
                            Wachtwoord = "Test4",
                            artiestnaam = "Artiest4"
                        },
                        new
                        {
                            UserID = 9,
                            Email = "artiestmail5@email.com",
                            Naam = "Artiest5",
                            Username = "Artiest5",
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
                            UserID = 1,
                            Email = "test1@email.com",
                            Naam = "Jan1",
                            Username = "Jan1",
                            Wachtwoord = "Test1",
                            TotaleDonatie = 1000
                        });
                });

            modelBuilder.Entity("Ticket", b =>
                {
                    b.HasOne("Gebruiker", null)
                        .WithMany("tickets")
                        .HasForeignKey("GebruikerUserID");
                });

            modelBuilder.Entity("Artiest", b =>
                {
                    b.HasOne("Leden", null)
                        .WithMany("artiesten")
                        .HasForeignKey("LedenId");

                    b.HasOne("Show", null)
                        .WithMany("Artiesten")
                        .HasForeignKey("Shownr");
                });

            modelBuilder.Entity("Gebruiker", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("Leden", b =>
                {
                    b.Navigation("artiesten");
                });

            modelBuilder.Entity("Show", b =>
                {
                    b.Navigation("Artiesten");
                });
#pragma warning restore 612, 618
        }
    }
}
