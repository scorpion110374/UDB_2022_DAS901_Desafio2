using DAS901_Desafio2.Data.Entity;
using DAS901_Desafio2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DAS901_Desafio2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectDbContext _db;

        public HomeController(ProjectDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //Listar todas peliculas para mostrar el carrusel
            _ = new List<Pelicula>();
            List<Pelicula> peliculas = _db.Peliculas.ToList();

            ViewBag.Peliculas = peliculas;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Promociones()
        { 
            return View();
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            List<SelectListItem> listarTemas = new List<SelectListItem>();
            listarTemas.Add(new SelectListItem { Text = "Consulta", Value = "Consulta" });
            listarTemas.Add(new SelectListItem { Text = "Felicitación", Value = "Felicitación" });
            listarTemas.Add(new SelectListItem { Text = "Problema", Value = "Problema" });
            listarTemas.Add(new SelectListItem { Text = "Queja", Value = "Queja" });

            ViewBag.listaTemas = listarTemas;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(Contacto Contacto)
        {
            if (ModelState.IsValid)
            {
                _db.Contactos.Add(Contacto);
                await _db.SaveChangesAsync();

                TempData["Mensaje"] = "Mensaje enviado!";

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
