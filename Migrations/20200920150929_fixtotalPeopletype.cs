using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoAPI.Migrations
{
    public partial class fixtotalPeopletype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TotalPeople",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalPeople",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
