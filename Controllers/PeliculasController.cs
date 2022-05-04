using DAS901_Desafio2.Data.Entity;
using DAS901_Desafio2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult Index(int? buscadorGenero=0, int? page=1)
        {
            var pageNumber = page ?? 1;
            int pageSize = 6;
            dynamic peliculas;

            //Listar películas para el grid
            //Filtrar productos si buscador viene con valor o es nulo
            if (buscadorGenero != 0)
            {
                peliculas = _db.Peliculas.Include(g => g.Genero).Where( i => i.IdGenero == buscadorGenero).ToPagedList(pageNumber, pageSize);
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
            return View();
        }

    }
}
