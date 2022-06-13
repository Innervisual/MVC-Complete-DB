using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                column: "Name",
                value: "London");

            migrationBuilder.InsertData(
                table: "Countries",
                column: "Name",
                value: "England");

            migrationBuilder.InsertData(
                table: "Langs",
                column: "Name",
                values: new object[]
                {
                    "English",
                    "Swedish"
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Name", "CityName", "Id", "PhoneNumber" },
                values: new object[,]
                {
                    { "JP", null, 1, 111 },
                    { "Anders", null, 2, 222 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Name",
                keyValue: "London");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "England");

            migrationBuilder.DeleteData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "English");

            migrationBuilder.DeleteData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Swedish");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Anders");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "JP");
        }
    }
}
