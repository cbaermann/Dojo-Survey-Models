using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyModels.Models;

namespace dojoSurveyModels.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("info")]

        public IActionResult Info(User newUser)
        {
            return View(newUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
