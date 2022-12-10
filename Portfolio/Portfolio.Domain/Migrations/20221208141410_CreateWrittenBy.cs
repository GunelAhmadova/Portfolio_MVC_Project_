using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Domain.Migrations
{
    public partial class CreateWrittenBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 14, 9, 993, DateTimeKind.Utc).AddTicks(3250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 2, 13, 9, 29, 726, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 14, 9, 983, DateTimeKind.Utc).AddTicks(3202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 2, 13, 9, 29, 722, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.AddColumn<string>(
                name: "WrittenBy",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 18, 14, 9, 978, DateTimeKind.Local).AddTicks(5942));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WrittenBy",
                table: "BlogPosts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 13, 9, 29, 726, DateTimeKind.Utc).AddTicks(63),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 14, 9, 993, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 2, 13, 9, 29, 722, DateTimeKind.Utc).AddTicks(1222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 14, 9, 983, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 2, 17, 9, 29, 720, DateTimeKind.Local).AddTicks(1866));
        }
    }
}
