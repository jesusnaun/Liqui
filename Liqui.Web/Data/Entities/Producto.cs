using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        public Grupo Grupo { get; set; }

        public ICollection<HojaProducto> HojaProductos { get; set; }

    }
}
