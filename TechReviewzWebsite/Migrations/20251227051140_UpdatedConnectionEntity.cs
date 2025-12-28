using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedConnectionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Connection",
                newName: "TargetUsername");

            migrationBuilder.AddColumn<string>(
                name: "Relation",
                table: "Connection",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Connection",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Relation",
                table: "Connection");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Connection");

            migrationBuilder.RenameColumn(
                name: "TargetUsername",
                table: "Connection",
                newName: "Type");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad7b746-eaef-4a08-ab39-c99cc5da1c4d", "AQAAAAIAAYagAAAAEEbcIT/Y01ihkvACWsnpU4cBoKuPDDwQ3HJH9k6cRCZP3QmAdHwtawD0oucCc/RtKw==", "46ae64a5-5e0c-432c-b4f5-2ce879eb3ee9" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(955), new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(975), new DateTime(2025, 12, 26, 20, 33, 42, 445, DateTimeKind.Local).AddTicks(976) });
        }
    }
}
