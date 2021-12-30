
using RI.Web.Domain.Entities.Acao;

namespace RI.Web.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<RetornoAcao<IEnumerable<T>>> ObterTodos(string tabela);
    }
}
