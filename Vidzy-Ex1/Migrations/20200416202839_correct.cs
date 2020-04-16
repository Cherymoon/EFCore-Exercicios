using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp5.Migrations
{
    public partial class correct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "GeneroID",
                table: "Videos");

            migrationBuilder.AddForeignKey(
                name: "ForeignKey_Post_Blog",
                table: "Videos",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ForeignKey_Post_Blog",
                table: "Videos");

            migrationBuilder.AddForeignKey(
                name: "GeneroID",
                table: "Videos",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
