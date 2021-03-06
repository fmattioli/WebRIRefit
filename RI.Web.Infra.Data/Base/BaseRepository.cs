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
        public List<SqlParameter> Lista = new();

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
                using var conn = dapper.Connection;
                SQL.Clear();
                SQL.AppendLine($"SELECT * FROM {tabela}");
                var resultado = (await conn.QueryAsync<T>(SQL.ToString())).ToList();
                retorno.Sucesso = true;
                retorno.Result = resultado;
                conn.Close();
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
                using var conn = dapper.Connection;
                SQL.Clear();
                SQL.AppendLine($"SELECT * FROM {tabela} WHERE {coluna} = {valor}");
                var resultado = (await conn.QueryFirstOrDefaultAsync<T>(SQL.ToString()));
                retorno.Sucesso = true;
                retorno.Result = resultado;
                conn.Close();
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


        public async Task<RetornoAcao<int>> ObterValorInteiro(string Tabela, string Coluna, int Valor)
        {
            var retorno = new RetornoAcao<int>();
            try
            {
                using var conn = dapper.Connection;
                SQL.Clear();
                SQL.AppendLine($"SELECT * FROM {Tabela} WHERE {Coluna} = {Valor}");
                var resultado = (await conn.QueryFirstOrDefaultAsync<int>(SQL.ToString()));
                retorno.Sucesso = true;
                retorno.Result = resultado;
                conn.Close();
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

        public async Task<RetornoAcao<bool>> ObterValorBooleano(string Tabela, string Coluna, int Valor)
        {
            var retorno = new RetornoAcao<bool>();
            try
            {
                using var conn = dapper.Connection;
                SQL.Clear();
                SQL.AppendLine($"SELECT * FROM {Tabela} WHERE {Coluna} = {Valor}");
                var resultado = (await conn.QueryFirstOrDefaultAsync<bool>(SQL.ToString()));
                retorno.Sucesso = true;
                retorno.Result = resultado;
                conn.Close();
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

        public void MapDapper()
        {
            SqlMapper.SetTypeMap(typeof(T), new CustomPropertyTypeMap(
                            typeof(T), (type, columnName) => type.GetProperties().FirstOrDefault(prop =>
                            prop.GetCustomAttributes(false).OfType<ColumnAttribute>().Any(attr => attr.Name == columnName))));
        }

        public async Task<RetornoAcao> Atualizar(T Entidade)
        {
            var retorno = new RetornoAcao();
            try
            {
                SQL.Clear();
                var propriedades = Entidade.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(ColumnAttribute))).ToList();
                string lastItem = propriedades[^1].Name;
                SQL.AppendLine($"Update {(Entidade.GetType().GetCustomAttributes(true)[2] as TableAttribute)?.Name}");
                SQL.AppendLine($"SET");
                foreach (var propridade in propriedades)
                {
                    if (propridade.Name != "Id" && propridade.Name != "Ativo")
                    {
                        var nomeColuna = (propridade.GetCustomAttributes(true)[0] as ColumnAttribute)?.Name;
                        if (propridade.Name != lastItem)
                            SQL.AppendLine($"{nomeColuna}='{propridade.GetValue(Entidade)}',");
                        else
                            SQL.AppendLine($"{nomeColuna}='{propridade.GetValue(Entidade)}'");
                    }
                }
                SQL.AppendLine($"Where PK_Id = {propriedades.FirstOrDefault(a => a.Name == "Id")?.GetValue(Entidade)}");
                using var conn = dapper.Connection;
                var resultado = (await conn.ExecuteAsync(SQL.ToString()));
                retorno.Sucesso = true;
                conn.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

        public async Task<RetornoAcao> Desativar(string Tabela, int Valor)
        {
            var retorno = new RetornoAcao();
            try
            {
                using var conn = dapper.Connection;
                SQL.Clear();
                SQL.AppendLine($"Update {Tabela} SET Ativo = 0 Where PK_Id = {Valor}");
                var resultado = (await conn.ExecuteAsync(SQL.ToString()));
                retorno.Sucesso = true;
                conn.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

        public async Task<RetornoAcao> Deletar(string Tabela, int Valor)
        {
            var retorno = new RetornoAcao();
            try
            {
                using var conn = dapper.Connection;
                SQL.Clear();
                SQL.AppendLine($"DELETE FROM {Tabela} WHERE PK_Id = {Valor}");
                var resultado = (await conn.ExecuteAsync(SQL.ToString()));
                retorno.Sucesso = true;
                conn.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

        public async Task<RetornoAcao> Inserir(T Entidade)
        {
            var retorno = new RetornoAcao();
            try
            {
                SQL.Clear();
                var propriedades = Entidade.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(ColumnAttribute))).ToList();
                string lastItem = propriedades[^1].Name;
                SQL.AppendLine($"INSERT INTO {(Entidade.GetType().GetCustomAttributes(true)[2] as TableAttribute)?.Name}");
                SQL.AppendLine($"(");
                foreach (var propridade in propriedades)
                {
                    if (propridade.Name != "Id")
                    {
                        var nomeColuna = (propridade.GetCustomAttributes(true)[0] as ColumnAttribute)?.Name;
                        if (propridade.Name != lastItem)
                            SQL.AppendLine($"{nomeColuna},");
                        else
                            SQL.AppendLine($"{nomeColuna}");
                    }
                }
                SQL.AppendLine($")");
                SQL.AppendLine($"VALUES");
                SQL.AppendLine($"(");
                foreach (var propridade in propriedades)
                {
                    if (propridade.Name != "Id")
                    {
                        var nomeColuna = (propridade.GetCustomAttributes(true)[0] as ColumnAttribute)?.Name;
                        if (propridade.Name != lastItem)
                            SQL.AppendLine($"'{propridade.GetValue(Entidade)}',");
                        else
                            SQL.AppendLine($"'{propridade.GetValue(Entidade)}'");
                    }
                }
                SQL.AppendLine($")");
                using var conn = dapper.Connection;
                var resultado = (await conn.ExecuteAsync(SQL.ToString()));
                retorno.Sucesso = true;
                conn.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

    }
}
