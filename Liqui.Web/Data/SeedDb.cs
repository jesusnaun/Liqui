using Liqui.Web.Data.Entities;
using Liqui.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _dataContext = context;
            _userHelper = userHelper;
        }



        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            
            //await CheckServiceTypesAsync();
          
            ////await CheckAgendasAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("Jesús Naún", "jesusnaun@gmail.com", "Admin");
            var customer = await CheckUserAsync("Jesús Naún", "jesusnaun@outlook.com", "Customer");
            var customer2 = await CheckUserAsync("Alicia Mariet", "alicia@outlook.com", "Customer");
            await CheckUsuarioAsync(customer,customer2);
            //await CheckUsuarioAsync(customer);
           
            await CheckManagerAsync(manager);
            await CheckGrupoAsync();
        }


        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Customer");
        }


        private async Task<User> CheckUserAsync(string name,string email, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Name = name,
                    Email = email,
                    UserName = email
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role); 
            }
            return user;
        }




        private async Task CheckGrupoAsync()
        {
            var grupo = _dataContext.Grupos.FirstOrDefault();
           if (!_dataContext.Grupos.Any())
            {
                AddGrupo("Bebidas");
                AddGrupo("Pollo a la brasa");
                AddGrupo("Papas");
                await _dataContext.SaveChangesAsync();
            }
        }

        private void AddGrupo(string name)
        {
            _dataContext.Grupos.Add(new Grupo
            {
                Name = name
                
            });
        }


        private async Task CheckUsuarioAsync(User user,User user2)
        {
            if (!_dataContext.Usuarios.Any())
            {
                _dataContext.Usuarios.Add(new Usuario { User = user });
                _dataContext.Usuarios.Add(new Usuario { User = user2 });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckManagerAsync(User user)
        {
            if (!_dataContext.Managers.Any())
            {
                _dataContext.Managers.Add(new Manager { User = user });
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
