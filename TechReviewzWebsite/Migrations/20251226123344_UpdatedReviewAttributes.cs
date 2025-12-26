using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReviewAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad7b746-eaef-4a08-ab39-c99cc5da1c4d", "AQAAAAIAAYagAAAAEEbcIT/Y01ihkvACWsnpU4cBoKuPDDwQ3HJH9k6cRCZP3QmAdHwtawD0oucCc/RtKw==", "46ae64a5-5e0c-432c-b4f5-2ce879eb3ee9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ProductId" },
                values: new object[] { new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(955), new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(971), 1 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ProductId", "Title" },
                values: new object[] { new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(975), new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(976), 0, "Iphone review" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Review");

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d05c1fb-a018-46e5-9a2b-aad9c036adad", "AQAAAAIAAYagAAAAECSjBm5NUaBzPgPoLEsDYhEGwT4gvCjuYfUAuVeJxavrspiBjcBRqyM2j7LrgOruUw==", "43929141-7c96-4d5a-bc2e-8b2c3f079360" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ReviewId" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6999), 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "ReviewId" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(7003), 0 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6568), new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Title" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6588), new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6589), "Laptop review" });
        }
    }
}
