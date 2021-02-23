using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiguiendoApp.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }

       [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        
    }
}
