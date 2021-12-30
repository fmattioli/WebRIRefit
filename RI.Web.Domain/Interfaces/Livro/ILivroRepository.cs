using RI.Web.Domain.Entities.Livro;

namespace RI.Web.Domain.Interfaces.Livro
{
    public interface ILivroRepository
    {
        Task<LivroEntity> ObterLivro(LivroEntity livro);
    }
}
