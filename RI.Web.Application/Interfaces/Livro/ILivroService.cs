using RI.Application.ViewModels.Livro;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.Application.Interfaces.Livro
{
    public interface ILivroService
    {
        Task<RetornoAcaoService<IEnumerable<LivroViewModel>>> ObterLivros();
        Task<RetornoAcaoService<IEnumerable<LivroTJViewModel>>> ObterLivrosTJ();
    }
}
