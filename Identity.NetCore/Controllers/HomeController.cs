using Identity.NetCore.Context;
using Identity.NetCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(new UserSignInViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index", "Panel");
                }
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı.");
            }
            
            return View("Index", model);
        }
        public IActionResult SignUp()
        {
            return View(new UserSignUpViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    Name = model.Name,
                    SurName = model.SurName,
                    UserName = model.UserName,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }
}
