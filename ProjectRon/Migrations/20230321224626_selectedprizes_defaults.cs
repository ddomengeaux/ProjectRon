using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRon.Migrations
{
    /// <inheritdoc />
    public partial class selectedprizes_defaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "SelectedPrize",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 17, 46, 26, 435, DateTimeKind.Local).AddTicks(3460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 17, 46, 26, 435, DateTimeKind.Local).AddTicks(2370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 17, 14, 2, 128, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "Prize",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 17, 46, 26, 435, DateTimeKind.Local).AddTicks(3290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "SelectedPrize",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 17, 46, 26, 435, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 17, 14, 2, 128, DateTimeKind.Local).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 17, 46, 26, 435, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "Prize",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 17, 46, 26, 435, DateTimeKind.Local).AddTicks(3290));
        }
    }
}
