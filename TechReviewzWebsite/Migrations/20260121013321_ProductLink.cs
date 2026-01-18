using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class ProductLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductLink",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "000e33df-6570-4d32-b6d5-e05da1bd4494", "AQAAAAIAAYagAAAAEKeY/iwiOK3Qjh4uZ0Ml00UFyeeWF2xeBe5X6TInfKIRPDp/8fdfNMy69lhRtU2F9g==", "71d2db1a-e556-40d8-a207-81ec443973c1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReleased", "ProductLink" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 33, 20, 369, DateTimeKind.Local).AddTicks(5763), null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReleased", "ProductLink" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 33, 20, 369, DateTimeKind.Local).AddTicks(5766), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 33, 20, 369, DateTimeKind.Local).AddTicks(5212), new DateTime(2026, 1, 21, 9, 33, 20, 369, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 21, 9, 33, 20, 369, DateTimeKind.Local).AddTicks(5230), new DateTime(2026, 1, 21, 9, 33, 20, 369, DateTimeKind.Local).AddTicks(5231) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductLink",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e8c2e2-73cb-4d13-91e4-23c5988ed93e", "AQAAAAIAAYagAAAAEIzaBXueDscFpU/fBodDxZmQo7+X6LihZe7uZJtL3+xShAJZOzafKmPAFI1IpZ2zzA==", "9dcda766-9f57-416d-9831-27d0a340cd2f" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3331), new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3357), new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3358) });
        }
    }
}
