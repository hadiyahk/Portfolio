using Microsoft.AspNetCore.Mvc;

namespace hportfolio.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
