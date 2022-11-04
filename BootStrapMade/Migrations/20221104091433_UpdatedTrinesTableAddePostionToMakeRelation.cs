using Microsoft.EntityFrameworkCore.Migrations;

namespace BootStrapMade.Migrations
{
    public partial class UpdatedTrinesTableAddePostionToMakeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Trainers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainers_PositionId",
                table: "Trainers",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Positions_PositionId",
                table: "Trainers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Positions_PositionId",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_PositionId",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Trainers");
        }
    }
}
