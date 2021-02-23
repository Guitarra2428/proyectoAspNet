using Microsoft.AspNetCore.Mvc;
using SiguiendoApp.Data;
using SiguiendoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiguiendoApp.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly ApliquetionDbContext _context;

        public AlbumsController(ApliquetionDbContext dbContext)
        {
            _context = dbContext;
        }

        //[BindProperty]
        //public Albun GetAlbum { get; set; }
        public IActionResult Index()
        {
            // List<Albun> album =_context.GetAlbuns;
            //List<Albun> albums = new List<Albun>();
            IEnumerable<Album> albums = _context.GetAlbums;


            return View(_context.GetAlbums.ToList());
        }


        //[BindProperty]
        //public Artista artista { get; set; }

        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create(Album  album)
        {
            if (ModelState.IsValid)
            {
                _context.GetAlbums.Add(album);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var aLBUN = _context.GetArtistas.Find(id);
            if (aLBUN == null)
            {
                NotFound();
            }

            return View(aLBUN);
        }

        [HttpPost]
        public IActionResult Editar(Album album)
        {
            if (ModelState.IsValid)
            {
                _context.GetAlbums.Update(album);
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

            var aLBUM = _context.GetAlbums.Find(id);
            if (aLBUM == null)
            {
                NotFound();
            }

            return View(aLBUM);
        }
        [HttpPost]
        public IActionResult EliminarArtista(int? id)
        {
            
            
            var RemoveaLBUM = _context.GetArtistas.Find(id);
            if (RemoveaLBUM == null)
            {
                NotFound();
            }


            _context.GetArtistas.Remove(RemoveaLBUM);
            _context.SaveChanges();

            return RedirectToAction("Index");


        }


    }
}
