using RI.Web.Domain.Entities.Natureza;
using RI.Web.Domain.Interfaces.Natureza;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Infra.Data.Natureza
{
    public class NaturezaRepository : BaseRepository<NaturezaEntity>, INaturezaRepository
    {
        public NaturezaRepository(ConfigDapper dapperConfig) : base(dapperConfig)
        {
        }
    }
}
