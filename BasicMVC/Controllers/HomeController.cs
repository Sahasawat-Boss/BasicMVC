using System.Diagnostics;
using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    //Class: HomeController or Home
    //��ҹ��ҧ�� Method � Class

    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        //Method �зӧҹ���Ѻ File �������ǹ�ʴ������ǡѹ
        //Method: Index -��ǹ�ʴ���-> Home/Index.cshtml
        {
            //��� class �ҷ��� Object
            Member m = new Member();
            m.ID = 100;
            m.FullName = "Sahasawat Rueankaew";
            m.Address = "CNX";

            return View(m);
            //return View("Privacy"); //������ View("Privacy") ����ʴ�����ǹ�ͧ Privacy.cshtml
        }

        public IActionResult Faq()
        //Add Method Faq
        {
            return View();
        }

        public IActionResult Privacy() => View();
        //Method: Index -��ǹ�ʴ���-> Home/Privacy.cshtml
        // Expression Body "=>" ��¹຺Ŵ�ٻ

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
