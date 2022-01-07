using Microsoft.AspNetCore.Mvc;
using RI.Web.Application.Interfaces.Natureza;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Natureza;

namespace RI.Web.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class NaturezaController : Controller
    {
        [HttpGet("ObterNaturezas")]
        [ProducesResponseType(typeof(RetornoAcaoService<IEnumerable<NaturezaViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<NaturezaViewModel>>> ObterTiposPrenotacao([FromServices] INaturezaService naturezaService)
        {
            var retorno = await naturezaService.ObterNaturezas();
            if (retorno.Sucesso)
                return Ok(retorno);
            return BadRequest(retorno.ExceptionRetorno);

        }


    }
}
