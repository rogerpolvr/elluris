﻿using Microsoft.AspNetCore.Mvc;
using Nodus.Elluris.Mvc.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace Nodus.Elluris.Mvc.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
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
