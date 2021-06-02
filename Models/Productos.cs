using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alvin_P1_AP2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Inserte la descripción del producto")]
        public string Descripcion { get; set; }

        public float Existencia { get; set; } = 0;

        [Range(minimum: 0, maximum: 50000000, ErrorMessage = "Inserte valor válido")]
        public float Costo { get; set; } = 0;

        [Range(minimum: 0, maximum: 50000000, ErrorMessage = "Inserte valor válido")]
        public float ValorInventario { get; set; } = 0;
    }
}
