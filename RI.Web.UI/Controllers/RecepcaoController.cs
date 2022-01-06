using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Distribuicao;
using RI.Web.Application.ViewModels.Natureza;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.TipoPrenotacao;

namespace RI.Web.UI.Controllers
{
    public class RecepcaoController : BaseController<RecepcaoViewModel>
    {
        public async Task<IActionResult> Recepcao()
        {
            #region Popular selects 
            await ObterTiposProtocolos();
            await ObterNaturezas();
            await ObterCDSNegocios();
            #endregion
            return View();
        }

        #region Preencher Selects
        public async Task<RetornoAcaoService> ObterTiposProtocolos()
        {
            var retornoAcaoTiposPrenotacoes = await RequisicaoAPI("TipoPrenotacao/ObterTiposPrenotacao");
            if (retornoAcaoTiposPrenotacoes.IsSuccessStatusCode)
            {
                var tiposPrenotacoes = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>>(await retornoAcaoTiposPrenotacoes.Content.ReadAsStringAsync());
                if (tiposPrenotacoes is not null)
                {
                    ViewBag.TiposPrenotacoes = tiposPrenotacoes.Result;
                }
            }

            var retornoLivrosErro = new RetornoAcaoService()
            {
                Sucesso = false,
                MensagemRetorno = $"Erro ao consumir a API. {retornoAcaoTiposPrenotacoes.ReasonPhrase}-{retornoAcaoTiposPrenotacoes.ReasonPhrase}"
            };
            return retornoLivrosErro;
        }

        public async Task<RetornoAcaoService> ObterNaturezas()
        {
            var retornoAcaoNaturezas = await RequisicaoAPI("Natureza/ObterNaturezas");
            if (retornoAcaoNaturezas.IsSuccessStatusCode)
            {
                var naturezas = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<NaturezaViewModel>>>(await retornoAcaoNaturezas.Content.ReadAsStringAsync());
                if (naturezas is not null)
                {
                    ViewBag.Naturezas = naturezas.Result;
                }
            }

            var retornoLivrosErro = new RetornoAcaoService()
            {
                Sucesso = false,
                MensagemRetorno = $"Erro ao consumir a API. {retornoAcaoNaturezas.ReasonPhrase}-{retornoAcaoNaturezas.ReasonPhrase}"
            };
            return retornoLivrosErro;
        }


        public async Task<RetornoAcaoService> ObterCDSNegocios()
        {
            var retornoAcaoNaturezas = await RequisicaoAPI("Distribuicao/ObterNegociosCDS");
            if (retornoAcaoNaturezas.IsSuccessStatusCode)
            {
                var naturezas = JsonConvert.DeserializeObject<RetornoAcaoService<IEnumerable<NegocioCDSViewModel>>>(await retornoAcaoNaturezas.Content.ReadAsStringAsync());
                if (naturezas is not null)
                {
                    ViewBag.NegociosCDS = naturezas.Result;
                }
            }

            var retornoLivrosErro = new RetornoAcaoService()
            {
                Sucesso = false,
                MensagemRetorno = $"Erro ao consumir a API. {retornoAcaoNaturezas.ReasonPhrase}-{retornoAcaoNaturezas.ReasonPhrase}"
            };
            return retornoLivrosErro;
        }
        #endregion
    }
}
