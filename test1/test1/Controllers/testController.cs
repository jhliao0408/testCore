using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Msg = "test test test!!";
            return View();
        }
    }
}
