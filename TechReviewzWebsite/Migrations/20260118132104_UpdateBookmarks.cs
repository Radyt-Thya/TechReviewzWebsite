using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookmarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bookmark",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b14f5c-7e2c-4d7b-86dc-79c54c03e94a", "AQAAAAIAAYagAAAAEBDeN7B8bsjs7CF/UyQzbEdeWSEpE4W8WbFFg2i6uvAHdpyZz0zV9gqUddaDJ8a0Fw==", "69f92a7e-b54d-4038-aaf2-fcfb216aaf54" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2026, 1, 18, 21, 21, 3, 63, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2026, 1, 18, 21, 21, 3, 63, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 21, 3, 63, DateTimeKind.Local).AddTicks(1998), new DateTime(2026, 1, 18, 21, 21, 3, 63, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 18, 21, 21, 3, 63, DateTimeKind.Local).AddTicks(2012), new DateTime(2026, 1, 18, 21, 21, 3, 63, DateTimeKind.Local).AddTicks(2013) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Bookmark",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
