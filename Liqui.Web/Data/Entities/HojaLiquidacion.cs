using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data.Entities
{
    public class HojaLiquidacion
    {
        public int Id { get; set; }

        public UsuarioLocal UsuarioLocal { get; set; }

        public DateTime MyDate { get; set; }


        public Decimal Efectivo { get; set; }

        public Decimal VisaDebito { get; set; }

        public Decimal VisaCredito { get; set; }

        public Decimal MasterDebito { get; set; }

        public Decimal MasterCredito { get; set; }

        public Decimal AmericanExpress { get; set; }

        public Decimal DinersClub { get; set; }

        public Decimal PersonalI { get; set; }

        public Decimal OtrosI { get; set; }

        public Decimal TotalIngresos { get; set; }

        public Decimal InsumoSinProcesar { get; set; }

        public Decimal InsumoPorProcesar { get; set; }

        public Decimal NoInsumo { get; set; }


        public Decimal PersonalE { get; set; }

        public Decimal OtrosE { get; set; }

        public Decimal TotalEgresos { get; set; }


        public Decimal UtilidadBruta { get; set; }


        public Decimal UtilidadEfetivo { get; set; }


        public HojaProducto HojaProducto { get; set; }

    }
}
