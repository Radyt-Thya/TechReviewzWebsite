using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCommentContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e233ffa9-a08d-4e88-ada7-785574b39d7a", "AQAAAAIAAYagAAAAEPrGKX0BkEKXbFFoZga/Y2lBNSQTuL62OpciC6Gg5RM/A9c0s7JnFOPbTyhTlI5EdQ==", "406e8cd1-cd75-4a6d-8ce4-d18abf1ca54b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2026, 1, 17, 10, 42, 56, 580, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2026, 1, 17, 10, 42, 56, 580, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 42, 56, 580, DateTimeKind.Local).AddTicks(2992), new DateTime(2026, 1, 17, 10, 42, 56, 580, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 10, 42, 56, 580, DateTimeKind.Local).AddTicks(3009), new DateTime(2026, 1, 17, 10, 42, 56, 580, DateTimeKind.Local).AddTicks(3010) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ab2d323-f5cf-49d2-bd39-f9afce33979b", "AQAAAAIAAYagAAAAEG84ZGzlrf0kNhUsWUY32Jbtr5kvBRDy1IVUSmunjdrrtd29cR/iY6jZ/bcMknCnBg==", "d5eab82a-2d7d-4b1d-9823-8a0a8bb24020" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2026, 1, 17, 8, 39, 24, 816, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2026, 1, 17, 8, 39, 24, 816, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 8, 39, 24, 816, DateTimeKind.Local).AddTicks(7268), new DateTime(2026, 1, 17, 8, 39, 24, 816, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 17, 8, 39, 24, 816, DateTimeKind.Local).AddTicks(7297), new DateTime(2026, 1, 17, 8, 39, 24, 816, DateTimeKind.Local).AddTicks(7299) });
        }
    }
}
