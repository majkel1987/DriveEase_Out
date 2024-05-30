using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveEase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddServiceDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ServiceEndDate",
                table: "ServiceHistory",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 4,
                column: "ServiceEndDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 5,
                column: "ServiceEndDate",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceEndDate",
                table: "ServiceHistory");
        }
    }
}
