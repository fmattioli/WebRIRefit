using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Distribuicao;

namespace RI.Web.Application.Interfaces.Distribuicao
{
    public interface IDistribuicaoService
    {
        Task<RetornoAcaoService<IEnumerable<NegocioCDSViewModel>>> ObterNegociosCDS();
    }
}
