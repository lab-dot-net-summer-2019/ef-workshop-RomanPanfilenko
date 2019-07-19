using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiApp.Data.Migrations
{
    public partial class AddRelationshipSwordSamurai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "Swords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Swords_SamuraiId",
                table: "Swords",
                column: "SamuraiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Swords_Samurais_SamuraiId",
                table: "Swords",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Swords_Samurais_SamuraiId",
                table: "Swords");

            migrationBuilder.DropIndex(
                name: "IX_Swords_SamuraiId",
                table: "Swords");

            migrationBuilder.DropColumn(
                name: "SamuraiId",
                table: "Swords");
        }
    }
}
