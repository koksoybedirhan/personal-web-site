using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class yoneticiTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yonetici",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<int>(type: "int", nullable: false),
                    Departmant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content1 = table.Column<int>(type: "int", nullable: false),
                    Content2 = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<int>(type: "int", nullable: false),
                    Linkedin = table.Column<int>(type: "int", nullable: false),
                    Github = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetici", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yonetici");
        }
    }
}
