using Liqui.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }



        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckGrupoAsync();
            //await CheckServiceTypesAsync();
            //await CheckOwnersAsync();
            //await CheckPetsAsync();
            //await CheckAgendasAsync();
        }




        private async Task CheckGrupoAsync()
        {
            var grupo = _context.Grupos.FirstOrDefault();
            var petType = _context.Grupos.FirstOrDefault();
            if (!_context.Grupos.Any())
            {
                AddGrupo("Bebidas");
                AddGrupo("Pollo a la brasa");
                AddGrupo("Papas");
                await _context.SaveChangesAsync();
            }
        }

        private void AddGrupo(string name)
        {
            _context.Grupos.Add(new Grupo
            {
                Name = name
                
            });
        }



    }
}
