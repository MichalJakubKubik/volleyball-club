using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LeagueLevel = table.Column<byte>(type: "tinyint", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClubAddresses_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    DateOfLeagueJoin = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    DateOfLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffAddressId = table.Column<int>(type: "int", nullable: false),
                    ClubId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ShirtNumber = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffs_StaffAddresses_StaffAddressId",
                        column: x => x.StaffAddressId,
                        principalTable: "StaffAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubAddresses_ClubId",
                table: "ClubAddresses",
                column: "ClubId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_ClubId",
                table: "Staffs",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_StaffAddressId",
                table: "Staffs",
                column: "StaffAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClubAddresses");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "StaffAddresses");
        }
    }
}
