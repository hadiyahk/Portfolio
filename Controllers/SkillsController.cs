using Microsoft.AspNetCore.Mvc;

namespace hportfolio.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
