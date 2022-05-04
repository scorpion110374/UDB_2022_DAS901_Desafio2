using Microsoft.EntityFrameworkCore.Migrations;

namespace DAS901_Desafio2.Migrations
{
    public partial class IdGeneroagregadoapelicula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Peliculas");

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Peliculas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdGenero",
                table: "Peliculas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdGenero",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdGenero",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdGenero",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "IdGenero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                column: "IdGenero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                column: "IdGenero",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                column: "IdGenero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8,
                column: "IdGenero",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                column: "IdGenero",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                column: "IdGenero",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11,
                column: "IdGenero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12,
                column: "IdGenero",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13,
                column: "IdGenero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14,
                column: "IdGenero",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15,
                column: "IdGenero",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_GeneroId",
                table: "Peliculas",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Generos_GeneroId",
                table: "Peliculas",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Generos_GeneroId",
                table: "Peliculas");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_GeneroId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "IdGenero",
                table: "Peliculas");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Peliculas",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genero",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Genero",
                value: "2,3");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Genero",
                value: "4,6");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Genero",
                value: "1,2,4");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                column: "Genero",
                value: "1,2,3");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Genero",
                value: "2,7");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Genero",
                value: "1,2,3");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 8,
                column: "Genero",
                value: "2,7");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Genero",
                value: "8");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Genero",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 11,
                column: "Genero",
                value: "1,6");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 12,
                column: "Genero",
                value: "9");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 13,
                column: "Genero",
                value: "1,6");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Genero",
                value: "4,5");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 15,
                column: "Genero",
                value: "1,2");
        }
    }
}
