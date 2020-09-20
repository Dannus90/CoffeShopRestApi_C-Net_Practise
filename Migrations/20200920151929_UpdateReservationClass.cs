using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressoAPI.Migrations
{
    public partial class UpdateReservationClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalPeople",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TotalPeople",
                table: "Reservations",
                type: "text",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
