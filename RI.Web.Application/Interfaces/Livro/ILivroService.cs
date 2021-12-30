using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.Application.Interfaces.Livro
{
    public interface ILivroService
    {
        Task<LivroViewModel> ObterLivro(LivroViewModel livroViewModel);
    }
}
