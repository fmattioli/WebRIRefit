using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Infra.Data.ConfigDB
{
    public class ConfigDapper : IDisposable
    {
        private readonly IConfiguration configuration;

        public IDbConnection Connection
        {
            get { return new SqlConnection(configuration.GetConnectionString("WebRI")); }
            set { }
        }
        public ConfigDapper(IConfiguration configuration)
        {
            this.configuration = configuration;
            Connection.Open();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
