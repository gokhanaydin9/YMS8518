﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Deneme2.Controllers
{
    public class DataPass1Controller : Controller
    {
        public IActionResult Pass1()
        {
            
            ViewBag.Username = "BilgeAdam";
            string degisken = "YeniBuArkadas";
            ViewData[degisken]= "bu da değeri";

            return View();
        }
    }
}