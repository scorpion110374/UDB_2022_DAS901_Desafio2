using Microsoft.EntityFrameworkCore.Migrations;

namespace DAS901_Desafio2.Migrations
{
    public partial class CalificacionAgregarCampoPuntuacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Puntuacion",
                table: "Peliculas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Puntuacion",
                table: "Peliculas");
        }
    }
}
