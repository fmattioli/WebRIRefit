using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Acao;

namespace RI.Web.Application.Interfaces.Livro
{
    public interface ILivroService
    {
        Task<RetornoAcao<IEnumerable<LivroViewModel>>> ObterLivro();
    }
}
