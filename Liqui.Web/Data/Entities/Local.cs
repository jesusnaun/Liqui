using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class Local
    {
       public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }


        [Required]
        [MaxLength(30)]
        [Display(Name = "Distrito")]
        public string District { get; set; }


        public ICollection<Usuario> Usuarios { get; set; }
    }
}
