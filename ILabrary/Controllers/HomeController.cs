using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ILabrary.Models;

namespace ILabrary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Login", "Library");
        }

        public IActionResult Privacy()
        {
            return RedirectToAction("Login", "Library");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
