using AutoMapper;
using RI.Web.Application.Interfaces.TipoPrenotacao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.TipoPrenotacao;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Interfaces.TipoPrenotacao;

namespace RI.Web.Application.Services.TipoPrenotacao
{
    public class TipoPrenotacaoService : ITipoPrenotacaoService
    {
        private readonly ITipoPrenotacaoRepository tipoPrenotacaoRepository;
        private readonly IMapper mapper;
        public TipoPrenotacaoService(ITipoPrenotacaoRepository tipoPrenotacaoRepository, IMapper mapper)
        {
            this.tipoPrenotacaoRepository = tipoPrenotacaoRepository;
            this.mapper = mapper;
        }
        public async Task<RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>> ObterTiposPrenotacao()
        {
            var retorno = new RetornoAcaoService<IEnumerable<TipoPrenotacaoViewModel>>();

            var retornoTipoPrenotacao = await tipoPrenotacaoRepository.ObterTodos("tblWRITipoPrenotacao");
            if (retornoTipoPrenotacao.Sucesso)
            {
                var tipoPrenotacao = mapper.Map<IEnumerable<TipoPrenotacaoViewModel>>(retornoTipoPrenotacao.Result);
                retorno.Result = tipoPrenotacao;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoTipoPrenotacao.ExceptionRetorno;
            retorno.MensagemRetorno = retornoTipoPrenotacao.MensagemRetorno;
            return retorno;
        }
    }
}
