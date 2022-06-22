using HospitalManagementSystemTask.Data.Context;
using HospitalManagementSystemTask.Data.Static;
using HospitalManagementSystemTask.Models;
using HospitalManagementSystemTask.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        public AccountController(UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            this._userManger = userManger;
            this._signInManager = signInManager;
            this._context = context;
        }


        public async Task<IActionResult> Users() => View(await _context.Users.ToListAsync());

        public IActionResult Login() => View(new ViewModelLogin());


        [HttpPost]
        public async Task<IActionResult> Login(ViewModelLogin login)
        {
            if (!ModelState.IsValid) return View(login);

            var user = await _userManger.FindByEmailAsync(login.EmailAddress);
            if (user != null)
            {
                var passwordChck = await _userManger.CheckPasswordAsync(user, login.Password);
                if (passwordChck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, login.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            TempData["Error"] = "Yenidən yoxlayın";
            return View(login);
        }

        public IActionResult Register() => View(new ViewModelRegister());


        [HttpPost]
        public async Task<IActionResult> Register(ViewModelRegister register)
        {
            if (!ModelState.IsValid) return View(register);

            var user = await _userManger.FindByEmailAsync(register.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "Daxil etdiyiniz elektron poçt ünvanı artıq istifadə olunub.";
                return View(register);
            }


            var newUser = new ApplicationUser()
            {
                FullName = register.FullName,
                Email = register.EmailAddress,
                UserName = register.EmailAddress,
                EmailConfirmed = true
            };
            var newUserResponse = await _userManger.CreateAsync(newUser, register.Password);

             var newUserRoleResponse= await _userManger.AddToRoleAsync(newUser, UserRole.User);

            return View("CompletedRegister");
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
