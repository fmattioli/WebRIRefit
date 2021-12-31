using RI.Web.Domain.Entities.Acoes;

namespace RI.Web.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<RetornoAcao<IEnumerable<T>>> ObterTodos(string tabela);
        Task<RetornoAcao<T>> ObterPorId(string tabela, string coluna, string valor);
    }
}
