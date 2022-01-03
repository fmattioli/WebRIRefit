using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Interfaces.Base;

namespace RI.Web.Domain.Interfaces.Livro
{
    public interface ILivroRepository : IBaseRepository<LivroEntity>
    {
        public Task<RetornoAcao<IEnumerable<LivroEntity>>> ObterLivros();
        public Task<RetornoAcao> InserirLivro(LivroEntity Livro);
    }
}
