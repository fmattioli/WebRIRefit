using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Natureza;

namespace RI.Web.Application.Interfaces.Natureza
{
    public interface INaturezaService
    {
        Task<RetornoAcaoService<IEnumerable<NaturezaViewModel>>> ObterNaturezas();
    }
}
