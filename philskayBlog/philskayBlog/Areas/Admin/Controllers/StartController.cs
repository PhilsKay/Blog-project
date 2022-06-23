using Microsoft.AspNetCore.Mvc;
using philskayBlog.Models;
using System.Diagnostics;

namespace philskayBlog.Controllers
{
    [Area("Admin")]
    public class StartController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public StartController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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