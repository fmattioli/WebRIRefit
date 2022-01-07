using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RI.Web.Application.Interfaces.Recepcao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Application.ViewModels.Recepcao.Titulo;

namespace RI.Web.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class RecepcaoController : Controller
    {

        //[ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet("{TituloViewModel}", Name = "ObterRecepcao")]
        [ProducesResponseType(typeof(RetornoAcaoService<IEnumerable<LivroTJViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<LivroTJViewModel>>> ObterRecepcao(TituloViewModel tituloViewModel, [FromServices] IRecepcaoService recepcaoService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await recepcaoService.ObterRecepcao(tituloViewModel);
                if (retorno.Sucesso)
                    return Ok(retorno);
                return BadRequest(retorno.ExceptionRetorno);
            }

            return BadRequest(ModelState);
        }

        [HttpGet("CalcularPrazoPorNatureza/{NaturezaId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(RetornoAcaoService<LivroViewModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<LivroViewModel>> CalcularPrazoPorNatureza(int NaturezaId, [FromServices] IRecepcaoService recepcaoService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await recepcaoService.CalcularDataPrevisao(NaturezaId);
                if (retorno.Sucesso)
                    return Ok(retorno);
                return BadRequest(retorno.MensagemRetorno);
            }

            return BadRequest(ModelState);
        }

        [HttpGet("CalcularPrazoPorNatureza/{NaturezaId}/{IdTipoPrenotacao}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(RetornoAcaoService<LivroViewModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<LivroViewModel>> CalcularDataExpiraNatureza(int NaturezaId, int IdTipoPrenotacao, [FromServices] IRecepcaoService recepcaoService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await recepcaoService.CalcularDataExpiraNatureza(NaturezaId, IdTipoPrenotacao);
                if (retorno.Sucesso)
                    return Ok(retorno);
                return BadRequest(retorno.MensagemRetorno);
            }

            return BadRequest(ModelState);
        }
    }
}
