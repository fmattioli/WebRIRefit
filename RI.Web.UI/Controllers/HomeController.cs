using Microsoft.AspNetCore.Mvc;

namespace RI.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
