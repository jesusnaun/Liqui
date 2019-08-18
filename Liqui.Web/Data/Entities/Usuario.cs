using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class Usuario
            {
        public int Id { get; set; }

        //[Required]
        //[MaxLength(20)]
        //[Display(Name = "Nombre")]
        //public string Name { get; set; }

        //[Required]
        //[MaxLength(50)]
        //[Display(Name = "Correo")]
        //public string Email { get; set; }


        public User User { get; set; }

        public ICollection<UsuarioLocal> UsuarioLocales { get; set; }
    }
}
