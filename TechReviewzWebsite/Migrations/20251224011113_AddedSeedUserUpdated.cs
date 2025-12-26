using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechReviewzWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedUserUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM [dbo].[AspNetRoles] WHERE [NormalizedName] = 'ADMINISTRATOR')
BEGIN
  INSERT INTO [dbo].[AspNetRoles] ([Id],[ConcurrencyStamp],[Name],[NormalizedName])
  VALUES ('ad2bcf0c-20db-474f-8407-5a6b159518ba', NULL, 'Administrator', 'ADMINISTRATOR');
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[AspNetRoles] WHERE [NormalizedName] = 'USER')
BEGIN
  INSERT INTO [dbo].[AspNetRoles] ([Id],[ConcurrencyStamp],[Name],[NormalizedName])
  VALUES ('bd2bcf0c-20db-474f-8407-5a6b159518bb', NULL, 'User', 'USER');
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[AspNetUsers] WHERE [NormalizedUserName] = 'ADMIN@LOCALHOST.COM')
BEGIN
  INSERT INTO [dbo].[AspNetUsers] ([Id],[AccessFailedCount],[ConcurrencyStamp],[Email],[EmailConfirmed],[FirstName],[Gender],[LastName],[LockoutEnabled],[LockoutEnd],[NormalizedEmail],[NormalizedUserName],[PasswordHash],[PhoneNumber],[PhoneNumberConfirmed],[SecurityStamp],[TwoFactorEnabled],[UserName])
  VALUES ('3781efa7-66dc-47f0-860f-e506d04102e4',0,'25039547-2a58-43e1-b035-b7ea8a42d700','admin@localhost.com',1,'Admin',NULL,'User',0,NULL,'ADMIN@LOCALHOST.COM','ADMIN@LOCALHOST.COM','AQAAAAIAAYagAAAAEO2+TKZpxxdYFCe7MA2PIWxQ1STO4AwwkEKtD5NTiqcb2GdfPXa0Ev2iiHnhDcamTw==',NULL,0,'217e590f-ea2f-4864-9b5e-37ef236ab799',0,'admin@localhost.com');
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[AspNetUserRoles] WHERE [UserId] = '3781efa7-66dc-47f0-860f-e506d04102e4' AND [RoleId] = 'ad2bcf0c-20db-474f-8407-5a6b159518ba')
BEGIN
  INSERT INTO [dbo].[AspNetUserRoles] ([RoleId],[UserId])
  VALUES ('ad2bcf0c-20db-474f-8407-5a6b159518ba','3781efa7-66dc-47f0-860f-e506d04102e4');
END
");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1618), new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 12, 23, 14, 35, 23, 522, DateTimeKind.Local).AddTicks(1644) });
        }
    }
}
