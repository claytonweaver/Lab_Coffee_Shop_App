using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_18_Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_18_Coffee_Shop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View(new User());
        }

        public IActionResult DisplayUser(User user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return View("Register",user);
            }
        }


    }
}