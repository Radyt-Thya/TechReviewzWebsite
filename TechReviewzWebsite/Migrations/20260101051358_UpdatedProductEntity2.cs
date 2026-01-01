using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedProductEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageContentType",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Product",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f52d99-f9b8-428d-a0a5-a5fa2d0a48b4", "AQAAAAIAAYagAAAAEP93SOzUELH5SdWX/EjrLpLTHOZNb7TE/mIHZGXQD6ZVGoEZJ+Dsqpl8hpew3D1cxQ==", "593f4772-85de-41b1-8c6c-d5d4da10de4b" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImageContentType", "ImageData" },
                values: new object[] { new DateTime(2026, 1, 1, 13, 13, 57, 122, DateTimeKind.Local).AddTicks(8044), null, null });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "ImageContentType", "ImageData" },
                values: new object[] { new DateTime(2026, 1, 1, 13, 13, 57, 122, DateTimeKind.Local).AddTicks(8047), null, null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 1, 13, 13, 57, 122, DateTimeKind.Local).AddTicks(7594), new DateTime(2026, 1, 1, 13, 13, 57, 122, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 1, 13, 13, 57, 122, DateTimeKind.Local).AddTicks(7624), new DateTime(2026, 1, 1, 13, 13, 57, 122, DateTimeKind.Local).AddTicks(7625) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageContentType",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Product");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7813), new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7836), new DateTime(2025, 12, 31, 16, 16, 9, 497, DateTimeKind.Local).AddTicks(7837) });
        }
    }
}
