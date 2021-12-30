using Dapper;
using RI.Web.Domain.Entities.Acao;
using RI.Web.Domain.Interfaces.Base;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.DapperConfig;
using System.Data.SqlClient;
using System.Text;

namespace RI.Web.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ConfigDapper _db;
        public StringBuilder SQL { get; set; } = new StringBuilder();
        public List<SqlParameter> Lista = new List<SqlParameter>();

        public BaseRepository(ConfigDapper _db)
        {
            this._db = _db;
        }

        public async Task<RetornoAcao<IEnumerable<T>>> ObterTodos(string tabela)
        {
            var retorno = new RetornoAcao<IEnumerable<T>>();
            try
            {
                using (var conn = _db.Connection)
                {
                    SQL.Clear();
                    SQL.AppendLine($"SELECT * FROM {tabela}");
                    var resultado = (await conn.QueryAsync<T>(SQL.ToString())).ToList();
                    retorno.Sucesso = true;
                    retorno.Result = resultado;
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }
    }
}
