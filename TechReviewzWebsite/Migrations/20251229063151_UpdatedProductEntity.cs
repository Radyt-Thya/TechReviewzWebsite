using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca589b04-4fda-4781-8236-aaed09412f73", "AQAAAAIAAYagAAAAENQ8c7WnotDQ3+yNL3InSc/FAaEhzOzItLpzrzvtR+dzwfcR/aATJopGCUvpXZEzkQ==", "1d76d012-5efd-4fd4-86ad-2065ab41632a" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(3368), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(3372), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(2941), new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(2968), new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(2968) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbbf5ef6-c5c6-4e39-9f08-2dc524c18ad0", "AQAAAAIAAYagAAAAELq1B4E9mrqO+eTiZUplRumA7MnOz10k12wqTN4lLm/KP2ESUeVIzME1jQdF7o7bfw==", "2f0a8a9e-7d86-46d3-91dc-8cf9fc5c7f77" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 27, 13, 11, 38, 278, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 27, 13, 11, 38, 278, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 27, 13, 11, 38, 278, DateTimeKind.Local).AddTicks(5288), new DateTime(2025, 12, 27, 13, 11, 38, 278, DateTimeKind.Local).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 27, 13, 11, 38, 278, DateTimeKind.Local).AddTicks(5314), new DateTime(2025, 12, 27, 13, 11, 38, 278, DateTimeKind.Local).AddTicks(5314) });
        }
    }
}
