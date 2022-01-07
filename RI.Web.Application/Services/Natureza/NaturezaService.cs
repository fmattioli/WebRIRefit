using AutoMapper;
using RI.Web.Application.Interfaces.Natureza;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Natureza;
using RI.Web.Domain.Interfaces.Natureza;

namespace RI.Web.Application.Services.Natureza
{
    public class NaturezaService : INaturezaService
    {
        private readonly INaturezaRepository naturezaRepository;
        private readonly IMapper mapper;

        public NaturezaService(INaturezaRepository naturezaService, IMapper mapper)
        {
            this.naturezaRepository = naturezaService;
            this.mapper = mapper;
        }

        public async Task<RetornoAcaoService<IEnumerable<NaturezaViewModel>>> ObterNaturezas()
        {
            var retorno = new RetornoAcaoService<IEnumerable<NaturezaViewModel>>();
            var retornoNaturezas = await naturezaRepository.ObterTodos("tblWRINatureza");
            if (retornoNaturezas.Sucesso)
            {
                var tipoPrenotacao = mapper.Map<IEnumerable<NaturezaViewModel>>(retornoNaturezas.Result);
                retorno.Result = tipoPrenotacao.OrderBy(n => n.Tipo);
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoNaturezas.ExceptionRetorno;
            retorno.MensagemRetorno = retornoNaturezas.MensagemRetorno;
            return retorno;
        }
    }
}
