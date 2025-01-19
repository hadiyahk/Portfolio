using Microsoft.AspNetCore.Mvc;

namespace hportfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
