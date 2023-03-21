using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRon.Migrations
{
    /// <inheritdoc />
    public partial class selectedprizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 17, 14, 2, 128, DateTimeKind.Local).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 16, 41, 20, 643, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.CreateTable(
                name: "SelectedPrize",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedPrize", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedPrize");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 16, 41, 20, 643, DateTimeKind.Local).AddTicks(3170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 17, 14, 2, 128, DateTimeKind.Local).AddTicks(8230));
        }
    }
}
