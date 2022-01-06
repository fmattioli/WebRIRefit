using Microsoft.AspNetCore.Mvc;
using RI.Application.ViewModels.Usuario;

namespace RI.Web.UI.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(nameof(Login));

        }
    }
}
