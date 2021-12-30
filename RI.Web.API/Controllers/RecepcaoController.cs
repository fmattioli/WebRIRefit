using Microsoft.AspNetCore.Mvc;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.Interfaces.Titulo;
using RI.Web.Application.ViewModels.Recepcao;

namespace RI.Web.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class RecepcaoController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RecepcaoViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObterRecepcao([FromQuery] TituloBasicoViewModel titulo, [FromServices] IRecepcaoService recepcaoService)
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
