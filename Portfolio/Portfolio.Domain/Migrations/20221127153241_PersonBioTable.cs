using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class PersonBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 27, 15, 32, 41, 138, DateTimeKind.Utc).AddTicks(4745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 180, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 27, 15, 32, 41, 127, DateTimeKind.Utc).AddTicks(6245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 171, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 27, 19, 32, 41, 124, DateTimeKind.Local).AddTicks(3772));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "People");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 180, DateTimeKind.Utc).AddTicks(3425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 27, 15, 32, 41, 138, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 27, 12, 27, 43, 171, DateTimeKind.Utc).AddTicks(7073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 27, 15, 32, 41, 127, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 27, 16, 27, 43, 168, DateTimeKind.Local).AddTicks(1853));
        }
    }
}
