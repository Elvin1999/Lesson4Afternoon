﻿using Microsoft.AspNetCore.Mvc;

namespace Lesson4Afternoon.Areas.Client.Controllers
{
    [Area("Client")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
