using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class DbAttributes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Kurslar",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Dersler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldRowVersion: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Kurslar",
                type: "nvarchar(max)",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Dersler",
                type: "nvarchar(max)",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
