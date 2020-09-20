using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoAPI.Migrations
{
    public partial class SubMenuUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "SubMenus",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SubMenus");
        }
    }
}
