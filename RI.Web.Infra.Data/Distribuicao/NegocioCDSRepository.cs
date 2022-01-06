using RI.Web.Domain.Entities.Distribuicao;
using RI.Web.Domain.Interfaces.Distribuicao;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Infra.Data.Distribuicao
{
    public class NegocioCDSRepository : BaseRepository<NegocioCDS>, INegocioCDSRepository
    {
        public NegocioCDSRepository(ConfigDapper dapperConfig) : base(dapperConfig)
        {
        }
    }
}
