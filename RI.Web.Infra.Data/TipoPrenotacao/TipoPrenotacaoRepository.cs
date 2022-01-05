using RI.Web.Domain.Entities.TipoPrenotacao;
using RI.Web.Domain.Interfaces.TipoPrenotacao;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Infra.Data.TipoPrenotacao
{
    public class TipoPrenotacaoRepository : BaseRepository<TipoPrenotacaoEntity>, ITipoPrenotacaoRepository
    {
        public TipoPrenotacaoRepository(ConfigDapper dapperConfig) : base(dapperConfig)
        {
        }
    }
}
