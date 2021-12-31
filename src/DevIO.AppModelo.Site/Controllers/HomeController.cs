using Microsoft.AspNetCore.Mvc;

namespace DevIO.AppModelo.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}