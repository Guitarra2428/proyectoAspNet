using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiguiendoApp.Models;

namespace SiguiendoApp.Data
{
    public class ApliquetionDbContext: DbContext
    {
        public ApliquetionDbContext(DbContextOptions<ApliquetionDbContext> options): base(options)
        {
                
        }

        public DbSet<Genero> GetGeneros { get; set; }
        public DbSet<Artista> GetArtistas { get; set; }
        public DbSet<Album> GetAlbums { get; set; }
    }
}
