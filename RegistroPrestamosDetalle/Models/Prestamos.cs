using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosDetalle.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int PersonaId { get; set; }

        public string Concepto { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Monto { get; set; }
        public decimal Balance { get; set; }
        public DateTime Fecha { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
            Fecha = DateTime.Now;
        }
    }
}
