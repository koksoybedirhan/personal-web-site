using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class addAdminSchema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KurslarModel",
                table: "KurslarModel");

            migrationBuilder.RenameTable(
                name: "KurslarModel",
                newName: "Kurslar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kurslar",
                table: "Kurslar",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departmant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitHub = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kurslar",
                table: "Kurslar");

            migrationBuilder.RenameTable(
                name: "Kurslar",
                newName: "KurslarModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KurslarModel",
                table: "KurslarModel",
                column: "Id");
        }
    }
}
