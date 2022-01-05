using AutoMapper;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.TipoPrenotacao;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Livro;
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
        }
    }
}
