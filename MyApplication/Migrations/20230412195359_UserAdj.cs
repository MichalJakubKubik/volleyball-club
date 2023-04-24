using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class UserAdj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagingClubId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ManagingClubId",
                table: "Users",
                column: "ManagingClubId",
                unique: true,
                filter: "[ManagingClubId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Clubs_ManagingClubId",
                table: "Users",
                column: "ManagingClubId",
                principalTable: "Clubs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clubs_ManagingClubId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ManagingClubId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ManagingClubId",
                table: "Users");
        }
    }
}
