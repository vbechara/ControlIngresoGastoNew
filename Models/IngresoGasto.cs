using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGastoNew.Models
{
    public class IngresoGasto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        [Required]
        [Range(1, 1000000)]
        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C}")]

        public double Valor { get; set; }
    }
}
