using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // Add view folder โดยคลิ้กขวาที่ View()
        }
    }
}
