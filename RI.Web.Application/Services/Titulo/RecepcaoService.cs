using AutoMapper;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.Interfaces.Titulo;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;
using RI.Web.Domain.Interfaces.Titulo;

namespace RI.Web.Application.Services.Titulo
{
    public class RecepcaoService : IRecepcaoService
    {
        private readonly IRecepcaoRepository tituloRepository;
        private readonly IMapper mapper;
        public RecepcaoService(IRecepcaoRepository tituloRepository, IMapper mapper)
        {
            this.tituloRepository = tituloRepository;
            this.mapper = mapper;
        }

        public async Task<RecepcaoViewModel> ObterRecepcao(TituloBasicoViewModel tituloViewModel)
        {
            var retorno = new RecepcaoViewModel();
            try
            {
                var mapTitulo = mapper.Map<TituloBasicoEntity>(tituloViewModel);
                var retornoAcao = await tituloRepository.ObterRecepcao(mapTitulo);
                retorno = mapper.Map<RecepcaoViewModel>(retornoAcao);
                return retorno;
            }
            catch 
            {
                return retorno;
            }
        }
    }
}
