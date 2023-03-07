using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRon.Migrations
{
    /// <inheritdoc />
    public partial class qrcodes3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 6, 18, 53, 57, 945, DateTimeKind.Local).AddTicks(7540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 6, 18, 5, 53, 651, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "QRCode",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "QRCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 6, 18, 5, 53, 651, DateTimeKind.Local).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 6, 18, 53, 57, 945, DateTimeKind.Local).AddTicks(7540));
        }
    }
}
