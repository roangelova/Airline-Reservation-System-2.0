using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ARS.Persistance.Migrations
{
    public partial class addAirlineTypeToAirlines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirlineType",
                table: "Airlines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AirlineType",
                table: "Airlines");
        }
    }
}
