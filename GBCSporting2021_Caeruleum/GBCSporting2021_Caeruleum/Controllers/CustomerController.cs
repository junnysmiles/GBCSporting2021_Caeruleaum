﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_Caeruleum.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customer()
        {
            ViewData["Message"] = "Customers Page";
            return View();
        }
    }
}
