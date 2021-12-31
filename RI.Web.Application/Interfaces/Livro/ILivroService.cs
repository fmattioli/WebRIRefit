using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Acoes;

namespace RI.Web.Application.Interfaces.Livro
{
    public interface ILivroService
    {
        Task<RetornoAcaoService<IEnumerable<LivroViewModel>>> ObterLivros();
    }
}
