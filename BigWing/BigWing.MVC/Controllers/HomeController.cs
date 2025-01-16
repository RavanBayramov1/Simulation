using System.Diagnostics;
using BigWing.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigWing.MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
