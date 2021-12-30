
using RI.Web.Domain.Entities.Acao;

namespace RI.Web.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<RetornoAcao<T>> ObterPorId(int Id);
    }
}
