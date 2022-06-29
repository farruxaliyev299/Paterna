using Microsoft.AspNetCore.Mvc;

namespace PaternaBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
