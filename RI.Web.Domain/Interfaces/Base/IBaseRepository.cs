using RI.Web.Domain.Entities.Acoes;

namespace RI.Web.Domain.Interfaces.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<RetornoAcao<IEnumerable<T>>> ObterTodos(string tabela);
        Task<RetornoAcao<T>> ObterPorId(string Tabela, string Coluna, int Valor);
        Task<RetornoAcao> Atualizar(T Entidade);
        Task<RetornoAcao> Desativar(string Tabela, int Valor);
        Task<RetornoAcao> Deletar(string Tabela, int Valor);
    }
}
