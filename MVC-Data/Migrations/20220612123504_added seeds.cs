using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class addedseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                column: "Name",
                value: "Stockholm");

            migrationBuilder.InsertData(
                table: "Countries",
                column: "Name",
                value: "Sweden");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Name",
                keyValue: "Stockholm");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Sweden");
        }
    }
}
