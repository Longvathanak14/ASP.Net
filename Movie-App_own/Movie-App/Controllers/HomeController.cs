using Microsoft.AspNetCore.Mvc;

namespace Movie_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
