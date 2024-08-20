using Microsoft.AspNetCore.Mvc;
using Myapp.Models;
using System;

namespace Myapp.Controllers
{
    public class CalculateController : Controller
    {
        //public IActionResult Index()
        //{
        //    ViewBag.heading = "calculator application";
        //    return View();
        //}
        //public IActionResult saalah()
        //{
        //    return View();
        //}
        public IActionResult Info()
        {
            person person = new person();
            person.name = "kamalesh";
            person. salary = 20000;
            person.age = 24;
            return View(person);
        }

    }
}
