using DAS901_Desafio2.Data.Entity;
using DAS901_Desafio2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using X.PagedList;

namespace DAS901_Desafio2.Controllers
{
    public class PeliculasController : Controller
    {

        private readonly ProjectDbContext _db;

        public PeliculasController(ProjectDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? buscadorGenero=0, int? page=1, string buscadorNombre=null)
        {
            var pageNumber = page ?? 1;
            int pageSize = 6;
            dynamic peliculas;

            //Listar películas para el grid
            //Filtrar productos si buscador viene con valor o es nulo
            if (buscadorGenero != 0 || buscadorNombre != null)
            {
                peliculas = _db.Peliculas.Include(g => g.Genero).Where( i => i.IdGenero == buscadorGenero || i.Nombre.Contains(buscadorNombre)).ToPagedList(pageNumber, pageSize);
            }
            else
            {
                peliculas = _db.Peliculas.Include(g => g.Genero).ToPagedList(pageNumber, pageSize);
            }

            //Listar generos
            var listaGeneros = _db.Generos.OrderBy(n => n.NombreGenero).ToList();

            ViewBag.Peliculas = peliculas;
            ViewBag.Generos = listaGeneros;
            return View();
        }

        public IActionResult Estrenos(int? buscadorGenero = 0, int? page = 1)
        {
            var pageNumber = page ?? 1;
            int pageSize = 6;
            dynamic peliculasEStreno;

            //Listar estrenos peliculas para mostrar el carrusel
            //Filtrar productos si buscador viene con valor o es nulo
            if (buscadorGenero != 0)
            {
                peliculasEStreno = _db.Peliculas.Include(g => g.Genero).Where(p => p.Estreno == true).Where(i => i.IdGenero == buscadorGenero).ToPagedList(pageNumber, pageSize);
            }
            else
            {
                peliculasEStreno = _db.Peliculas.Include(g => g.Genero).Where(p => p.Estreno == true).ToPagedList(pageNumber, pageSize);
            }

            //Listar generos
            var listaGeneros = _db.Generos.OrderBy(n => n.NombreGenero).ToList();

            ViewBag.PeliculasEstreno = peliculasEStreno;
            ViewBag.Generos = listaGeneros;
            return View();
        }

        public IActionResult Cartelera(int? buscadorGenero = 0, int? page=1)
        {
            var pageNumber = page ?? 1;
            int pageSize = 6;
            dynamic peliculasCartelera;

            //Listar cartelera peliculas para mostrar el carrusel
            //Filtrar productos si buscador viene con valor o es nulo
            if (buscadorGenero != 0)
            {
                peliculasCartelera = _db.Peliculas.Include(g => g.Genero).Where(p => p.Cartelera == true).Where(i => i.IdGenero == buscadorGenero).ToPagedList(pageNumber, pageSize);
            }
            else
            {
                peliculasCartelera = _db.Peliculas.Include(g => g.Genero).Where(p => p.Cartelera == true).ToPagedList(pageNumber, pageSize);
            }

            //Listar generos
                    var listaGeneros = _db.Generos.OrderBy(n => n.NombreGenero).ToList();

            ViewBag.PeliculasCartelera = peliculasCartelera;
            ViewBag.Generos = listaGeneros;
            return View();
        }

        public IActionResult Proximamente(int? buscadorGenero = 0, int? page = 1)
        {
            var pageNumber = page ?? 1;
            int pageSize = 6;
            dynamic peliculasProximamente;

            //Listar proximamente peliculas para mostrar el carrusel
            //Filtrar productos si buscador viene con valor o es nulo
            if (buscadorGenero != 0)
            {
                peliculasProximamente = _db.Peliculas.Include(g => g.Genero).Where(p => p.Proximamente == true).Where(i => i.IdGenero == buscadorGenero).ToPagedList(pageNumber, pageSize);
            }
            else
            {
                peliculasProximamente = _db.Peliculas.Include(g => g.Genero).Where(p => p.Proximamente == true).ToPagedList(pageNumber, pageSize);
            }

            //Listar generos
            var listaGeneros = _db.Generos.OrderBy(n => n.NombreGenero).ToList();

            ViewBag.PeliculasProximamente = peliculasProximamente;
            ViewBag.Generos = listaGeneros;
            return View();
        }


        public IActionResult Ranking()
        {
            //Listar películas para el list
            //Filtrar productos si buscador viene con valor o es nulo
            var peliculas = _db.Peliculas.Include(g => g.Genero).OrderByDescending(c => c.Calificacion).ThenByDescending(c => c.Puntuacion).Take(5);

            ViewBag.Peliculas = peliculas;
            ViewBag.Grafico =_db.Peliculas.Select(n => new { n.Nombre, n.Puntuacion }).OrderByDescending(c => c.Puntuacion).Take(10).ToList();
            return View();
        }

        [HttpPost]
        public void GuardarCalificacion(int id, int rating)
        {
            Calificacion calificacion = new Calificacion();

            calificacion.IdPelicula = id;
            calificacion.idUsuario = null;
            calificacion.Fecha = DateTime.Now;
            calificacion.CalificacionPelicula = rating;

            _db.Calificaciones.Add(calificacion);

            //Actualizar Calificacion de pelicula 
            var sumPuntos = _db.Calificaciones.Where(i => i.IdPelicula == id).Sum(c => c.CalificacionPelicula);
            var cuentaVotacion = _db.Calificaciones.Where(i => i.IdPelicula == id).Count();

            var nuevaCalificacion = ((sumPuntos + rating) / (cuentaVotacion + 1)) > 5 ? 5 : (sumPuntos + rating) / (cuentaVotacion + 1);

            Pelicula pelicula = _db.Peliculas.Find(id);
            pelicula.Calificacion = nuevaCalificacion;
            pelicula.Puntuacion = pelicula.Puntuacion + rating;

            _db.SaveChanges();

            TempData["Mensaje"] = "Calificación guardada exitosamente!";
        }


        //Funcion para devolver valor promedio de calificacion
        public double CalPelicula(int idPelicula)
        {
            var calificacion = _db.Calificaciones.Where(i => i.IdPelicula == idPelicula).Sum(c => c.CalificacionPelicula);
            return calificacion;
        }
    }
}
