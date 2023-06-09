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
    [Migration("20230316121423_OccupationPositionLeagueLevel_Seed")]
    partial class OccupationPositionLeagueLevel_Seed
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
