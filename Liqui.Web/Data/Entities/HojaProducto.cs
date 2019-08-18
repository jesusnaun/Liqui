using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class HojaProducto
    {
        public int Id { get; set; }

        public decimal Inicial { get; set; }
        public decimal Entrada { get; set; }
        public decimal Venta { get; set; }
        public decimal Final { get; set; }

        public string Observaciones { get; set; }


        public Producto Producto { get; set; }

        public ICollection<HojaLiquidacion> HojaLiquidaciones { get; set; }
}
}
