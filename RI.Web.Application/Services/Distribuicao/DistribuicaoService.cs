using AutoMapper;
using RI.Web.Application.Interfaces.Distribuicao;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Distribuicao;
using RI.Web.Domain.Interfaces.Distribuicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Application.Services.Distribuicao
{
    public class DistribuicaoService : IDistribuicaoService
    {
        private readonly INegocioCDSRepository negocioCDSRepository;
        private readonly IMapper mapper;
        public DistribuicaoService(INegocioCDSRepository negocioCDSRepository, IMapper mapper)
        {
            this.negocioCDSRepository = negocioCDSRepository;
            this.mapper = mapper;
        }
        public async Task<RetornoAcaoService<IEnumerable<NegocioCDSViewModel>>> ObterNegociosCDS()
        {
            var retorno = new RetornoAcaoService<IEnumerable<NegocioCDSViewModel>>();
            var retornoCDSNegocio = await negocioCDSRepository.ObterTodos("tblCDSNegocio");
            if (retornoCDSNegocio.Sucesso)
            {
                var negocios = mapper.Map<IEnumerable<NegocioCDSViewModel>>(retornoCDSNegocio.Result);
                retorno.Result = negocios;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoCDSNegocio.ExceptionRetorno;
            retorno.MensagemRetorno = retornoCDSNegocio.MensagemRetorno;
            return retorno;
        }
    }
}
