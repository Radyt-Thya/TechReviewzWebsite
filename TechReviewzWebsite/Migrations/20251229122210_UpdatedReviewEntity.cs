using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReviewEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb24827-84c1-404d-b3bf-6e7259ea8032", "AQAAAAIAAYagAAAAEBV5CMTD4c9Iw2bloDbGgS7mVX5+s+UP58JEWt5Swff8WerxdxScFxWobr20o8uznw==", "f2f63305-cd7c-4429-9661-951be8654d21" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(505), new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(506) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Review");

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
                column: "DateCreated",
                value: new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 29, 14, 31, 49, 631, DateTimeKind.Local).AddTicks(3372));

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
    }
}
