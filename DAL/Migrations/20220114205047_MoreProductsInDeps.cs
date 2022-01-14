using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class MoreProductsInDeps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 5, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 1, 5 },
                    { 3, 5 },
                    { 3, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 4, 8 },
                    { 5, 8 },
                    { 2, 9 },
                    { 4, 9 },
                    { 5, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[,]
                {
                    { 2, 4 },
                    { 5, 4 },
                    { 3, 8 },
                    { 3, 9 }
                });
        }
    }
}
