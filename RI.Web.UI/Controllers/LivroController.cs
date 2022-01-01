using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.UI.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService livroService;
        public LivroController(ILivroService livroService) => this.livroService = livroService;

        [HttpGet]
        public async Task<IActionResult> GerenciarLivro()
        {
            var retorno = await ObterLivros();
            if (retorno.Sucesso)
                return View(retorno.Result);
            else
                return BadRequest(retorno.MensagemRetorno);
        }

        public async Task<RetornoAcaoService<IEnumerable<LivroViewModel>>> ObterLivros()
        {
            var retornoLivros = new RetornoAcaoService<IEnumerable<LivroViewModel>>();
            var retornoLivrosTJ = new RetornoAcaoService<IEnumerable<LivroTJViewModel>>();
            var retornoLivro = await RequisicaoAPI("Livro/ObterLivros");
            var retornoLivroTJ = await RequisicaoAPI("Livro/ObterLivrosTJ");
            if (retornoLivro.IsSuccessStatusCode && retornoLivroTJ.IsSuccessStatusCode)
            {
                retornoLivros = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<LivroViewModel>>>(await retornoLivro.Content.ReadAsStringAsync());
                retornoLivrosTJ = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<LivroTJViewModel>>>(await retornoLivroTJ.Content.ReadAsStringAsync());
                ViewBag.LivrosTJ = retornoLivrosTJ?.Result;
                if (retornoLivros is not null && retornoLivros.Sucesso && retornoLivrosTJ is not null && retornoLivrosTJ.Sucesso)
                    return retornoLivros;
            }

            var retornoLivrosErro = new RetornoAcaoService<IEnumerable<LivroViewModel>>();
            retornoLivrosErro.Sucesso = false;
            retornoLivrosErro.MensagemRetorno = $"Erro ao consumir a API. {retornoLivro.ReasonPhrase}-{retornoLivro.ReasonPhrase}";
            return retornoLivrosErro;
        }

        private async Task<HttpResponseMessage> RequisicaoAPI(string Metodo)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(GetUrlAPI(Metodo));
                return response;
            }
        }

        public string GetUrlAPI(string action)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json");
            var config = builder.Build();

            return config.GetSection("ApiSettings:Url").Value + action;
        }
    }
}