using Microsoft.AspNetCore.Mvc;
using RI.Application.ViewModels.Livro;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(RetornoAcaoService<IEnumerable<LivroViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<LivroViewModel>>> ObterLivros([FromServices] ILivroService livroService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await livroService.ObterLivros();
                if (retorno.Sucesso)
                    return Ok(retorno);
                return BadRequest(retorno.ExceptionRetorno);
            }

            return BadRequest(ModelState);
        }


        [Route("[action]/{livroTJ}")]
        [HttpGet]
        [ProducesResponseType(typeof(RetornoAcaoService<IEnumerable<LivroTJViewModel>>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<LivroTJViewModel>>> ObterLivrosTJ(bool livroTJ, [FromServices] ILivroService livroService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await livroService.ObterLivrosTJ();
                if (retorno.Sucesso)
                    return Ok(retorno);
                return BadRequest(retorno.ExceptionRetorno);
            }

            return BadRequest(ModelState);
        }
    }
}
