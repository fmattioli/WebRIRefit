using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Infra.Data.ConfigDB
{
    public class ConfigDapper
    {
        public IDbConnection Connection { get; set; }
        public ConfigDapper()
        {
            Connection = new SqlConnection(@"Data Source=SPCM-DESENV-RI\S2019;Initial Catalog=WEBRI_5RISP;Integrated Security=false;User Id=webri;Password=webri;Connection Timeout=30;");
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

        ~ConfigDapper()
        {
            Dispose(false);
        }
    }
}
