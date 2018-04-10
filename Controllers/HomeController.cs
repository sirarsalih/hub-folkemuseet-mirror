using Microsoft.AspNetCore.Mvc;

namespace NorskFolkemuseum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
