using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class onetomanycitypeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Cities",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryName",
                table: "Cities",
                column: "CountryName");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryName",
                table: "Cities",
                column: "CountryName",
                principalTable: "Countries",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryName",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryName",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Cities");
        }
    }
}
