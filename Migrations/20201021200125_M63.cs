using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class M63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoachName",
                table: "Sessions");

            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Enrollments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CoachId",
                table: "Enrollments",
                column: "CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Coaches_CoachId",
                table: "Enrollments",
                column: "CoachId",
                principalTable: "Coaches",
                principalColumn: "CoachId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Coaches_CoachId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_CoachId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Enrollments");

            migrationBuilder.AddColumn<string>(
                name: "CoachName",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
