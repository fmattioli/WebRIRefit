using Microsoft.AspNetCore.Mvc;
using RI.Web.Application.Interfaces.TipoPrenotacao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.TipoPrenotacao;

namespace RI.Web.API.Controllers
{
    public class TipoPrenotacaoController : Controller
    {
        [HttpGet("ObterTiposPrenotacao")]
        [ProducesResponseType(typeof(RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TipoPrenotacaoViewModel>>> ObterTiposPrenotacao([FromServices] ITipoPrenotacaoService tipoPrentocaoService)
        {
            var retorno = await tipoPrentocaoService.ObterTiposPrenotacao();
            if (retorno.Sucesso)
                return Ok(retorno);
            return BadRequest(retorno.ExceptionRetorno);

        }
    }
}
