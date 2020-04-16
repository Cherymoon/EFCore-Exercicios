using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp5.Migrations
{
    public partial class AddVideoAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Genres_GenreId",
                table: "Videos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Videos",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Videos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Classification",
                table: "Videos",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "GeneroID",
                table: "Videos",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "GeneroID",
                table: "Videos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Videos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Videos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Classification",
                table: "Videos",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Genres_GenreId",
                table: "Videos",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
