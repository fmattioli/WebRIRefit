using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.TipoPrenotacao;

namespace RI.Web.UI.Controllers
{
    public class RecepcaoController : BaseController<RecepcaoViewModel>
    {
        public async Task<IActionResult> Recepcao()
        {
            await ObterTiposProtocolos();
            return View();
        }

        public async Task<RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>> ObterTiposProtocolos()
        {
            var retornoAcaoTiposPrenotacoes = await RequisicaoAPI("TipoPrenotacao/ObterTiposPrenotacao");
            if (retornoAcaoTiposPrenotacoes.IsSuccessStatusCode)
            {
                var tiposPrenotacoes = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>>(await retornoAcaoTiposPrenotacoes.Content.ReadAsStringAsync());
                if (tiposPrenotacoes is not null && tiposPrenotacoes.Sucesso)
                {
                    ViewBag.TiposPrenotacoes = tiposPrenotacoes.Result;
                    return tiposPrenotacoes;
                }
            }

            var retornoLivrosErro = new RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>
            {
                Sucesso = false,
                MensagemRetorno = $"Erro ao consumir a API. {retornoAcaoTiposPrenotacoes.ReasonPhrase}-{retornoAcaoTiposPrenotacoes.ReasonPhrase}"
            };
            return retornoLivrosErro;
        }
    }
}
