using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.data.migration
{
    public partial class _007AddedImageServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Profile",
                table: "Crew",
                newName: "Poster");

            migrationBuilder.RenameColumn(
                name: "Profile",
                table: "Cast",
                newName: "Poster");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Poster",
                table: "Crew",
                newName: "Profile");

            migrationBuilder.RenameColumn(
                name: "Poster",
                table: "Cast",
                newName: "Profile");
        }
    }
}
