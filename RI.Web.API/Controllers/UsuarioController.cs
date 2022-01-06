using Microsoft.AspNetCore.Mvc;
using RI.Application.ViewModels.Usuario;
using RI.Web.Application.Interfaces.Usuario;
using RI.Web.Application.Services.Acoes;

namespace RI.Web.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("ObterNaturezas")]
        [ProducesResponseType(typeof(RetornoAcaoService<UsuarioViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioViewModel>> ObterTiposPrenotacao([FromServices] IUsuarioService naturezaService)
        {
            var retorno = await naturezaService.ObterNaturezas();
            if (retorno.Sucesso)
                return Ok(retorno);
            return BadRequest(retorno.ExceptionRetorno);

        }
    }
}
