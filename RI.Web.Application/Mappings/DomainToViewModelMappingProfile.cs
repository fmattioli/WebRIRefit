using AutoMapper;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Distribuicao;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Application.ViewModels.Natureza;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.TipoPrenotacao;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Distribuicao;
using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Entities.Natureza;
using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.TipoPrenotacao;

namespace RI.Web.Application.TituloMappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<RetornoAcao, RetornoAcaoService>();
            CreateMap<LivroEntity, LivroViewModel>();
            CreateMap<LivroTJ, LivroTJViewModel>();
            CreateMap<RecepcaoEntity, RecepcaoViewModel>();
            CreateMap<TipoPrenotacaoEntity, TipoPrenotacaoViewModel>();
            CreateMap<NaturezaEntity, NaturezaViewModel>();
            CreateMap<NegocioCDS, NegocioCDSViewModel>();
        }
    }
}
