using AutoMapper;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.RetornoAcaoService;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Domain.Entities.Acao;
using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;

namespace RI.Web.Application.TituloMappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<TituloBasicoEntity, TituloBasicoViewModel>();
            CreateMap<RecepcaoEntity, RecepcaoViewModel>();
            CreateMap<LivroEntity, LivroViewModel>();
            CreateMap<IEnumerable<LivroEntity>, IEnumerable<LivroViewModel>>();
        }
    }
}
