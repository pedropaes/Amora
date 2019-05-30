using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eloise.Models;
using Eloise.shared;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Net;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Eloise.Controllers
{
    [Route("[controller]/[action]")]
    public class UserViewController : Controller
    {

        private UserHandling userHandling;
        
        public UserViewController(EloiseContext context)
        {
           
            userHandling = new UserHandling(context);
            
        }



        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser([Bind] User user)
        {
            if (ModelState.IsValid)
            {
                bool RegistrationStatus = this.userHandling.registerUser(user);
                if (RegistrationStatus)
                {
                    ModelState.Clear();
                    TempData["Success"] = "Registration Successful!";
                }
                else
                {
                    TempData["Fail"] = "This User ID already exists. Registration Failed.";
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserLogin([Bind] User user)
        {
            ModelState.Remove("nome");
            ModelState.Remove("email");

            if (ModelState.IsValid)
            {
                var LoginStatus = this.userHandling.validateUser(user);
                User u = this.userHandling.getUser(user.email);
                
                if (LoginStatus)
                {
                   
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, u.nome),
                        new Claim(ClaimTypes.Role, u.tipo)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity("login");
                    userIdentity.AddClaims(claims);
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    TempData["UserLoginFailed"] = "Login Failed. Please enter correct credentials";

                }
                
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
    }
}