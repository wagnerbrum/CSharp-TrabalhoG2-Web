﻿using Microsoft.AspNetCore.Mvc;

namespace Proj.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
