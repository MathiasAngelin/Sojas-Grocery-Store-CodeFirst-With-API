using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Addedproductswithdepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "ListOfIngredients", "ProductName" },
                values: new object[] { 2, "Kyckling, vatten", "Kyckling" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CampainId", "DateOfLastCheck", "EmployeeId", "ExpirationDate", "ListOfIngredients", "NumberInStore", "Price", "ProductName" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Havre, durum", 3, 23f, "Pasta" },
                    { 3, 1, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lingon, Socker", 2, 24f, "Lingon" },
                    { 4, 1, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Havre, vatten", 2, 14f, "Havredryck" },
                    { 5, 1, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sötningsmedel, vatten", 2, 18f, "Pepsi" },
                    { 6, 1, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Havre, Sirap", 2, 22f, "Lingongrova" },
                    { 7, 1, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senapsfrön, vatten", 3, 26f, "Senap" },
                    { 8, 1, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Köttfärs, Fett", 5, 89f, "Köttfärs" },
                    { 9, 1, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gurka, vatten", 2, 13f, "Gurka" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 4, 2 },
                    { 1, 3 },
                    { 4, 3 },
                    { 2, 4 },
                    { 5, 4 },
                    { 2, 5 },
                    { 5, 5 },
                    { 2, 6 },
                    { 5, 6 },
                    { 3, 7 },
                    { 5, 7 },
                    { 3, 8 },
                    { 3, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 4, 3 });

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
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DepartmentProducts",
                keyColumns: new[] { "DepartmentId", "ProductId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "EmployeeId", "ListOfIngredients", "ProductName" },
                values: new object[] { 1, "Gurka, vatten", "Gurka" });
        }
    }
}
