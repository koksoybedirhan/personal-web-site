using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class homedb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Home",
                newName: "Link3");

            migrationBuilder.AddColumn<string>(
                name: "Link1",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Link2",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link1",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Link2",
                table: "Home");

            migrationBuilder.RenameColumn(
                name: "Link3",
                table: "Home",
                newName: "Link");
        }
    }
}
