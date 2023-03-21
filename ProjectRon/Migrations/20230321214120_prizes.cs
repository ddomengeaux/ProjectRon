using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectRon.Migrations
{
    /// <inheritdoc />
    public partial class prizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 21, 16, 41, 20, 643, DateTimeKind.Local).AddTicks(3170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 6, 18, 53, 57, 945, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.CreateTable(
                name: "NewTable",
                columns: table => new
                {
                    column_1 = table.Column<int>(type: "int", nullable: false),
                    column_2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    column_3 = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewTable", x => x.column_1);
                });

            migrationBuilder.CreateTable(
                name: "Prize",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prize", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewTable");

            migrationBuilder.DropTable(
                name: "Prize");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated",
                table: "QRCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 3, 6, 18, 53, 57, 945, DateTimeKind.Local).AddTicks(7540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 3, 21, 16, 41, 20, 643, DateTimeKind.Local).AddTicks(3170));
        }
    }
}
