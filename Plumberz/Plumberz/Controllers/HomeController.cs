using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Plumberz.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
  
    }
}
