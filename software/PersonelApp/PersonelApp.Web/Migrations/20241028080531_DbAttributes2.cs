using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    public partial class DbAttributes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Kurslar",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Kurslar",
                type: "nvarchar(max)",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Dersler",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Dersler",
                type: "nvarchar(max)",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldRowVersion: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Link",
                table: "Kurslar",
                type: "int",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "Date",
                table: "Kurslar",
                type: "int",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<int>(
                name: "Link",
                table: "Dersler",
                type: "int",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "Date",
                table: "Dersler",
                type: "int",
                rowVersion: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldRowVersion: true);
        }
    }
}
