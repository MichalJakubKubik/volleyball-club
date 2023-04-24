﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApplication.Entities;

#nullable disable

namespace MyApplication.Migrations
{
    [DbContext(typeof(ClubDbContext))]
    [Migration("20230317100908_clubs_seed")]
    partial class clubs_seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyApplication.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<byte>("LeagueLevelId")
                        .HasColumnType("tinyint");

                    b.Property<string>("ShortName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueLevelId");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactEmail = "resovia@gmail.com",
                            ContactNumber = "435098209",
                            FullName = "Asseco Resovia Rzeszów",
                            LeagueLevelId = (byte)1,
                            ShortName = "Resovia Rzeszów"
                        },
                        new
                        {
                            Id = 2,
                            ContactEmail = "jastrzebskiwegiel@gmail.com",
                            ContactNumber = "788763121",
                            FullName = "Jastrzębski Węgiel",
                            LeagueLevelId = (byte)1,
                            ShortName = "Jastrzębski Węgiel"
                        },
                        new
                        {
                            Id = 3,
                            ContactEmail = "zawiercie@gmail.com",
                            ContactNumber = "345989099",
                            FullName = "Aluron CMC Warta Zawiercie",
                            LeagueLevelId = (byte)1,
                            ShortName = "Warta Zawiercie"
                        },
                        new
                        {
                            Id = 4,
                            ContactEmail = "treflgdansk@gmail.com",
                            ContactNumber = "448998209",
                            FullName = "Trefl Gdańsk",
                            LeagueLevelId = (byte)1,
                            ShortName = "Trefl Gdańsk"
                        },
                        new
                        {
                            Id = 5,
                            ContactEmail = "projektwarszawa@gmail.com",
                            ContactNumber = "222432567",
                            FullName = "Projekt Warszawa",
                            LeagueLevelId = (byte)1,
                            ShortName = "Projekt Warszawa"
                        },
                        new
                        {
                            Id = 6,
                            ContactEmail = "zaksa@gmail.com",
                            ContactNumber = "989098209",
                            FullName = "Grupa Azoty ZAKSA Kędzierzyn-Koźle",
                            LeagueLevelId = (byte)1,
                            ShortName = "ZAKSA Kędzierzyn-Koźle"
                        },
                        new
                        {
                            Id = 7,
                            ContactEmail = "azsolsztyn@gmail.com",
                            ContactNumber = "443876444",
                            FullName = "Indykpol AZS Olsztyn",
                            LeagueLevelId = (byte)1,
                            ShortName = "AZS Olsztyn"
                        },
                        new
                        {
                            Id = 8,
                            ContactEmail = "stalnysa@gmail.com",
                            ContactNumber = "435034555",
                            FullName = "PSG Stal Nysa",
                            LeagueLevelId = (byte)1,
                            ShortName = "Stal Nysa"
                        },
                        new
                        {
                            Id = 9,
                            ContactEmail = "slepsksuwalki@gmail.com",
                            ContactNumber = "787788820",
                            FullName = "Ślepsk Malow Suwałki",
                            LeagueLevelId = (byte)1,
                            ShortName = "Ślepsk Suwałki"
                        },
                        new
                        {
                            Id = 10,
                            ContactEmail = "skrabelchatow@gmail.com",
                            ContactNumber = "224465780",
                            FullName = "PGE Skra Bełchatów",
                            LeagueLevelId = (byte)1,
                            ShortName = "Skra Bełchatów"
                        },
                        new
                        {
                            Id = 11,
                            ContactEmail = "luklublin@gmail.com",
                            ContactNumber = "121333987",
                            FullName = "LUK Lublin",
                            LeagueLevelId = (byte)2,
                            ShortName = "LUK Lublin"
                        },
                        new
                        {
                            Id = 12,
                            ContactEmail = "gkskatowice@gmail.com",
                            ContactNumber = "988763091",
                            FullName = "GKS Katowice",
                            LeagueLevelId = (byte)2,
                            ShortName = "GKS Katowice"
                        },
                        new
                        {
                            Id = 13,
                            ContactEmail = "barkomkazany@gmail.com",
                            ContactNumber = "345983399",
                            FullName = "Barkom-Każany Lwów",
                            LeagueLevelId = (byte)2,
                            ShortName = "Barkom-Każany Lwów"
                        },
                        new
                        {
                            Id = 14,
                            ContactEmail = "cuprumlubin@gmail.com",
                            ContactNumber = "667312287",
                            FullName = "Cuprum Lubin",
                            LeagueLevelId = (byte)2,
                            ShortName = "Cuprum Lubin"
                        },
                        new
                        {
                            Id = 15,
                            ContactEmail = "czarniradom@gmail.com",
                            ContactNumber = "889657221",
                            FullName = "Cerrad Enea Czarni Radom",
                            LeagueLevelId = (byte)2,
                            ShortName = "Czarni Radom"
                        },
                        new
                        {
                            Id = 16,
                            ContactEmail = "bbts@gmail.com",
                            ContactNumber = "332098209",
                            FullName = "BBTS Bielsko-Biała",
                            LeagueLevelId = (byte)2,
                            ShortName = "BBTS Bielsko-Biała"
                        },
                        new
                        {
                            Id = 17,
                            ContactEmail = "norwidczestochowa@gmail.com",
                            ContactNumber = "900876444",
                            FullName = "Exact Systems Norwid Częstochowa",
                            LeagueLevelId = (byte)2,
                            ShortName = "Norwid Częstochowa"
                        },
                        new
                        {
                            Id = 18,
                            ContactEmail = "mksbedzin@gmail.com",
                            ContactNumber = "435011555",
                            FullName = "MKS Będzin",
                            LeagueLevelId = (byte)2,
                            ShortName = "MKS Będzin"
                        },
                        new
                        {
                            Id = 19,
                            ContactEmail = "gwardiawroclaw@gmail.com",
                            ContactNumber = "212188820",
                            FullName = "Chemeko-System Gwardia Wrocław",
                            LeagueLevelId = (byte)2,
                            ShortName = "Gwardia Wrocław"
                        },
                        new
                        {
                            Id = 20,
                            ContactEmail = "mickiewiczkluczbork@gmail.com",
                            ContactNumber = "266665780",
                            FullName = "Mickiewicz Kluczbork",
                            LeagueLevelId = (byte)2,
                            ShortName = "Mickiewicz Kluczbork"
                        },
                        new
                        {
                            Id = 21,
                            ContactEmail = "bksbydgoszcz@gmail.com",
                            ContactNumber = "901333987",
                            FullName = "BKS Visła Proline Bydgoszcz",
                            LeagueLevelId = (byte)3,
                            ShortName = "BKS Bydgoszcz"
                        },
                        new
                        {
                            Id = 22,
                            ContactEmail = "aviaswidnik@gmail.com",
                            ContactNumber = "333763091",
                            FullName = "PZL LEONARDO Avia Świdnik",
                            LeagueLevelId = (byte)3,
                            ShortName = "Avia Świdnik"
                        },
                        new
                        {
                            Id = 23,
                            ContactEmail = "azsaghkrakow@gmail.com",
                            ContactNumber = "766432112",
                            FullName = "AZS AGH Kraków",
                            LeagueLevelId = (byte)3,
                            ShortName = "AZS AGH Kraków"
                        },
                        new
                        {
                            Id = 24,
                            ContactEmail = "chrobryglogow@gmail.com",
                            ContactNumber = "222312287",
                            FullName = "SPS Chrobry Głogów",
                            LeagueLevelId = (byte)3,
                            ShortName = "Chrobry Głogów"
                        },
                        new
                        {
                            Id = 25,
                            ContactEmail = "lechiatomaszow@gmail.com",
                            ContactNumber = "887677221",
                            FullName = "Lechia Tomaszów Mazowiecki",
                            LeagueLevelId = (byte)3,
                            ShortName = "Lechia Tomaszów Mazowiecki"
                        },
                        new
                        {
                            Id = 26,
                            ContactEmail = "kpssiedlce@gmail.com",
                            ContactNumber = "676798209",
                            FullName = "PSG KPS Siedlce",
                            LeagueLevelId = (byte)3,
                            ShortName = "KPS Siedlce"
                        });
                });

            modelBuilder.Entity("MyApplication.Entities.ClubAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("ClubId")
                        .IsUnique();

                    b.ToTable("ClubAddresses");
                });

            modelBuilder.Entity("MyApplication.Entities.CoachOccupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OccupationName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("StaffOccupations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OccupationName = "Head coach"
                        },
                        new
                        {
                            Id = 2,
                            OccupationName = "Assistant coach"
                        },
                        new
                        {
                            Id = 3,
                            OccupationName = "Strength and conditioning coach"
                        },
                        new
                        {
                            Id = 4,
                            OccupationName = "Statistician"
                        },
                        new
                        {
                            Id = 5,
                            OccupationName = "Physiotherapist"
                        });
                });

            modelBuilder.Entity("MyApplication.Entities.LeagueLevel", b =>
                {
                    b.Property<byte>("LeagueLevelNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("LeagueLevelNumber"));

                    b.Property<string>("LeagueName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("LeagueLevelNumber");

                    b.ToTable("LeagueLevels");

                    b.HasData(
                        new
                        {
                            LeagueLevelNumber = (byte)1,
                            LeagueName = "PlusLiga"
                        },
                        new
                        {
                            LeagueLevelNumber = (byte)2,
                            LeagueName = "Tauron 1. Liga"
                        },
                        new
                        {
                            LeagueLevelNumber = (byte)3,
                            LeagueName = "2. Liga"
                        });
                });

            modelBuilder.Entity("MyApplication.Entities.PlayerPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("PlayerPositions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PositionName = "libero"
                        },
                        new
                        {
                            Id = 2,
                            PositionName = "opposite"
                        },
                        new
                        {
                            Id = 3,
                            PositionName = "setter"
                        },
                        new
                        {
                            Id = 4,
                            PositionName = "middle blocker"
                        },
                        new
                        {
                            Id = 5,
                            PositionName = "outside hitter"
                        });
                });

            modelBuilder.Entity("MyApplication.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfLastUpdate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfLeagueJoin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("SecondName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("StaffAddressId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("StaffAddressId");

                    b.ToTable("Staffs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Staff");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MyApplication.Entities.StaffAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.ToTable("StaffAddresses");
                });

            modelBuilder.Entity("MyApplication.Entities.Coach", b =>
                {
                    b.HasBaseType("MyApplication.Entities.Staff");

                    b.Property<int>("CoachOccupationId")
                        .HasColumnType("int");

                    b.HasIndex("CoachOccupationId");

                    b.HasDiscriminator().HasValue("Coach");
                });

            modelBuilder.Entity("MyApplication.Entities.Player", b =>
                {
                    b.HasBaseType("MyApplication.Entities.Staff");

                    b.Property<int>("PlayerPositionId")
                        .HasColumnType("int");

                    b.Property<byte>("ShirtNumber")
                        .HasColumnType("tinyint");

                    b.HasIndex("PlayerPositionId");

                    b.HasDiscriminator().HasValue("Player");
                });

            modelBuilder.Entity("MyApplication.Entities.Club", b =>
                {
                    b.HasOne("MyApplication.Entities.LeagueLevel", "LeagueLevel")
                        .WithMany("Clubs")
                        .HasForeignKey("LeagueLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LeagueLevel");
                });

            modelBuilder.Entity("MyApplication.Entities.ClubAddress", b =>
                {
                    b.HasOne("MyApplication.Entities.Club", "Club")
                        .WithOne("ClubAddress")
                        .HasForeignKey("MyApplication.Entities.ClubAddress", "ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");
                });

            modelBuilder.Entity("MyApplication.Entities.Staff", b =>
                {
                    b.HasOne("MyApplication.Entities.Club", "Club")
                        .WithMany("Staffs")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyApplication.Entities.StaffAddress", "StaffAddress")
                        .WithMany("Staffs")
                        .HasForeignKey("StaffAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("StaffAddress");
                });

            modelBuilder.Entity("MyApplication.Entities.Coach", b =>
                {
                    b.HasOne("MyApplication.Entities.CoachOccupation", "CoachOccupation")
                        .WithMany("Coaches")
                        .HasForeignKey("CoachOccupationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoachOccupation");
                });

            modelBuilder.Entity("MyApplication.Entities.Player", b =>
                {
                    b.HasOne("MyApplication.Entities.PlayerPosition", "PlayerPosition")
                        .WithMany("Players")
                        .HasForeignKey("PlayerPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayerPosition");
                });

            modelBuilder.Entity("MyApplication.Entities.Club", b =>
                {
                    b.Navigation("ClubAddress")
                        .IsRequired();

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("MyApplication.Entities.CoachOccupation", b =>
                {
                    b.Navigation("Coaches");
                });

            modelBuilder.Entity("MyApplication.Entities.LeagueLevel", b =>
                {
                    b.Navigation("Clubs");
                });

            modelBuilder.Entity("MyApplication.Entities.PlayerPosition", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("MyApplication.Entities.StaffAddress", b =>
                {
                    b.Navigation("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
