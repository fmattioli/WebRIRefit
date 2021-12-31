using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Interfaces.Livro;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.Repositories.Base;

namespace RI.Web.Infra.Data.Livro
{
    public class LivroRepository : BaseRepository<LivroEntity>, ILivroRepository
    {
        public LivroRepository(ConfigDapper _db) : base(_db)
        {
        }

    }
}
