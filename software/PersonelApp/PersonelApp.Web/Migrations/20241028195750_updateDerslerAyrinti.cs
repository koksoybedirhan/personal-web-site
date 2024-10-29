using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class updateDerslerAyrinti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content1",
                table: "Kurslar");

            migrationBuilder.DropColumn(
                name: "Content1",
                table: "Dersler");

            migrationBuilder.RenameColumn(
                name: "Content2",
                table: "Kurslar",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Content2",
                table: "Dersler",
                newName: "Content");

            migrationBuilder.CreateTable(
                name: "DersAyrintilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersAyrintilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DersAyrintilar_Dersler_DersId",
                        column: x => x.DersId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersAyrintilar_DersId",
                table: "DersAyrintilar",
                column: "DersId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersAyrintilar");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Kurslar",
                newName: "Content2");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Dersler",
                newName: "Content2");

            migrationBuilder.AddColumn<string>(
                name: "Content1",
                table: "Kurslar",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content1",
                table: "Dersler",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
