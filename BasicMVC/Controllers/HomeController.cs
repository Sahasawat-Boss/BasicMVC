using System.Diagnostics;
using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    //Class: HomeController or Home
    //ด้านล่างเป็น Method ใน Class

    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        //Method จะทำงานคู่กับ File ที่มีส่วนแสดงผลเดียวกัน
        //Method: Index -ส่วนแสดงผล-> Home/Index.cshtml
        {
            //เอา class มาทำเป็น Object
            Member m = new Member();
            m.ID = 100;
            m.FullName = "Sahasawat Rueankaew";
            m.Address = "CNX";

            return View(m);
            //return View("Privacy"); //ถ้าใส่ View("Privacy") ก็จะแสดงผลส่วนของ Privacy.cshtml
        }

        public IActionResult Faq()
        //Add Method Faq
        {
            return View();
        }

        public IActionResult Privacy() => View();
        //Method: Index -ส่วนแสดงผล-> Home/Privacy.cshtml
        // Expression Body "=>" เขียนเบบลดรูป

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
