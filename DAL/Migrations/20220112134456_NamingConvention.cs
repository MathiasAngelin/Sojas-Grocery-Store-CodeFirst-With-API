using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class NamingConvention : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentorship_Employees_SinonymId",
                table: "Mentorship");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentorship_Employees_WordId",
                table: "Mentorship");

            migrationBuilder.RenameColumn(
                name: "WordId",
                table: "Mentorship",
                newName: "MentoredById");

            migrationBuilder.RenameColumn(
                name: "SinonymId",
                table: "Mentorship",
                newName: "MentoredForId");

            migrationBuilder.RenameIndex(
                name: "IX_Mentorship_WordId",
                table: "Mentorship",
                newName: "IX_Mentorship_MentoredById");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorship_Employees_MentoredById",
                table: "Mentorship",
                column: "MentoredById",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorship_Employees_MentoredForId",
                table: "Mentorship",
                column: "MentoredForId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentorship_Employees_MentoredById",
                table: "Mentorship");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentorship_Employees_MentoredForId",
                table: "Mentorship");

            migrationBuilder.RenameColumn(
                name: "MentoredById",
                table: "Mentorship",
                newName: "WordId");

            migrationBuilder.RenameColumn(
                name: "MentoredForId",
                table: "Mentorship",
                newName: "SinonymId");

            migrationBuilder.RenameIndex(
                name: "IX_Mentorship_MentoredById",
                table: "Mentorship",
                newName: "IX_Mentorship_WordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorship_Employees_SinonymId",
                table: "Mentorship",
                column: "SinonymId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentorship_Employees_WordId",
                table: "Mentorship",
                column: "WordId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
