using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class ReviewUserIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d4b4abf-d940-4374-85d6-cf5ee653837e", "AQAAAAIAAYagAAAAEBbLY5Vbkmfi9upCUGGRNs6ReTX8Vbz88F6xQYMIdJvBY35F1I2GmHNvd15+g/TWvg==", "ade49b40-e4dd-42cd-bf6b-3444ebba4fc1" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7813), new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7832), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7836), new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7837), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Review",
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
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(498), 0 });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(505), new DateTime(2025, 12, 29, 20, 22, 8, 179, DateTimeKind.Local).AddTicks(506), 0 });
        }
    }
}
