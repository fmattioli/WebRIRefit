using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RI.Application.ViewModels.Usuario;
using RI.Web.API.Auth;
using RI.Web.Application.Interfaces.Usuario;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.API.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("ObterUsuario")]
        [ProducesResponseType(typeof(RetornoAcaoService<UsuarioViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioViewModel>> ObterUsuario(LoginViewModel login, [FromServices] IUsuarioService naturezaService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await naturezaService.ObterUsuario(login);
                if (retorno.Sucesso)
                {
                    return Ok(retorno);
                }
            }
            return BadRequest("");
        }
    }
}
