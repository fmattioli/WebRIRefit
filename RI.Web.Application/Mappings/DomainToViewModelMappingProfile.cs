using AutoMapper;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Livro;

namespace RI.Web.Application.TituloMappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<LivroEntity, LivroViewModel>();
        }
    }
}
