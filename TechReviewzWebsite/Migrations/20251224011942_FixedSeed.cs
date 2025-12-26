using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "DateCreated",
                value: new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(7003));

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6588), new DateTime(2025, 12, 24, 9, 19, 40, 983, DateTimeKind.Local).AddTicks(6589) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25039547-2a58-43e1-b035-b7ea8a42d700", "AQAAAAIAAYagAAAAEO2+TKZpxxdYFCe7MA2PIWxQ1STO4AwwkEKtD5NTiqcb2GdfPXa0Ev2iiHnhDcamTw==", "217e590f-ea2f-4864-9b5e-37ef236ab799" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 24, 9, 11, 11, 208, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 24, 9, 11, 11, 208, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 11, 11, 208, DateTimeKind.Local).AddTicks(5536), new DateTime(2025, 12, 24, 9, 11, 11, 208, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 24, 9, 11, 11, 208, DateTimeKind.Local).AddTicks(5558), new DateTime(2025, 12, 24, 9, 11, 11, 208, DateTimeKind.Local).AddTicks(5559) });
        }
    }
}
