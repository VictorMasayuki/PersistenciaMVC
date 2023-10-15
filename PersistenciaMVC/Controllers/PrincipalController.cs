using Microsoft.AspNetCore.Mvc;

namespace PersistenciaMVC.Views
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MVC()
        {
            return View();
        }
    }
}
