using AutoMapper;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.Interfaces.Recepcao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Interfaces.TipoPrenotacao;
using RI.Web.Domain.Interfaces.Titulo;

namespace RI.Web.Application.Services.Recepcao
{
    public class RecepcaoService : IRecepcaoService
    {
        private readonly IRecepcaoRepository recepcaoRepository;
        private readonly IMapper mapper;
        public RecepcaoService(IRecepcaoRepository recepcaoRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.recepcaoRepository = recepcaoRepository;
        }


        public async Task<RetornoAcaoService<IEnumerable<RecepcaoViewModel>>> ObterRecepcao(TituloViewModel tituloViewModel)
        {
            await Task.Run(() =>
            {
                return null;
            });

            return new RetornoAcaoService<IEnumerable<RecepcaoViewModel>>();
        }


        public async Task<RetornoAcaoService<DateTime>> CalcularDataPrevisao(int NaturezaId)
        {
            var retorno = new RetornoAcaoService<DateTime>();
            var retornoRepository = await recepcaoRepository.CalcularDataPrevisaoEntrega(NaturezaId);
            if (retornoRepository.Sucesso)
            {
                retorno.Result = retornoRepository.Result;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoRepository.ExceptionRetorno;
            retorno.MensagemRetorno = retornoRepository.MensagemRetorno;
            return retorno;
        }

        public async Task<RetornoAcaoService<DateTime>> CalcularDataExpiraNatureza(int NaturezaId, int IdTipoPrenotacao)
        {
            var retorno = new RetornoAcaoService<DateTime>();
            var retornoRepository = await recepcaoRepository.CalcularDataExpiraNatureza(NaturezaId, IdTipoPrenotacao);
            if (retornoRepository.Sucesso)
            {
                retorno.Result = retornoRepository.Result;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoRepository.ExceptionRetorno;
            retorno.MensagemRetorno = retornoRepository.MensagemRetorno;
            return retorno;
        }

    }
}
