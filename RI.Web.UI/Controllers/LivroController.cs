using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Application.ViewModels.Livro;
using RI.Web.Application.Services.Acoes;

namespace RI.Web.UI.Controllers
{
    public class LivroController : Controller
    {
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
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(GetUrlAPI("livro"));
                    if (response.IsSuccessStatusCode)
                    {
                        var retornoSucesso = new RetornoAcaoService<IEnumerable<LivroViewModel>>();
                        string jsonLivros = await response.Content.ReadAsStringAsync();
                        retornoSucesso = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<LivroViewModel>>>(jsonLivros);
                        if (retornoSucesso is not null && retornoSucesso.Result is not null && retornoSucesso.Sucesso)
                        {
                            return retornoSucesso;
                        }
                    }

                    var retornoFalhaComunicacao = new RetornoAcaoService<IEnumerable<LivroViewModel>>();
                    retornoFalhaComunicacao.Sucesso = false;
                    retornoFalhaComunicacao.MensagemRetorno = "Falha ao consumir  a API";
                    return retornoFalhaComunicacao;
                }
            }
            catch (Exception ex)
            {
                var retornoException = new RetornoAcaoService<IEnumerable<LivroViewModel>>();
                retornoException.ExceptionRetorno = ex;
                retornoException.MensagemRetorno = ex.Message;
                return retornoException;
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