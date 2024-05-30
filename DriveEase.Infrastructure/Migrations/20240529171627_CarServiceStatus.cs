using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveEase.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CarServiceStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "ServiceHistory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ServiceHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsFinished", "Status" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsFinished", "Status" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsFinished", "Status" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsFinished", "Status" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "ServiceHistory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsFinished", "Status" },
                values: new object[] { false, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "ServiceHistory");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ServiceHistory");
        }
    }
}
