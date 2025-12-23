using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1618), new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1644) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 12, 59, 42, 187, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 12, 59, 42, 187, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 59, 42, 187, DateTimeKind.Local).AddTicks(1529), new DateTime(2025, 12, 23, 12, 59, 42, 187, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 59, 42, 187, DateTimeKind.Local).AddTicks(1555), new DateTime(2025, 12, 23, 12, 59, 42, 187, DateTimeKind.Local).AddTicks(1556) });
        }
    }
}
