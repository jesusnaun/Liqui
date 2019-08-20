﻿using Liqui.Web.Helpers;
using Liqui.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liqui.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;

        public AccountController(IUserHelper userHelper)
        {

            _userHelper = userHelper; 
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }
                    
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Usuario o clave no válido");

                //Si quiero borrar la clave al error
                model.Password = string.Empty;

            }


            return View(model);
        }




        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home"); 
            //return View();
        }

    }
}