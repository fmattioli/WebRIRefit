using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Interfaces.Titulo;
using RI.Web.Application.Services.Livro;
using RI.Web.Application.Services.Titulo;
using RI.Web.Domain.Interfaces.Livro;
using RI.Web.Domain.Interfaces.Titulo;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.DapperConfig;
using RI.Web.Infra.Data.Livro;
using RI.Web.Infra.Data.Recepcao;

namespace RI.Web.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AdicionarInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ConfigADO>();
            services.AddScoped<ConfigDapper>();
            services.AddScoped<IRecepcaoRepository, RecepcaoRepository>();
            services.AddScoped<IRecepcaoService, RecepcaoService>();
            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<ILivroTJRepository, LivroTJRepository>();

            return services;
        }
    }
}
