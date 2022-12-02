using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class membe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 11, 32, 3, 558, DateTimeKind.Utc).AddTicks(1652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 2, 0, 37, 48, 179, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 11, 32, 3, 554, DateTimeKind.Utc).AddTicks(1371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 2, 0, 37, 48, 175, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 2, 15, 32, 3, 551, DateTimeKind.Local).AddTicks(7324));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 0, 37, 48, 179, DateTimeKind.Utc).AddTicks(3507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 2, 11, 32, 3, 558, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 0, 37, 48, 175, DateTimeKind.Utc).AddTicks(4471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 2, 11, 32, 3, 554, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 2, 4, 37, 48, 173, DateTimeKind.Local).AddTicks(2930));
        }
    }
}
