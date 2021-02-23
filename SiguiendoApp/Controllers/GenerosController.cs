using Microsoft.AspNetCore.Mvc;
using SiguiendoApp.Data;
using SiguiendoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiguiendoApp.Controllers
{
    public class GenerosController : Controller
    {
        private readonly ApliquetionDbContext _context;

        public GenerosController( ApliquetionDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Genero> generos = _context.GetGeneros;

            return View(generos);
        }

        public IActionResult Create()
        {
           
            return View();
        }


        [HttpPost]
        public IActionResult Create( Genero genero)
        {
           

            if (ModelState.IsValid)
            {
                _context.GetGeneros.Add(genero);
                _context.SaveChanges();

                return RedirectToAction("Index");
                
            }

            return View();
        }

        public IActionResult Editar(int? id)
        {
            if (id==null || id==0)
            {
               return NotFound();
            }

            var edit = _context.GetGeneros.Find(id); 
            if (edit == null)
            {
                NotFound();

            }


            return View(edit);
        }
        [HttpPost]
        public IActionResult Editar(Genero genero)
        {


            if (ModelState.IsValid)
            {
                _context.GetGeneros.Update(genero);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var Elimina = _context.GetGeneros.Find(id);
            if (Elimina == null)
            {
                NotFound();

            }


            return View(Elimina);
        }
        [HttpPost]
        public IActionResult EliminarGenero(int? id)
        {
            var Elimina = _context.GetGeneros.Find(id);
            if (Elimina == null)
            {
                NotFound();

            }

                _context.GetGeneros.Remove(Elimina);
                _context.SaveChanges();

                return RedirectToAction("Index");

            

            
        }
    }
}
