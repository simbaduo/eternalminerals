using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eternalminerals.Migrations
{
    public partial class DateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Stocked",
                table: "Tektites",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Stocked",
                table: "Tektites",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
