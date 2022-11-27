using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class addsometables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SkillType",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 180, DateTimeKind.Utc).AddTicks(3425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 26, 14, 8, 39, 131, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 171, DateTimeKind.Utc).AddTicks(7073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 26, 14, 8, 39, 122, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.AddColumn<string>(
                name: "BackgroundLevel",
                table: "Backgrounds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 27, 16, 27, 43, 168, DateTimeKind.Local).AddTicks(1853));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillType",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "BackgroundLevel",
                table: "Backgrounds");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 26, 14, 8, 39, 131, DateTimeKind.Utc).AddTicks(4516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 180, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 26, 14, 8, 39, 122, DateTimeKind.Utc).AddTicks(193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 171, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 26, 18, 8, 39, 118, DateTimeKind.Local).AddTicks(9531));
        }
    }
}
