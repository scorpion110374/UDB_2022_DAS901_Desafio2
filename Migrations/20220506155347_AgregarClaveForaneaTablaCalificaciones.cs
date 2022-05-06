using Microsoft.EntityFrameworkCore.Migrations;

namespace DAS901_Desafio2.Migrations
{
    public partial class AgregarClaveForaneaTablaCalificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Peliculas_PeliculaId",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_PeliculaId",
                table: "Calificaciones");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Calificaciones");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_IdPelicula",
                table: "Calificaciones",
                column: "IdPelicula");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Peliculas_IdPelicula",
                table: "Calificaciones",
                column: "IdPelicula",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calificaciones_Peliculas_IdPelicula",
                table: "Calificaciones");

            migrationBuilder.DropIndex(
                name: "IX_Calificaciones_IdPelicula",
                table: "Calificaciones");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Calificaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_PeliculaId",
                table: "Calificaciones",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calificaciones_Peliculas_PeliculaId",
                table: "Calificaciones",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
