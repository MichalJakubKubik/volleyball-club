using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApplication.Migrations
{
    /// <inheritdoc />
    public partial class nameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_StaffOccupations_CoachOccupationId",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffOccupations",
                table: "StaffOccupations");

            migrationBuilder.RenameTable(
                name: "StaffOccupations",
                newName: "CoachOccupations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoachOccupations",
                table: "CoachOccupations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_CoachOccupations_CoachOccupationId",
                table: "Staffs",
                column: "CoachOccupationId",
                principalTable: "CoachOccupations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_CoachOccupations_CoachOccupationId",
                table: "Staffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoachOccupations",
                table: "CoachOccupations");

            migrationBuilder.RenameTable(
                name: "CoachOccupations",
                newName: "StaffOccupations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffOccupations",
                table: "StaffOccupations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_StaffOccupations_CoachOccupationId",
                table: "Staffs",
                column: "CoachOccupationId",
                principalTable: "StaffOccupations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
