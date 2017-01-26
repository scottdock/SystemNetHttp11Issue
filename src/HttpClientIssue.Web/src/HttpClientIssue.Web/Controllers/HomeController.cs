using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

namespace HttpClientIssue.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;

            using (var client = new HttpClient())
            {
                var re = client.GetAsync("https://99.99.99.99:8811").Result;
            }

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

        public IActionResult Error()
        {
            return View();
        }
    }
}
