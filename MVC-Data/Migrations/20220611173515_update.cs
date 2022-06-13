using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Langs_People_PersonName",
                table: "Langs");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityName",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonLanguages_Langs_LanguageName",
                table: "PersonLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonLanguages",
                table: "PersonLanguages");

            migrationBuilder.DropIndex(
                name: "IX_Langs_PersonName",
                table: "Langs");

            migrationBuilder.DropColumn(
                name: "PersonName",
                table: "Langs");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageName",
                table: "PersonLanguages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "People",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonLanguages",
                table: "PersonLanguages",
                column: "PersonName");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityName",
                table: "People",
                column: "CityName",
                principalTable: "Cities",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonLanguages_Langs_LanguageName",
                table: "PersonLanguages",
                column: "LanguageName",
                principalTable: "Langs",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityName",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonLanguages_Langs_LanguageName",
                table: "PersonLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonLanguages",
                table: "PersonLanguages");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageName",
                table: "PersonLanguages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "People",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonName",
                table: "Langs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonLanguages",
                table: "PersonLanguages",
                columns: new[] { "PersonName", "LanguageName" });

            migrationBuilder.CreateIndex(
                name: "IX_Langs_PersonName",
                table: "Langs",
                column: "PersonName");

            migrationBuilder.AddForeignKey(
                name: "FK_Langs_People_PersonName",
                table: "Langs",
                column: "PersonName",
                principalTable: "People",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Cities_CityName",
                table: "People",
                column: "CityName",
                principalTable: "Cities",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonLanguages_Langs_LanguageName",
                table: "PersonLanguages",
                column: "LanguageName",
                principalTable: "Langs",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
