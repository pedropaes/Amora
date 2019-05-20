using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eloise.Models;
using Eloise.shared;


namespace Eloise.Controllers
{
    [Route("[controller]/[action]")]
    public class UserViewController : Controller
    {

        private UserHandling userHandling;
        public UserViewController(UserContext context)
        {
            //_context = context;
            userHandling = new UserHandling(context);
        }

        public IActionResult getUsers()
        {
            User[] users = userHandling.getUsers();
            return View(users);
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
    }
}