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
        private readonly IRecepcaoRepository recepcaoRepository;
        private readonly ITipoPrenotacaoRepository tipoPrenotacaoRepository;
        private readonly IMapper mapper;
        public RecepcaoService(IRecepcaoRepository recepcaoRepository, ITipoPrenotacaoRepository tipoPrenotacaoRepository, IMapper mapper)
        {
            this.recepcaoRepository = recepcaoRepository;
            this.tipoPrenotacaoRepository = tipoPrenotacaoRepository;
            this.mapper = mapper;
        }

        public async Task<RetornoAcao<IEnumerable<RecepcaoViewModel>>> ObterRecepcao(TituloViewModel tituloViewModel)
        {
            return null;
        }


    }
}
