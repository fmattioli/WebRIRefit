using Microsoft.AspNetCore.Mvc;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.Interfaces.Recepcao;
using RI.Web.Application.Interfaces.TipoPrenotacao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.TipoPrenotacao;

namespace RI.Web.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class RecepcaoController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RecepcaoViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObterRecepcao([FromQuery] TituloViewModel titulo, [FromServices] IRecepcaoService recepcaoService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await recepcaoService.ObterRecepcao(titulo);
                    return Ok(retorno);
            }

            return BadRequest(ModelState);
        }


    }

}
