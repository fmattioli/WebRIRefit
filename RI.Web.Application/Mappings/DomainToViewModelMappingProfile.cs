using AutoMapper;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.RetornoAcaoService;
using RI.Web.Application.ViewModels;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Domain;
using RI.Web.Domain.Entities.Acao;
using RI.Web.Domain.Entities.Banco;
using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;

namespace RI.Web.Application.TituloMappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<TituloBasicoEntity, TituloBasicoViewModel>();
            CreateMap<RecepcaoClass, RecepcaoViewModel>();
        }
    }
}
