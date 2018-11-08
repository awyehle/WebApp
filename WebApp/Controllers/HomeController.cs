using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            ViewData["Message"] = "Just as soon as I get SSL and a secure DB.";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Also, just as soon as I get SSL and a secure DB.";

            return View();
        }

        public IActionResult Downloads()
        {
            ViewData["Message"] = "Yep. Eventually.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
