using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiguiendoApp.Models
{
    [Table("Artista")]
    public class Artista
    {
        [Key]
        public int IdArtista{ get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }

        public int GeneroId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nacionalidad { get; set; }

        //[Required(ErrorMessage = "Este campo es obligatorio")]
        //[Display(Name = "Altura")]
        //public double Alturo{ get; set; }

       [Display(Name = " Fecha de Nacimiento")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime FechadeNacimiento{ get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Año de Inicio")]
        public int AnioInicio { get; set; }

        public virtual Genero Genero { get; set; }


    }
}
