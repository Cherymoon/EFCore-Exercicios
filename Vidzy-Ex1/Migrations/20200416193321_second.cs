using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp5.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGenre");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Videos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Videos_GenreId",
                table: "Videos",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Genres_GenreId",
                table: "Videos",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Genres_GenreId",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_GenreId",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Videos");

            migrationBuilder.CreateTable(
                name: "VideoGenre",
                columns: table => new
                {
                    VideoId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGenre", x => new { x.VideoId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_VideoGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoGenre_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Progamming" });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "Name", "ReleaseDate" },
                values: new object[] { 1, "Learn C#", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "VideoGenre",
                columns: new[] { "VideoId", "GenreId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGenre_GenreId",
                table: "VideoGenre",
                column: "GenreId");
        }
    }
}
