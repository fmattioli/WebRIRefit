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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LivroViewModel, LivroEntity>();
            CreateMap<LivroTJViewModel, LivroTJ>();
            CreateMap<RetornoAcaoService, RetornoAcao>();
            CreateMap<RecepcaoViewModel, RecepcaoEntity>();
            CreateMap<TipoPrenotacaoViewModel, TipoPrenotacaoEntity>();
            CreateMap<NaturezaViewModel, NaturezaEntity>();
            CreateMap<NegocioCDSViewModel, NegocioCDS>();
        }
    }
}
