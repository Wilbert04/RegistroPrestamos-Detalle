using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosDetalle.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Balance { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaNacimiento { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Balance = 0;
            FechaNacimiento = DateTime.Now;
           
        }

    }
}
