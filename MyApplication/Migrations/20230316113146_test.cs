using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "LeagueLevel",
                table: "Clubs",
                newName: "LeagueLevelId");

            migrationBuilder.AddColumn<int>(
                name: "CoachOccupationId",
                table: "Staffs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerPositionId",
                table: "Staffs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LeagueLevels",
                columns: table => new
                {
                    LeagueLevelNumber = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueLevels", x => x.LeagueLevelNumber);
                });

            migrationBuilder.CreateTable(
                name: "PlayerPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffOccupations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffOccupations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CoachOccupationId",
                table: "Staffs",
                column: "CoachOccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_PlayerPositionId",
                table: "Staffs",
                column: "PlayerPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_LeagueLevelId",
                table: "Clubs",
                column: "LeagueLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_LeagueLevels_LeagueLevelId",
                table: "Clubs",
                column: "LeagueLevelId",
                principalTable: "LeagueLevels",
                principalColumn: "LeagueLevelNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_PlayerPositions_PlayerPositionId",
                table: "Staffs",
                column: "PlayerPositionId",
                principalTable: "PlayerPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_StaffOccupations_CoachOccupationId",
                table: "Staffs",
                column: "CoachOccupationId",
                principalTable: "StaffOccupations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_LeagueLevels_LeagueLevelId",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_PlayerPositions_PlayerPositionId",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_StaffOccupations_CoachOccupationId",
                table: "Staffs");

            migrationBuilder.DropTable(
                name: "LeagueLevels");

            migrationBuilder.DropTable(
                name: "PlayerPositions");

            migrationBuilder.DropTable(
                name: "StaffOccupations");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_CoachOccupationId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_PlayerPositionId",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_LeagueLevelId",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "CoachOccupationId",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "PlayerPositionId",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "LeagueLevelId",
                table: "Clubs",
                newName: "LeagueLevel");

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "Staffs",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Staffs",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);
        }
    }
}
