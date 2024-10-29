using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class updateDerslerAyrinti2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "Semestr",
                table: "Dersler");

            migrationBuilder.AddColumn<string>(
                name: "DersImg",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "DersAyrintilar",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Semestr",
                table: "DersAyrintilar",
                type: "int",
                maxLength: 3,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DersImg",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "Semestr",
                table: "DersAyrintilar");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Dersler",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Semestr",
                table: "Dersler",
                type: "int",
                maxLength: 3,
                nullable: false,
                defaultValue: 0);
        }
    }
}
