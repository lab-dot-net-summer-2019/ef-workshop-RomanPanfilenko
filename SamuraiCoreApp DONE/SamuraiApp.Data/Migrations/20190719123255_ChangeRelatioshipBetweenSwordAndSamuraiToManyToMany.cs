using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiApp.Data.Migrations
{
    public partial class ChangeRelatioshipBetweenSwordAndSamuraiToManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SamuraiSword",
                columns: table => new
                {
                    SamuraiId = table.Column<int>(nullable: false),
                    SwordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraiSword", x => new { x.SamuraiId, x.SwordId });
                    table.ForeignKey(
                        name: "FK_SamuraiSword_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuraiSword_Swords_SwordId",
                        column: x => x.SwordId,
                        principalTable: "Swords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamuraiSword_SwordId",
                table: "SamuraiSword",
                column: "SwordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamuraiSword");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "Swords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Swords_SamuraiId",
                table: "Swords",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Swords_Samurais_SamuraiId",
                table: "Swords",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
