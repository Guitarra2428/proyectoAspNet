using Microsoft.EntityFrameworkCore.Migrations;

namespace SiguiendoApp.Migrations
{
    public partial class actualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albun_Artista_ArtistaIdArtista",
                table: "Albun");

            migrationBuilder.DropIndex(
                name: "IX_Albun_ArtistaIdArtista",
                table: "Albun");

            migrationBuilder.DropColumn(
                name: "ArtistaIdArtista",
                table: "Albun");

            migrationBuilder.RenameColumn(
                name: "IdArtista",
                table: "Albun",
                newName: "ArtistaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Genero",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Artista",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidad",
                table: "Artista",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Albun",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albun_ArtistaId",
                table: "Albun",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albun_Artista_ArtistaId",
                table: "Albun",
                column: "ArtistaId",
                principalTable: "Artista",
                principalColumn: "IdArtista",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albun_Artista_ArtistaId",
                table: "Albun");

            migrationBuilder.DropIndex(
                name: "IX_Albun_ArtistaId",
                table: "Albun");

            migrationBuilder.RenameColumn(
                name: "ArtistaId",
                table: "Albun",
                newName: "IdArtista");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Genero",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Artista",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidad",
                table: "Artista",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Albun",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ArtistaIdArtista",
                table: "Albun",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albun_ArtistaIdArtista",
                table: "Albun",
                column: "ArtistaIdArtista");

            migrationBuilder.AddForeignKey(
                name: "FK_Albun_Artista_ArtistaIdArtista",
                table: "Albun",
                column: "ArtistaIdArtista",
                principalTable: "Artista",
                principalColumn: "IdArtista",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
