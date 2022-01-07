using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.Recepcao.Titulo;

namespace RI.Web.Application.Interfaces.Recepcao
{
    public interface IRecepcaoService
    {
        Task<RetornoAcaoService<IEnumerable<RecepcaoViewModel>>> ObterRecepcao(TituloViewModel tituloViewModel);
        Task<RetornoAcaoService<DateTime>> CalcularDataPrevisao(int NaturezaId);
        Task<RetornoAcaoService<DateTime>> CalcularDataExpiraNatureza(int NaturezaId, int IdTipoPrenotacao);
    }
}
