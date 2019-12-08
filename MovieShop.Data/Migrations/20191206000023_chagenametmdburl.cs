using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShop.Data.Migrations
{
    public partial class chagenametmdburl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TmdbId",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "TmdbUrl",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TmdbUrl",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "TmdbId",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
