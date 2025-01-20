using Microsoft.AspNetCore.Mvc;

namespace Portfolio.wwwroot.js
{
    public class site : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
