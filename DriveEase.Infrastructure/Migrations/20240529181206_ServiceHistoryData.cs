using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveEase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ServiceHistoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsFinished", "ServiceEndDate", "Status" },
                values: new object[] { true, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarId", "IsFinished", "ServiceEndDate", "Status" },
                values: new object[] { 2, true, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarId", "Notes", "ServiceEndDate", "Status" },
                values: new object[] { 3, "Brakes are in bad condition", new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarId", "IsFinished", "ServiceEndDate", "Status" },
                values: new object[] { 2, true, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsFinished", "ServiceEndDate", "Status" },
                values: new object[] { false, null, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarId", "IsFinished", "ServiceEndDate", "Status" },
                values: new object[] { 1, false, null, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarId", "Notes", "ServiceEndDate", "Status" },
                values: new object[] { 2, "Brakes are in good condition", null, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarId", "IsFinished", "ServiceEndDate", "Status" },
                values: new object[] { 3, false, null, 0 });
        }
    }
}
