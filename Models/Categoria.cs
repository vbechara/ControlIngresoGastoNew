using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGastoNew.Models
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name ="Nombre Categoría")]
        public string NombreCategoria { get; set; }
        [Required]
        [MaxLength(2)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
