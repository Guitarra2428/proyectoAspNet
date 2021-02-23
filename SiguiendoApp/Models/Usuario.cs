using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SiguiendoApp.Models
{
    public class Usuario
    {
        [Required( ErrorMessage ="Escriba su nombre")]
        [MinLength(4,ErrorMessage ="Escriba al menos 5 carateres")]
        [MaxLength(50, ErrorMessage = "Escriba un maximo de 50 carateres")]
        public string Nombrre { get; set; }

        [Required(ErrorMessage = "Escriba su Apellido")]
        [MinLength(4, ErrorMessage = "Escriba al menos 5 carateres")]
        [MaxLength(50, ErrorMessage = "Escriba un maximo de 50 carateres")]

        public string Apellido { get; set; }

        [Required(ErrorMessage = "Escriba un correo")]
        [EmailAddress(ErrorMessage ="escriba un correo valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Escriba si esta activo")]
        public bool EstaActivo { get; set; }

        [Required(ErrorMessage = "Escriba su fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Escriba su Edad")]
        [Range(18, 20, ErrorMessage ="El registro es para mayores de 18")]
        public int Edad { get; set; }


    }
}
