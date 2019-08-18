using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class User : IdentityUser
    {

        [Required]
        [MaxLength(20)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

    }
}
