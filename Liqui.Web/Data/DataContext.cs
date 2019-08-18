using Liqui.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data
{
    //public class DataContext : DbContext
        public class DataContext : IdentityDbContext<User>
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
            }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<HojaLiquidacion> HojaLiquidaciones { get; set; }
        public DbSet<HojaProducto> HojaProductos { get; set; }
        public DbSet<Local> Locales { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioLocal> UsuarioLocales { get; set; }


        public DbSet<Manager> Managers { get; set; }


    }
}
