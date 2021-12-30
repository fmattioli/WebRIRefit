﻿using AutoMapper;
using RI.Application.ViewModels.Recepcao.Titulo;
using RI.Web.Application.RetornoAcaoService;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Application.ViewModels.Recepcao;
using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;

namespace RI.Web.Application.TituloMappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<TituloBasicoViewModel, TituloBasicoEntity>();
            CreateMap<RecepcaoViewModel, RecepcaoEntity>();
            CreateMap<RetornoAcaoServices<IEnumerable<LivroViewModel>>, RetornoAcao<IEnumerable<LivroEntity>>>();
        }
    }
}
