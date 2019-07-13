using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(Account account)
        {
            return View(account);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",account);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}

