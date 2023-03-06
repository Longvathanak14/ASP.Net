using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
