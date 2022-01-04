using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.UI.Controllers
{
    public class LivroController : BaseController<LivroViewModel>
    {
        private readonly ILivroService livroService;
        public LivroController(ILivroService livroService) => this.livroService = livroService;

        [HttpGet]
        public async Task<IActionResult> GerenciarLivro()
        {
            var retorno = await ObterLivros();
            if (retorno.Sucesso && retorno.Result is not null)
            {
                var retornoPaginacao = ConfigurarPaginacao(retorno.Result, retorno?.Result?.Count(), 10, 1);
                return View(retornoPaginacao);
            }

            return BadRequest(retorno.MensagemRetorno);
        }

        [HttpGet("{Pagina}", Name = "GerenciarLivro")]
        public async Task<IActionResult> GerenciarLivro(int Pagina)
        {
            var retorno = await ObterLivros();
            if (retorno.Sucesso && retorno.Result is not null)
            {
                var retornoPaginacao = ConfigurarPaginacao(retorno.Result, retorno?.Result?.Count(), 10, Pagina);
                return View("GerenciarLivro", retornoPaginacao);
            }
            return BadRequest(retorno.MensagemRetorno);
        }

        public async Task<RetornoAcaoService<IEnumerable<LivroViewModel>>> ObterLivros()
        {
            var retornoLivro = await RequisicaoAPI("Livro/ObterLivros");
            var retornoLivroTJ = await RequisicaoAPI("Livro/ObterLivrosTJ");
            if (retornoLivro.IsSuccessStatusCode && retornoLivroTJ.IsSuccessStatusCode)
            {
                var retornoLivros = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<LivroViewModel>>>(await retornoLivro.Content.ReadAsStringAsync());
                var retornoLivrosTJ = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<LivroTJViewModel>>>(await retornoLivroTJ.Content.ReadAsStringAsync());

                if (retornoLivros is not null && retornoLivros.Sucesso && retornoLivrosTJ is not null && retornoLivrosTJ.Sucesso)
                {
                    ViewBag.LivrosTJ = retornoLivrosTJ.Result;
                    return retornoLivros;
                }
            }

            var retornoLivrosErro = new RetornoAcaoService<IEnumerable<LivroViewModel>>
            {
                Sucesso = false,
                MensagemRetorno = $"Erro ao consumir a API. {retornoLivro.ReasonPhrase}-{retornoLivro.ReasonPhrase}"
            };
            return retornoLivrosErro;
        }

    }
}