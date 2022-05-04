using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAS901_Desafio2.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGenero = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Director = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Reparto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Genero = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Sinopsis = table.Column<string>(type: "text", nullable: false),
                    Trailer = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FechaEstreno = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cartelera = table.Column<bool>(type: "bit", nullable: false),
                    Estreno = table.Column<bool>(type: "bit", nullable: false),
                    Proximamente = table.Column<bool>(type: "bit", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPelicula = table.Column<int>(type: "int", nullable: false),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalificacionPelicula = table.Column<int>(type: "int", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "NombreGenero" },
                values: new object[,]
                {
                    { 1, "Acción" },
                    { 2, "Aventura" },
                    { 3, "Comedia" },
                    { 4, "Drama" },
                    { 5, "Romance" },
                    { 6, "Suspenso" },
                    { 7, "Fantasía" },
                    { 8, "Concierto" },
                    { 9, "Documental" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "Activa", "Calificacion", "Cartelera", "Director", "Estreno", "FechaEstreno", "Genero", "Nombre", "Proximamente", "Reparto", "Sinopsis", "Trailer" },
                values: new object[,]
                {
                    { 13, true, 0, false, "Martin Campbell", false, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "1,6", "Asesino sin Memoria", true, "Liam Neeson, Guy Pearce, Monica Bellucci, Taj Atwal", "Alex Lewis es un experto asesino con una reputacion de discreta precision. Cuando Alex se niega a completar un trabajo para una peligrosa organizacion criminal, se convierte en un objetivo y debe ir a la caza de quienes lo quieren muerto.", "https://www.youtube.com/watch?v=gUMaCiHNZw0" },
                    { 12, true, 0, false, "Celina Escher", false, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "9", "Nuestra Libertad", true, "Teodora Vásquez", "Despues de cumplir diez anios tras las rejas por su aborto espontaneo, considerado por su gobierno como un acto de homicidio agravado, Teodora Vasquez se convierte en portavoz de las otras 16 mujeres salvadorenas tras las rejas por el mismo delito.", "https://www.youtube.com/watch?v=R5keA5nF-TI" },
                    { 11, true, 0, false, "Martin Campbell", false, new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "1,6", "El Protegido", true, "Maggie Q, Michael Keaton, Samuel L. Jackson, Robert Patrick", "Rescatada de nina por el legendario asesino Moody, Anna es la asesina a sueldo mas habil del mundo. Sin embargo, cuando Moody es brutalmente asesinado, ella jura venganza por el hombre que le enseno todo lo que sabe.", "https://youtu.be/SGJ8cOWnqHw" },
                    { 10, true, 0, false, "Andrew Levitas", false, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", "El Fotógrafo de Minamata", true, "Johnny Depp, Bill Nighy, Hiroyuki Sanada", "El fotografo de guerra W Eugene Smith viaja a Japon para documentar el envenenamiento por mercurio de comunidades costeras enteras.", "https://www.youtube.com/watch?v=QEfGnm_72OQ" },
                    { 9, true, 0, false, "Jason Zada", false, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "8", "Twenty One Pilots Cinema Experience", true, "Tyler ,Josh", "Experimenta la epica celebracion del lanzamiento del album Scaled And Icyde 2021, remasterizado para la gran pantalla y con material inedito.", "https://www.youtube.com/watch?v=23gp-Sf1Oo8" },
                    { 8, true, 0, true, "Sam Raimi", true, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "2,7", "Doctor Strange 2", false, "Benedict ,Chiwetel ,Elizabeth", "Doctor Strange con la ayuda de aliados misticos nuevos y otros ya conocidos por la audiencia, atraviesa las alucinantes y peligrosas realidades alternativas del Multiverso para enfrentarse a un nuevo y misterioso adversario.", "https://youtu.be/cFHjZfy50Kk" },
                    { 3, true, 0, true, "Phillip Noyce", false, null, "4,6", "Desesperada", false, "Naomi ,Phillip ,Colton ,Sierra", "Una madre corre desesperadamente contra el tiempo para salvar a su hijo mientras las autoridades cierran su pequenio pueblo.", "https://youtu.be/5Ca1mXFv2Fc" },
                    { 6, true, 0, true, "David Yates", false, null, "2,7", "Animales Fantasticos 3", false, "Mads,Jude ,Ezra", "Albus Dumbledore sabe que el mago oscuro Gellert quiere apoderarse del mundo magico. Como no puede detenerlo solo, le pide al magizoologo Newt Scamander que lidere un grupo de magos, brujas y un valiente panadero muggle hacia una peligrosa mision.", "https://youtu.be/QfYgcLuxS5Y" },
                    { 5, true, 0, true, "Aaron Nee", false, null, "1,2,3", "La Ciudad Perdida", false, "Sandra ,Channing ,Daniel", "Una novelista romantica solitaria en una gira de libros junto con su modelo de portada se ve envuelta en un intento de secuestro que los lleva a ambos a una feroz aventura en la jungla.", "https://youtu.be/Jhl2v32cKzc" },
                    { 4, true, 0, true, "Robert Eggers", false, null, "1,2,4", "El Hombre del Norte", false, "Nicole,Anya ,Akexander", "El visionario director Robert Eggers presenta EL HOMBRE DEL NORTE, una epica aventura llena de accion que narra la busqueda de un joven principe vikingo por vengar el asesinato de su padre.", "https://youtu.be/_fpTJaHOwbw" },
                    { 14, true, 0, false, "Simon Curtis", false, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "4,5", "Downton Abbey Una Nueva Era", true, "Hugh Bonneville, Michelle Dockery, Imelda Staunton", "La secuela de la pelicula de 2019 en la que la familia Crawley y el personal de Downton recibieron la visita real del Rey y la Reina de Gran Bretana.", "https://www.youtube.com/watch?v=LHZDzAq9yZ8" },
                    { 2, true, 0, true, "David Moreau", false, null, "2,3", "King Regreso a Casa", false, "Gerard ,Lou ,Leo", "King, un cachorro de leon traficado, escapa del aeropuerto en pleno transito y encuentra refugio en la casa de Ines y Alex, de 12 y 15 anios. A los hermanos se les ocurre un loco plan traer a King de vuelta a Africa.", "https://youtu.be/EC7Cm6kSFT4" },
                    { 1, true, 0, true, "Brenda Vanegas", false, null, "4", "Antes la lluvia", false, "Patricia ,Isabel ,Inma", "Es la historia de dos mujeres. Maria es una migrante salvadorena que pierde su trabajo tras enfermar y ademas esta terminando una relacion dolorosa. Esther, una mujer mayor que padece alzheimer, esta perdiendo la memoria, y los recuerdos importantes.", "https://www.youtube.com/watch?v=w9djCCDhnVI" },
                    { 7, true, 0, true, "Jeff Fowler", false, null, "1,2,3", "Sonic 2 La Pelicula", false, "Idris ,Ben ,Colleen", "Despues de establecerse en Green Hills, Sonic esta listo para tener mas libertad, asi que Tom y Maddie lo dejan solo en casa mientras se van de vacaciones. Pero apenas se han ido, el Dr. Robotnik regresa, esta vez con un nuevo aliado, Knuckles.", "https://youtu.be/ahVkLQKoLFw" },
                    { 15, true, 0, false, "Joseph Kosinski", false, new DateTime(2022, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "1,2", "Top Gun Maverick", true, "Tom Cruise, Val Kilmer, Miles Teller, Jennifer Connelly, Glen Powell", "Despues de mas de 30 anios de servicio como uno de los mejores aviadores de la Armada, Pete Maverick Mitchell esta donde pertenece, forzando los limites como valiente piloto de pruebas y esquivando el avance de rango que lo dejaria en tierra.", "https://youtu.be/zzBIzYmxatU" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_PeliculaId",
                table: "Calificaciones",
                column: "PeliculaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}
