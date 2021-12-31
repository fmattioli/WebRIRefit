using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Application.ViewModels.Livro;
using RI.Web.Application.Services.Acoes;

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
