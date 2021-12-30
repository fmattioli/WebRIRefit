using RI.Web.Application.RetornoAcaoService;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.Application.Interfaces.Livro
{
    public interface ILivroService
    {
        Task<IEnumerable<LivroViewModel>> ObterLivros();
    }
}
