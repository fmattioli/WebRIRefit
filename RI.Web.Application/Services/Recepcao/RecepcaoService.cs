using AutoMapper;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.Interfaces.Recepcao;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Interfaces.TipoPrenotacao;
using RI.Web.Domain.Interfaces.Titulo;

namespace RI.Web.Application.Services.Recepcao
{
    public class RecepcaoService : IRecepcaoService
    {
        public RecepcaoService()
        {
        }

        public async Task<RetornoAcao<IEnumerable<RecepcaoViewModel>>> ObterRecepcao(TituloViewModel tituloViewModel)
        {
            await Task.Run(() =>
            {
                return null;
            });

            return new RetornoAcao<IEnumerable<RecepcaoViewModel>>();
        }


    }
}
