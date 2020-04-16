using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp5.Migrations
{
    public partial class AlterGenreIdTOGeneroID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ForeignKey_Post_Blog",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Videos",
                newName: "GeneroID");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_GenreId",
                table: "Videos",
                newName: "IX_Videos_GeneroID");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Genres_GeneroID",
                table: "Videos",
                column: "GeneroID",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Genres_GeneroID",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "GeneroID",
                table: "Videos",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_GeneroID",
                table: "Videos",
                newName: "IX_Videos_GenreId");

            migrationBuilder.AddForeignKey(
                name: "ForeignKey_Post_Blog",
                table: "Videos",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
