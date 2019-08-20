using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class HojaLiquidacion
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        public DateTime MyDate { get; set; }


        public decimal Efectivo { get; set; }

        public decimal VisaDebito { get; set; }

        public decimal VisaCredito { get; set; }

        public decimal MasterDebito { get; set; }

        public decimal MasterCredito { get; set; }

        public decimal AmericanExpress { get; set; }

        public decimal DinersClub { get; set; }

        public decimal PersonalI { get; set; }

        public decimal OtrosI { get; set; }

        public decimal TotalIngresos { get; set; }

        public decimal InsumoSinProcesar { get; set; }

        public decimal InsumoPorProcesar { get; set; }

        public decimal NoInsumo { get; set; }


        public decimal PersonalE { get; set; }

        public decimal OtrosE { get; set; }

        public decimal TotalEgresos { get; set; }


        public decimal UtilidadBruta { get; set; }


        public decimal UtilidadEfetivo { get; set; }


        public HojaProducto HojaProducto { get; set; }

    }
}
