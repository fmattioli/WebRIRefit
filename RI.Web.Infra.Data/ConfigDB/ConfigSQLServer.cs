using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RI.Web.Infra.Data.DapperConfig
{
    public class ConfigSQLServer : IDisposable
    {
        private readonly IConfiguration configuration;
        private IDbConnection Connection
        {
            get { return new SqlConnection(configuration.GetConnectionString("WebRI")); }
            set { }
        }
        public ConfigSQLServer(IConfiguration configuration)
        {
            this.configuration = configuration;
            Connection.Open();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Connection.Dispose();
            Connection.Close();
        }

        public async Task<SqlDataReader> RetornarDadosSQLServer(string command, List<SqlParameter> Parametros)
        {
            try
            {
                SqlConnection connection = GetConnectionSQLServer();

                await connection.OpenAsync();
                SqlCommand cmd = new SqlCommand(command, connection)
                {
                    CommandTimeout = 90
                };
                if (Parametros != null)
                    foreach (SqlParameter Parametro in Parametros)
                        cmd.Parameters.Add(Parametro);
                return await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            }
            catch
            {
                throw;
            }
        }

        public SqlConnection GetConnectionSQLServer()
        {
            try
            {
                return new SqlConnection(configuration.GetConnectionString("WebRI"));
            }
            catch
            {
                throw;
            }
        }

        ~ConfigSQLServer()
        {
            Dispose(false);
        }
    }
}
