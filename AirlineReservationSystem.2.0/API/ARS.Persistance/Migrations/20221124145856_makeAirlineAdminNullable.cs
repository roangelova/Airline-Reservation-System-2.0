using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ARS.Persistance.Migrations
{
    public partial class makeAirlineAdminNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airlines_AspNetUsers_AdminId",
                table: "Airlines");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdminId",
                table: "Airlines",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Airlines_AspNetUsers_AdminId",
                table: "Airlines",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airlines_AspNetUsers_AdminId",
                table: "Airlines");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdminId",
                table: "Airlines",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Airlines_AspNetUsers_AdminId",
                table: "Airlines",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
