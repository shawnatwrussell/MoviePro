using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.data.migration
{
    public partial class _012RemovedArticleLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wikipedia",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "IMDB",
                table: "Crew");

            migrationBuilder.DropColumn(
                name: "IMDB",
                table: "Cast");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Wikipedia",
                table: "Movie",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMDB",
                table: "Crew",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IMDB",
                table: "Cast",
                type: "text",
                nullable: true);
        }
    }
}
