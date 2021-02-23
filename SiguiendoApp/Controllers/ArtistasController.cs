using Microsoft.AspNetCore.Mvc;
using SiguiendoApp.Data;
using SiguiendoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiguiendoApp.Controllers
{
    public class ArtistasController : Controller
    {
        private readonly ApliquetionDbContext _context;

        public ArtistasController( ApliquetionDbContext dbContext)
        {
            _context = dbContext;
        }

            
        public IActionResult Index()
        {
            
           ViewBag.artistass= _context.GetArtistas.ToList();
            ViewBag.Bachata = _context.GetGeneros.ToList();

            return View(/*_context.GetArtistas.ToList()*/);
        }

        //[BindProperty]
        //public Artista artista { get; set; }

        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create( Artista artista)
        {
            if (ModelState.IsValid)
            {
                _context.GetArtistas.Add(artista);
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

            var artis = _context.GetArtistas.Find(id);
            if (artis==null)
            {
                 NotFound();
            }

            return View(artis);
        }

      [HttpPost]
        public IActionResult Editar(Artista artista)
        {
            if (ModelState.IsValid)
            {
                _context.GetArtistas.Update(artista);
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

            var artista = _context.GetArtistas.Find(id);
            if (artista == null)
            {
                NotFound();
            }

            return View(artista);
        }
        [HttpPost]
        public IActionResult EliminarArtista(int? id)
        {
            var RemoveArtistass= _context.GetArtistas.Find(id);

            if (RemoveArtistass == null)
            {
                NotFound();
            }


            _context.GetArtistas.Remove(RemoveArtistass);
                _context.SaveChanges();

                return RedirectToAction("Index");
          
           
        }


    }
}
