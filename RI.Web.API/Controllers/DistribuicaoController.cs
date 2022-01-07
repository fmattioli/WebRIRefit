using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RI.Web.Application.Interfaces.Distribuicao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Distribuicao;

namespace RI.Web.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    public class DistribuicaoController : Controller
    {
        [HttpGet("ObterNegociosCDS")]
        [ProducesResponseType(typeof(RetornoAcaoService<IEnumerable<NegocioCDSViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<NegocioCDSViewModel>>> ObterNegociosCDS([FromServices] IDistribuicaoService distribuicaoService)
        {
            var retorno = await distribuicaoService.ObterNegociosCDS();
            if (retorno.Sucesso)
                return Ok(retorno);
            return BadRequest(retorno.ExceptionRetorno);

        }
    }
}
