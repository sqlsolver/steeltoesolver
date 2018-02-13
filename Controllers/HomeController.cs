﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kkj.Models;

namespace kkj.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = ".Net Core 2.0 MVC sample application, deployed to Azure using Pivotal Cloud Foundry.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "RamonaM@Magenic.com";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}