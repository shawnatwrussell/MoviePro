using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.data.migration
{
    public partial class _0009FixedCastId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cast",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cast",
                newName: "ID");
        }
    }
}
