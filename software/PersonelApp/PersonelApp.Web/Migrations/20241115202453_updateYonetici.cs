using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class updateYonetici : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Yonetici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Yonetici");
        }
    }
}
