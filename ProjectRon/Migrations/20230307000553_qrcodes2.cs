using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRon.Migrations
{
    /// <inheritdoc />
    public partial class qrcodes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "QRCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 6, 18, 5, 53, 651, DateTimeKind.Local).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 6, 18, 5, 53, 651, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
