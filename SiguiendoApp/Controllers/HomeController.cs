using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SiguiendoApp.Models;
using SiguiendoApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SiguiendoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApliquetionDbContext _context;

        public HomeController( ApliquetionDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Genero()
        {


            //Artista _artista = new Artista()
            //{

            //    Nombre = "CRIS",
            //    GeneroId=1,
            //    Nacionalidad = "Dominicana",
            //    Alturo = 7,
            //    LugardeNacimiento = DateTime.Now,
            //    AnioInicio = 19922,





            //};
            //_context.GetArtistas.Add(_artista);
            //_context.SaveChanges();
            //Artista artista = new Artista();

            ViewBag.art = _context.GetArtistas.Include("Genero").ToList();
            ViewBag.Genero = _context.GetGeneros.ToList() ;

            return View(_context.GetArtistas.Include(X => X.Genero).ToList());
        }


        [BindProperty]
        public Usuario usuario { get; set; }
        public IActionResult SetUsuario()
        {
            return Json(usuario);
        }

        public IActionResult Usuarios()
        {

            ViewData["Usuarios"] = new List<Usuario>() {
            new Usuario
            {
                Nombrre = "Luis",
                Apellido = "Mesili",
                Correo = "ddd@gmail.com",
                Edad = 23
            },
             new Usuario
            {
                Nombrre = "Dl",
                Apellido = "Mes",
                Correo = "aaa@gmail.com",
                Edad = 22
            },

            };
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
    }
}
