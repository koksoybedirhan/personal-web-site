using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class addAdminSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
