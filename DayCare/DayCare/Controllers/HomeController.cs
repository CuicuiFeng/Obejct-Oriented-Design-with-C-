using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DayCare.Models;

namespace DayCare.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //create object model
            RosterModel rosterModel = new RosterModel()
            {
                FirstName = "Tracy",
                LastName = "Feng",
                Age = 23,
                Id = 001
            };
            return View(rosterModel);
            //return Content("Hello World!");
            //return View();
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
