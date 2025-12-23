using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Brand", "Category", "DateCreated", "Description", "ImageUrl", "Name", "Price", "ReviewId" },
                values: new object[,]
                {
                    { 1, "Apple", null, new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(519), "Latest Apple smartphone with A15 Bionic chip", null, "iPhone 13", 999f, 0 },
                    { 2, "Samsung", null, new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(522), "Flagship Samsung phone with excellent camera", null, "Samsung Galaxy S21", 799f, 0 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Content", "DateCreated", "DateUpdated", "Rating", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Amazing phone with great features!", new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(130), new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(147), 5, "samsung review", 0 },
                    { 2, "battery life could be better.", new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(154), 4, "Laptop review", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
