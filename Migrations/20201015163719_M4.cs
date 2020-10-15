using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionTitle",
                table: "Sessions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionTitle",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
