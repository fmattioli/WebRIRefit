using Dapper;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Interfaces.Base;
using RI.Web.Infra.Data.ConfigDB;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Text;

namespace RI.Web.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ConfigDapper dapper;
        public StringBuilder SQL { get; set; } = new StringBuilder();
        public List<SqlParameter> Lista = new List<SqlParameter>();

        public BaseRepository(ConfigDapper dapperConfig)
        {
            this.dapper = dapperConfig;
            MapDapper();
        }

        public async Task<RetornoAcao<IEnumerable<T>>> ObterTodos(string tabela)
        {
            var retorno = new RetornoAcao<IEnumerable<T>>();
            try
            {
                SQL.Clear();
                SQL.AppendLine($"SELECT * FROM {tabela}");
                var resultado = (await dapper.Connection.QueryAsync<T>(SQL.ToString())).ToList();
                retorno.Sucesso = true;
                retorno.Result = resultado;
                return retorno;

            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

        public async Task<RetornoAcao<T>> ObterPorId(string tabela, string coluna, int valor)
        {
            var retorno = new RetornoAcao<T>();
            try
            {
                SQL.Clear();
                SQL.AppendLine($"SELECT * FROM {tabela} WHERE {coluna} = {valor}");
                var resultado = (await dapper.Connection.QueryFirstOrDefaultAsync<T>(SQL.ToString()));
                retorno.Sucesso = true;
                retorno.Result = resultado;
                return retorno;

            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

        private void MapDapper()
        {
            SqlMapper.SetTypeMap(typeof(T), new CustomPropertyTypeMap(
                            typeof(T), (type, columnName) => type.GetProperties().FirstOrDefault(prop =>
                            prop.GetCustomAttributes(false).OfType<ColumnAttribute>().Any(attr => attr.Name == columnName))));
        }
    }
}
