using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using hello.Models;

namespace hello.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application page.";

            return View();
        }

        public IActionResult Contact()
        {
            var ip = HttpContext.Connection.LocalIpAddress.ToString();
            
            ViewData["Message"] = "Your contact page. my ip is:" + ip;

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
