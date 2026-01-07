using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReviewAttributes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated", "Tag" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3331), new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3350), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Tag" },
                values: new object[] { new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3357), new DateTime(2026, 1, 14, 15, 1, 38, 130, DateTimeKind.Local).AddTicks(3358), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Review");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c43bb64-01f6-418b-ae5c-6fccb9a13605", "AQAAAAIAAYagAAAAEDoSrTJMRPYr5QOSRjxXS++8Dpza1JXogJvyRVcReimvDJ9FyZZ3iK2sGx8d7CksCA==", "b99f7b70-d8a6-4f6d-89f7-7aa896320d03" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2026, 1, 1, 14, 13, 18, 45, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2026, 1, 1, 14, 13, 18, 45, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 1, 14, 13, 18, 45, DateTimeKind.Local).AddTicks(1), new DateTime(2026, 1, 1, 14, 13, 18, 45, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 1, 14, 13, 18, 45, DateTimeKind.Local).AddTicks(23), new DateTime(2026, 1, 1, 14, 13, 18, 45, DateTimeKind.Local).AddTicks(24) });
        }
    }
}
