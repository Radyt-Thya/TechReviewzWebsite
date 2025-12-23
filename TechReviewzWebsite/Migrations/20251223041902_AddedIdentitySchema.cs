using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentitySchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 12, 19, 1, 273, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 12, 19, 1, 273, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 19, 1, 273, DateTimeKind.Local).AddTicks(5720), new DateTime(2025, 12, 23, 12, 19, 1, 273, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 19, 1, 273, DateTimeKind.Local).AddTicks(5739), new DateTime(2025, 12, 23, 12, 19, 1, 273, DateTimeKind.Local).AddTicks(5740) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(130), new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 12, 23, 12, 2, 49, 620, DateTimeKind.Local).AddTicks(154) });
        }
    }
}
