using Microsoft.AspNetCore.Mvc;
using RI.Web.API.Auth;
using RI.Web.Application.Interfaces.Usuario;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsuarioController : BaseController
    {
        [HttpGet("ObterUsuario")]
        [ProducesResponseType(typeof(RetornoAcaoService<UsuarioViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioViewModel>> ObterUsuario(LoginViewModel login, [FromServices] IUsuarioService naturezaService)
        {
            if (ModelState.IsValid)
            {
                var retorno = new RetornoAcaoService<UsuarioViewModel>();
                var usuario = new UsuarioViewModel
                {
                    Token = TokenAuth.GenerateToken(login.NomeUsuario ?? "", ObterSecretKey())
                };
                retorno.Result = usuario;
                return Ok(retorno);
            }
            return BadRequest("");
        }

    }
}
