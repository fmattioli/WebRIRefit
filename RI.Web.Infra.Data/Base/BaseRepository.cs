using RI.Web.Domain.Entities.Acao;
using RI.Web.Domain.Interfaces.Base;
using RI.Web.Infra.Data.DapperConfig;
using System.Data.SqlClient;
using System.Text;

namespace RI.Web.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbSession _db;
        public StringBuilder SQL { get; set; } = new StringBuilder();
        public List<SqlParameter> Lista = new List<SqlParameter>();

        public BaseRepository(DbSession _db)
        {
            this._db = _db;
        }

        public Task<RetornoAcao<T>> ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
