using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiguiendoApp.Models
{
    [Table("Album")]
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
        public int ArtistaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Fecha de lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamientoprot { get; set; }

        //[Display(Name = "Nombre del artista")]
        public virtual Artista Artista { get; set; }
    }
}
