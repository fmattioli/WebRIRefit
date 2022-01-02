using AutoMapper;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Livro;

namespace RI.Web.Application.TituloMappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<RetornoAcao, RetornoAcaoService>();
            CreateMap<LivroEntity, LivroViewModel>();
            CreateMap<LivroTJ, LivroTJViewModel>();
        }
    }
}
