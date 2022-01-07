using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.UI.Controllers
{
    public class UsuarioController : BaseController<UsuarioViewModel>
    {
        public IActionResult Login()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var usuarioRequest = await AutenticarUsuarioRequest("Usuario/ObterUsuario", model);
                if (usuarioRequest.IsSuccessStatusCode)
                {
                    var usuario = JsonConvert.DeserializeObject<RetornoAcaoService<UsuarioViewModel>>(await usuarioRequest.Content.ReadAsStringAsync());
                    TempData["jsonUsuario"] = JsonConvert.SerializeObject(usuario.Result);
                    return RedirectToAction("Home", "Home");
                }

                
            }
            return View(nameof(Login));

        }
    }
}
