using System.Diagnostics;
using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    //Class: HomeController or Home

    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        //Method: Index -��ǹ�ʴ���-> Home/Index.cshtml
        {
            return View();
        }

        public IActionResult Privacy()
        //Method: Index -��ǹ�ʴ���-> Home/Privacy.cshtml
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
