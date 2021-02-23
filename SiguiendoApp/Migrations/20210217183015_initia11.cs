using Microsoft.EntityFrameworkCore.Migrations;

namespace SiguiendoApp.Migrations
{
    public partial class initia11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alturo",
                table: "Artista");

            migrationBuilder.RenameColumn(
                name: "LugardeNacimiento",
                table: "Artista",
                newName: "FechadeNacimiento");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Artista",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Artista");

            migrationBuilder.RenameColumn(
                name: "FechadeNacimiento",
                table: "Artista",
                newName: "LugardeNacimiento");

            migrationBuilder.AddColumn<double>(
                name: "Alturo",
                table: "Artista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
