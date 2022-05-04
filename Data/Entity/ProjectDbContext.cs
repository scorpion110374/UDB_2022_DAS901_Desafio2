using DAS901_Desafio2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAS901_Desafio2.Data.Entity
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        //Entities
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Llenar datos iniciales a tabla Generos
            modelBuilder.Entity<Genero>()
                .HasData(
                new Genero()
                {
                    Id = 1,
                    NombreGenero = "Acción"
                },
                new Genero()
                {
                    Id = 2,
                    NombreGenero = "Aventura"
                },
                new Genero()
                {
                    Id = 3,
                    NombreGenero = "Comedia"
                },
                new Genero()
                {
                    Id = 4,
                    NombreGenero = "Drama"
                },
                new Genero()
                {
                    Id = 5,
                    NombreGenero = "Romance"
                },
                new Genero()
                {
                    Id = 6,
                    NombreGenero = "Suspenso"
                },
                new Genero()
                {
                    Id = 7,
                    NombreGenero = "Fantasía"
                },
                new Genero()
                {
                    Id = 8,
                    NombreGenero = "Concierto"
                },
                new Genero()
                {
                    Id = 9,
                    NombreGenero = "Documental"
                }
                );

            //Llenar datos iniciales a tabla Peliculas
            modelBuilder.Entity<Pelicula>()
                .HasData(
                new Pelicula()
                {
                    Id = 1,
                    Nombre= "Antes la lluvia",
                    Director= "Brenda Vanegas",
                    Reparto= "Patricia ,Isabel ,Inma",
                    IdGenero=4,
                    Sinopsis= "Es la historia de dos mujeres. Maria es una migrante salvadorena que pierde su trabajo tras enfermar y ademas esta terminando una relacion dolorosa. Esther, una mujer mayor que padece alzheimer, esta perdiendo la memoria, y los recuerdos importantes.",
                    Trailer= "https://www.youtube.com/watch?v=w9djCCDhnVI",
                    FechaEstreno=null,
                    Cartelera=true,
                    Estreno=false,
                    Proximamente=false,
                    Calificacion=0,
                    Activa=true
                },
                new Pelicula()
                {
                    Id = 2,
                    Nombre = "King Regreso a Casa",
                    Director = "David Moreau",
                    Reparto = "Gerard ,Lou ,Leo",
                    IdGenero = 2,
                    Sinopsis = "King, un cachorro de leon traficado, escapa del aeropuerto en pleno transito y encuentra refugio en la casa de Ines y Alex, de 12 y 15 anios. A los hermanos se les ocurre un loco plan traer a King de vuelta a Africa.",
                    Trailer = "https://youtu.be/EC7Cm6kSFT4",
                    FechaEstreno = null,
                    Cartelera = true,
                    Estreno = false,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 3,
                    Nombre = "Desesperada",
                    Director = "Phillip Noyce",
                    Reparto = "Naomi ,Phillip ,Colton ,Sierra",
                    IdGenero = 4,
                    Sinopsis = "Una madre corre desesperadamente contra el tiempo para salvar a su hijo mientras las autoridades cierran su pequenio pueblo.",
                    Trailer = "https://youtu.be/5Ca1mXFv2Fc",
                    FechaEstreno = null,
                    Cartelera = true,
                    Estreno = false,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 4,
                    Nombre = "El Hombre del Norte",
                    Director = "Robert Eggers",
                    Reparto = "Nicole,Anya ,Akexander",
                    IdGenero = 1,
                    Sinopsis = "El visionario director Robert Eggers presenta EL HOMBRE DEL NORTE, una epica aventura llena de accion que narra la busqueda de un joven principe vikingo por vengar el asesinato de su padre.",
                    Trailer = "https://youtu.be/_fpTJaHOwbw",
                    FechaEstreno = null,
                    Cartelera = true,
                    Estreno = false,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 5,
                    Nombre = "La Ciudad Perdida",
                    Director = "Aaron Nee",
                    Reparto = "Sandra ,Channing ,Daniel",
                    IdGenero = 1,
                    Sinopsis = "Una novelista romantica solitaria en una gira de libros junto con su modelo de portada se ve envuelta en un intento de secuestro que los lleva a ambos a una feroz aventura en la jungla.",
                    Trailer = "https://youtu.be/Jhl2v32cKzc",
                    FechaEstreno = null,
                    Cartelera = true,
                    Estreno = false,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 6,
                    Nombre = "Animales Fantasticos 3",
                    Director = "David Yates",
                    Reparto = "Mads,Jude ,Ezra",
                    IdGenero = 2,
                    Sinopsis = "Albus Dumbledore sabe que el mago oscuro Gellert quiere apoderarse del mundo magico. Como no puede detenerlo solo, le pide al magizoologo Newt Scamander que lidere un grupo de magos, brujas y un valiente panadero muggle hacia una peligrosa mision.",
                    Trailer = "https://youtu.be/QfYgcLuxS5Y",
                    FechaEstreno = null,
                    Cartelera = true,
                    Estreno = false,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 7,
                    Nombre = "Sonic 2 La Pelicula",
                    Director = "Jeff Fowler",
                    Reparto = "Idris ,Ben ,Colleen",
                    IdGenero = 1,
                    Sinopsis = "Despues de establecerse en Green Hills, Sonic esta listo para tener mas libertad, asi que Tom y Maddie lo dejan solo en casa mientras se van de vacaciones. Pero apenas se han ido, el Dr. Robotnik regresa, esta vez con un nuevo aliado, Knuckles.",
                    Trailer = "https://youtu.be/ahVkLQKoLFw",
                    FechaEstreno = null,
                    Cartelera = true,
                    Estreno = false,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 8,
                    Nombre = "Doctor Strange 2",
                    Director = "Sam Raimi",
                    Reparto = "Benedict ,Chiwetel ,Elizabeth",
                    IdGenero = 2,
                    Sinopsis = "Doctor Strange con la ayuda de aliados misticos nuevos y otros ya conocidos por la audiencia, atraviesa las alucinantes y peligrosas realidades alternativas del Multiverso para enfrentarse a un nuevo y misterioso adversario.",
                    Trailer = "https://youtu.be/cFHjZfy50Kk",
                    FechaEstreno = Convert.ToDateTime("2022-05-04"),
                    Cartelera = true,
                    Estreno = true,
                    Proximamente = false,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 9,
                    Nombre = "Twenty One Pilots Cinema Experience",
                    Director = "Jason Zada",
                    Reparto = "Tyler ,Josh",
                    IdGenero = 8,
                    Sinopsis = "Experimenta la epica celebracion del lanzamiento del album Scaled And Icyde 2021, remasterizado para la gran pantalla y con material inedito.",
                    Trailer = "https://www.youtube.com/watch?v=23gp-Sf1Oo8",
                    FechaEstreno = Convert.ToDateTime("2022-05-19"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 10,
                    Nombre = "El Fotógrafo de Minamata",
                    Director = "Andrew Levitas",
                    Reparto = "Johnny Depp, Bill Nighy, Hiroyuki Sanada",
                    IdGenero = 4,
                    Sinopsis = "El fotografo de guerra W Eugene Smith viaja a Japon para documentar el envenenamiento por mercurio de comunidades costeras enteras.",
                    Trailer = "https://www.youtube.com/watch?v=QEfGnm_72OQ",
                    FechaEstreno = Convert.ToDateTime("2022-05-05"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 11,
                    Nombre = "El Protegido",
                    Director = "Martin Campbell",
                    Reparto = "Maggie Q, Michael Keaton, Samuel L. Jackson, Robert Patrick",
                    IdGenero = 1,
                    Sinopsis = "Rescatada de nina por el legendario asesino Moody, Anna es la asesina a sueldo mas habil del mundo. Sin embargo, cuando Moody es brutalmente asesinado, ella jura venganza por el hombre que le enseno todo lo que sabe.",
                    Trailer = "https://youtu.be/SGJ8cOWnqHw",
                    FechaEstreno = Convert.ToDateTime("2022-05-12"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 12,
                    Nombre = "Nuestra Libertad",
                    Director = "Celina Escher",
                    Reparto = "Teodora Vásquez",
                    IdGenero = 9,
                    Sinopsis = "Despues de cumplir diez anios tras las rejas por su aborto espontaneo, considerado por su gobierno como un acto de homicidio agravado, Teodora Vasquez se convierte en portavoz de las otras 16 mujeres salvadorenas tras las rejas por el mismo delito.",
                    Trailer = "https://www.youtube.com/watch?v=R5keA5nF-TI",
                    FechaEstreno = Convert.ToDateTime("2022-05-19"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 13,
                    Nombre = "Asesino sin Memoria",
                    Director = "Martin Campbell",
                    Reparto = "Liam Neeson, Guy Pearce, Monica Bellucci, Taj Atwal",
                    IdGenero = 1,
                    Sinopsis = "Alex Lewis es un experto asesino con una reputacion de discreta precision. Cuando Alex se niega a completar un trabajo para una peligrosa organizacion criminal, se convierte en un objetivo y debe ir a la caza de quienes lo quieren muerto.",
                    Trailer = "https://www.youtube.com/watch?v=gUMaCiHNZw0",
                    FechaEstreno = Convert.ToDateTime("2022-05-19"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 14,
                    Nombre = "Downton Abbey Una Nueva Era",
                    Director = "Simon Curtis",
                    Reparto = "Hugh Bonneville, Michelle Dockery, Imelda Staunton",
                    IdGenero = 4,
                    Sinopsis = "La secuela de la pelicula de 2019 en la que la familia Crawley y el personal de Downton recibieron la visita real del Rey y la Reina de Gran Bretana.",
                    Trailer = "https://www.youtube.com/watch?v=LHZDzAq9yZ8",
                    FechaEstreno = Convert.ToDateTime("2022-05-19"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                },
                new Pelicula()
                {
                    Id = 15,
                    Nombre = "Top Gun Maverick",
                    Director = "Joseph Kosinski",
                    Reparto = "Tom Cruise, Val Kilmer, Miles Teller, Jennifer Connelly, Glen Powell",
                    IdGenero = 1,
                    Sinopsis = "Despues de mas de 30 anios de servicio como uno de los mejores aviadores de la Armada, Pete Maverick Mitchell esta donde pertenece, forzando los limites como valiente piloto de pruebas y esquivando el avance de rango que lo dejaria en tierra.",
                    Trailer = "https://youtu.be/zzBIzYmxatU",
                    FechaEstreno = Convert.ToDateTime("2022-05-26"),
                    Cartelera = false,
                    Estreno = false,
                    Proximamente = true,
                    Calificacion = 0,
                    Activa = true
                }
                );
        }
    }
}
