using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.TipoPrenotacao;
using RI.Web.Domain.Entities.Acoes;

namespace RI.Web.Application.Interfaces.TipoPrenotacao
{
    public interface ITipoPrenotacaoService
    {
        Task<RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>> ObterTiposPrenotacao();
    }
}
