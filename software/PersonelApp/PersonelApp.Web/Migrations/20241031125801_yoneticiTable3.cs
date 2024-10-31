using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class yoneticiTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content3",
                table: "Yonetici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content4",
                table: "Yonetici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content5",
                table: "Yonetici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content6",
                table: "Yonetici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content3",
                table: "Yonetici");

            migrationBuilder.DropColumn(
                name: "Content4",
                table: "Yonetici");

            migrationBuilder.DropColumn(
                name: "Content5",
                table: "Yonetici");

            migrationBuilder.DropColumn(
                name: "Content6",
                table: "Yonetici");
        }
    }
}
