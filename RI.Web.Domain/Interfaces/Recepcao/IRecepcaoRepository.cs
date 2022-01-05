using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;
using RI.Web.Domain.Interfaces.Base;

namespace RI.Web.Domain.Interfaces.Titulo
{
    public interface IRecepcaoRepository : IBaseRepository<RecepcaoEntity>
    {
        Task<RecepcaoEntity> ObterRecepcao(TituloBasicoEntity Recepcao);
    }
}
