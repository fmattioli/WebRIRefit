using Microsoft.AspNetCore.Mvc;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<LivroViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ObterRecepcao([FromServices] ILivroService livroService)
        {
            if (ModelState.IsValid)
            {
                var retorno = await livroService.ObterLivro();
                return Ok(retorno);
            }

            return BadRequest(ModelState);
        }
    }
}
