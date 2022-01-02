using AutoMapper;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Livro;

namespace RI.Web.Application.TituloMappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<LivroViewModel, LivroEntity>();
            CreateMap<LivroTJViewModel, LivroTJ>();
            CreateMap<RetornoAcaoService, RetornoAcao>();
        }
    }
}
