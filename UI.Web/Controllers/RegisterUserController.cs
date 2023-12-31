﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI.Web.Models;
using System.Threading.Tasks;

namespace UI.Web.Controllers
{
    //[AllowAnonymous]
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]  // Burada [HttpPost] özniteliği düzeltilmiş ve doğru konumlandırılmıştır.
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    NameSurname = p.nameSurname
                };

                var result = await _userManager.CreateAsync(user, p.ConfirmPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
