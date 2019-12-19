using Microsoft.EntityFrameworkCore.Migrations;

namespace eternalminerals.Migrations
{
    public partial class UpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Tektites",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Tektites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Tektites",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sku",
                table: "Tektites",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Stocked",
                table: "Tektites",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Tektites");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tektites");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Tektites");

            migrationBuilder.DropColumn(
                name: "Sku",
                table: "Tektites");

            migrationBuilder.DropColumn(
                name: "Stocked",
                table: "Tektites");
        }
    }
}
