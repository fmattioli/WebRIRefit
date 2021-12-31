using System.Data;
using System.Data.SqlClient;

namespace RI.Web.Infra.Data.DapperConfig
{
    public class ConfigADO : IDisposable
    {
        protected static string? ConnectionString { get; set; }

        public IDbConnection Connection { get; set; }
        public ConfigADO()
        {
            Connection = new SqlConnection(@"Data Source=SPCM-DESENV-RI\S2019;Initial Catalog=WEBRI_5RISP;Integrated Security=false;User Id=webri;Password=webri;Connection Timeout=30;");
            Connection.Open();
            Inicializar();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public static void Inicializar()
        {
            ConnectionString = @"Data Source=SPCM-DESENV-RI\S2019;Initial Catalog=WEBRI_5RISP;Integrated Security=false;User Id=webri;Password=webri;Connection Timeout=30;";
        }

        protected virtual void Dispose(bool disposing)
        {
            Connection.Dispose();
            Connection.Close();
        }

        public async Task<SqlDataReader> RetornarDadosSQLServer(string command, List<SqlParameter> Parametros)
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

        public async Task<SqlDataReader> RetornarDadosSQLServer(string command)
        {
            SqlConnection connection = GetConnectionSQLServer();

            await connection.OpenAsync();
            SqlCommand cmd = new SqlCommand(command, connection)
            {
                CommandTimeout = 90
            };

            return await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);

        }
        public SqlConnection GetConnectionSQLServer()
        {
            try
            {
                return new SqlConnection(ConnectionString);
            }
            catch
            {
                throw;
            }
        }

        ~ConfigADO()
        {
            Dispose(false);
        }
    }
}
