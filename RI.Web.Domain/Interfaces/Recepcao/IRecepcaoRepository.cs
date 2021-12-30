using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;

namespace RI.Web.Domain.Interfaces.Titulo
{
    public interface IRecepcaoRepository
    {
        Task<RecepcaoEntity> ObterRecepcao(TituloBasicoEntity Recepcao);
    }
}
