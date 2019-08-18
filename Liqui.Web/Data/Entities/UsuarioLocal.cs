using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class UsuarioLocal
    {
        public int Id { get; set; }


        public Local Local { get; set; }

        public Usuario Usuario { get; set; }

        public ICollection<HojaLiquidacion> HojaLiquidaciones { get; set; }
    }
}
