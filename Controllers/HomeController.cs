using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FGCSerbiaWeb.Models;

namespace FGCSerbiaWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Meetups()
        {
            ViewData["Message"] = "Page for meetup information.";

            return View();
        }

        public IActionResult Tournaments()
        {
            ViewData["Message"] = "Page for tournament information.";

            return View();
        }

        public IActionResult Twitch()
        {
            ViewData["Message"] = "Twitch streamers from the Serbian FGC community.";

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
