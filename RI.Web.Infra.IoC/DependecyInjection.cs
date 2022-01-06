using Microsoft.Extensions.DependencyInjection;
using RI.Web.Application.Interfaces.Distribuicao;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Interfaces.Natureza;
using RI.Web.Application.Interfaces.Recepcao;
using RI.Web.Application.Interfaces.TipoPrenotacao;
using RI.Web.Application.Interfaces.Usuario;
using RI.Web.Application.Services.Distribuicao;
using RI.Web.Application.Services.Livro;
using RI.Web.Application.Services.Natureza;
using RI.Web.Application.Services.Recepcao;
using RI.Web.Application.Services.TipoPrenotacao;
using RI.Web.Application.Services.Usuario;
using RI.Web.Domain.Interfaces.Distribuicao;
using RI.Web.Domain.Interfaces.Livro;
using RI.Web.Domain.Interfaces.Natureza;
using RI.Web.Domain.Interfaces.TipoPrenotacao;
using RI.Web.Domain.Interfaces.Titulo;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.DapperConfig;
using RI.Web.Infra.Data.Distribuicao;
using RI.Web.Infra.Data.Livro;
using RI.Web.Infra.Data.Natureza;
using RI.Web.Infra.Data.Recepcao;
using RI.Web.Infra.Data.TipoPrenotacao;

namespace RI.Web.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AdicionarInfra(this IServiceCollection services)
        {
            services.AddSingleton<ConfigSQLServer>();
            services.AddSingleton<ConfigDapper>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IRecepcaoRepository, RecepcaoRepository>();
            services.AddScoped<IRecepcaoService, RecepcaoService>();
            services.AddScoped<ITipoPrenotacaoRepository, TipoPrenotacaoRepository>();
            services.AddScoped<ITipoPrenotacaoService, TipoPrenotacaoService>();
            services.AddScoped<INaturezaRepository, NaturezaRepository>();
            services.AddScoped<INaturezaService, NaturezaService>();
            services.AddScoped<IDistribuicaoService, DistribuicaoService>();
            services.AddScoped<INegocioCDSRepository, NegocioCDSRepository>();
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<ILivroTJRepository, LivroTJRepository>();
            services.AddScoped<ILivroService, LivroService>();

            return services;
        }
    }
}
