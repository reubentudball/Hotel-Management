﻿using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
