using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Domain.Entities.Acoes;

namespace RI.Web.Application.Interfaces.Recepcao
{
    public interface IRecepcaoService
    {
        Task<RetornoAcao<IEnumerable<RecepcaoViewModel>>> ObterRecepcao(TituloViewModel tituloViewModel);
    }
}
