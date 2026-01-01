using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProduct2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageContentType",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Product",
                newName: "Specification");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Product",
                newName: "DateReleased");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specification",
                table: "Product",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "DateReleased",
                table: "Product",
                newName: "DateCreated");

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
    }
}
