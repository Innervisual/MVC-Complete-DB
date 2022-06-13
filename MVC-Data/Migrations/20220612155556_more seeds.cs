using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class moreseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Name", "CountryName" },
                values: new object[,]
                {
                    { "Paris", null },
                    { "Berlin", null },
                    { "Madrid", null },
                    { "Lissabon", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                column: "Name",
                values: new object[]
                {
                    "France",
                    "Germany",
                    "Spain",
                    "Portugal"
                });

            migrationBuilder.InsertData(
                table: "Langs",
                column: "Name",
                values: new object[]
                {
                    "French",
                    "German",
                    "Spanish",
                    "Portugese"
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Name", "CityName", "Id", "PhoneNumber" },
                values: new object[,]
                {
                    { "Stefan", null, 3, 333 },
                    { "Ian", null, 4, 444 },
                    { "George", null, 5, 555 },
                    { "Svante", null, 6, 666 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Name",
                keyValue: "Berlin");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Name",
                keyValue: "Lissabon");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Name",
                keyValue: "Madrid");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Name",
                keyValue: "Paris");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "France");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Germany");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Portugal");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Name",
                keyValue: "Spain");

            migrationBuilder.DeleteData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "French");

            migrationBuilder.DeleteData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "German");

            migrationBuilder.DeleteData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Portugese");

            migrationBuilder.DeleteData(
                table: "Langs",
                keyColumn: "Name",
                keyValue: "Spanish");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "George");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Ian");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Stefan");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Name",
                keyValue: "Svante");
        }
    }
}
