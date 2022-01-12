using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Mentorship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentorship",
                columns: table => new
                {
                    WordId = table.Column<int>(type: "int", nullable: false),
                    SinonymId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentorship", x => new { x.SinonymId, x.WordId });
                    table.ForeignKey(
                        name: "FK_Mentorship_Employees_SinonymId",
                        column: x => x.SinonymId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mentorship_Employees_WordId",
                        column: x => x.WordId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Mentorship",
                columns: new[] { "SinonymId", "WordId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 5 },
                    { 2, 1 },
                    { 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mentorship_WordId",
                table: "Mentorship",
                column: "WordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentorship");
        }
    }
}
