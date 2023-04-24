using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class OccupationPositionLeagueLevel_Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeagueLevels",
                columns: new[] { "LeagueLevelNumber", "LeagueName" },
                values: new object[,]
                {
                    { (byte)1, "PlusLiga" },
                    { (byte)2, "Tauron 1. Liga" },
                    { (byte)3, "2. Liga" }
                });

            migrationBuilder.InsertData(
                table: "PlayerPositions",
                columns: new[] { "Id", "PositionName" },
                values: new object[,]
                {
                    { 1, "libero" },
                    { 2, "opposite" },
                    { 3, "setter" },
                    { 4, "middle blocker" },
                    { 5, "outside hitter" }
                });

            migrationBuilder.InsertData(
                table: "StaffOccupations",
                columns: new[] { "Id", "OccupationName" },
                values: new object[,]
                {
                    { 1, "Head coach" },
                    { 2, "Assistant coach" },
                    { 3, "Strength and conditioning coach" },
                    { 4, "Statistician" },
                    { 5, "Physiotherapist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeagueLevels",
                keyColumn: "LeagueLevelNumber",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "LeagueLevels",
                keyColumn: "LeagueLevelNumber",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "LeagueLevels",
                keyColumn: "LeagueLevelNumber",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PlayerPositions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StaffOccupations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaffOccupations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StaffOccupations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StaffOccupations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StaffOccupations",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
