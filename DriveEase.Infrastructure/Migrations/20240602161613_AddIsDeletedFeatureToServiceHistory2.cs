using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DriveEase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedFeatureToServiceHistory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ServiceHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoURL",
                value: "content/images/mercedes-logo.jpg");

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsDeleted", "Status" },
                values: new object[] { false, 0 });

            migrationBuilder.InsertData(
                table: "ServiceHistory",
                columns: new[] { "Id", "CarId", "Cost", "Description", "IsDeleted", "IsFinished", "Notes", "ServiceDate", "ServiceEndDate", "ServiceProvider", "ServiceType", "Status" },
                values: new object[,]
                {
                    { 6, 2, 1200m, "Inspect vehicle", false, true, "Service cancelled", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auto Care", "Inspection", 3 },
                    { 7, 2, 1200m, "Inspect vehicle", false, true, "Service cancelled", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auto Care", "Inspection", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ServiceHistory");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoURL",
                value: "content/images/BMW.PNG");

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: 2);
        }
    }
}
