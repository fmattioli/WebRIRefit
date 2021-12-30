using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.RetornoAcaoService;
using RI.Web.Application.ViewModels;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.Recepcao.Titulo;

namespace RI.Web.Application.Interfaces.Titulo
{
    public interface IRecepcaoService
    {
        Task<RecepcaoViewModel> ObterRecepcao(TituloBasicoViewModel tituloViewModel);
    }
}
