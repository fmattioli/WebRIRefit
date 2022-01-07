using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home(UsuarioViewModel usuarioViewModel)
        {
            if (TempData["jsonUsuario"] is not null)
            {
                string? jsonUsuario = TempData["jsonUsuario"]?.ToString();
                var usuario = JsonConvert.DeserializeObject<UsuarioViewModel>(jsonUsuario ?? "");
                if (usuario is not null)
                {
                    HttpContext.Session.SetString("token", usuario.Token ?? "");
                    return View(usuario);
                }
            }

            return BadRequest("Erro ao fazer login");
        }

    }
}
