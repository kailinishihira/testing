using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
