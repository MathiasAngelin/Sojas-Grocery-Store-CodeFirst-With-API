using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class UpdatePriceAndUniEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Emails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1,
                column: "Price",
                value: 13m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 2,
                column: "Price",
                value: 23m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 3,
                column: "Price",
                value: 24m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 4,
                column: "Price",
                value: 14m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 5,
                column: "Price",
                value: 18m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 6,
                column: "Price",
                value: 22m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 7,
                column: "Price",
                value: 26m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 8,
                column: "Price",
                value: 89m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 9,
                column: "Price",
                value: 13m);

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmailAddress",
                table: "Emails",
                column: "EmailAddress",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Emails_EmailAddress",
                table: "Emails");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Products",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Emails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1,
                column: "Price",
                value: 13f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 2,
                column: "Price",
                value: 23f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 3,
                column: "Price",
                value: 24f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 4,
                column: "Price",
                value: 14f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 5,
                column: "Price",
                value: 18f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 6,
                column: "Price",
                value: 22f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 7,
                column: "Price",
                value: 26f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 8,
                column: "Price",
                value: 89f);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 9,
                column: "Price",
                value: 13f);
        }
    }
}
