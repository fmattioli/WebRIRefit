using Microsoft.Extensions.DependencyInjection;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Interfaces.Recepcao;
using RI.Web.Application.Interfaces.TipoPrenotacao;
using RI.Web.Application.Services.Livro;
using RI.Web.Application.Services.Recepcao;
using RI.Web.Application.Services.TipoPrenotacao;
using RI.Web.Domain.Interfaces.Livro;
using RI.Web.Domain.Interfaces.TipoPrenotacao;
using RI.Web.Domain.Interfaces.Titulo;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.DapperConfig;
using RI.Web.Infra.Data.Livro;
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
            services.AddScoped<IRecepcaoRepository, RecepcaoRepository>();
            services.AddScoped<IRecepcaoService, RecepcaoService>();
            services.AddScoped<ITipoPrenotacaoRepository, TipoPrenotacaoRepository>();
            services.AddScoped<ITipoPrenotacaoService, TipoPrenotacaoService>();
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<ILivroTJRepository, LivroTJRepository>();
            services.AddScoped<ILivroService, LivroService>();

            return services;
        }
    }
}
