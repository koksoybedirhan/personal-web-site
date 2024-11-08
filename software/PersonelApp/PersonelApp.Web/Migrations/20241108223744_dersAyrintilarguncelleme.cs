using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class dersAyrintilarguncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DersImg",
                table: "DersAyrintilar",
                newName: "DersTitle3");

            migrationBuilder.AddColumn<string>(
                name: "DersContent1",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersContent2",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersContent3",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersImg1",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersImg2",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersImg3",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersLink1",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersLink2",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersLink3",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersTitle1",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DersTitle2",
                table: "DersAyrintilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DersContent1",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersContent2",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersContent3",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersImg1",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersImg2",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersImg3",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersLink1",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersLink2",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersLink3",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersTitle1",
                table: "DersAyrintilar");

            migrationBuilder.DropColumn(
                name: "DersTitle2",
                table: "DersAyrintilar");

            migrationBuilder.RenameColumn(
                name: "DersTitle3",
                table: "DersAyrintilar",
                newName: "DersImg");
        }
    }
}
