using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Interfaces.Livro;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.Repositories.Base;

namespace RI.Web.Infra.Data.Livro
{
    public class LivroTJRepository : BaseRepository<LivroTJ>, ILivroTJRepository
    {
        public LivroTJRepository(ConfigDapper _db) : base(_db)
        {
        }
    }
}
