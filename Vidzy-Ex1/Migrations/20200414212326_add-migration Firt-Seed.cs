using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp5.Migrations
{
    public partial class addmigrationFirtSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGenre",
                keyColumns: new[] { "VideoId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
