using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAS901_Desafio2.Migrations
{
    public partial class agregarTablaContacto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Asunto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Mensaje = table.Column<string>(type: "text", nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_IdGenero",
                table: "Peliculas",
                column: "IdGenero");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Generos_IdGenero",
                table: "Peliculas",
                column: "IdGenero",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Generos_IdGenero",
                table: "Peliculas");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_IdGenero",
                table: "Peliculas");

            migrationBuilder.AddColumn<int>(
                name: "GeneroId",
                table: "Peliculas",
                type: "int",
                nullable: true);

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
    }
}
