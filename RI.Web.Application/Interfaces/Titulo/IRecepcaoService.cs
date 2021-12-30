using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.ViewModels.Recepcao;

namespace RI.Web.Application.Interfaces.Titulo
{
    public interface IRecepcaoService
    {
        Task<RecepcaoViewModel> ObterRecepcao(TituloBasicoViewModel tituloViewModel);
    }
}
