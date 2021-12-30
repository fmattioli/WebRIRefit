using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RI.Web.Application.Interfaces.Titulo;
using RI.Web.Application.Services.Titulo;
using RI.Web.Domain.Interfaces.Base;
using RI.Web.Domain.Interfaces.Titulo;
using RI.Web.Infra.Data.DapperConfig;
using RI.Web.Infra.Data.Recepcao;
using RI.Web.Infra.Data.Repositories.Base;

namespace RI.Web.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AdicionarInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbSession>();
            services.AddScoped<IRecepcaoRepository, RecepcaoRepository>();
            services.AddScoped<IRecepcaoService, RecepcaoService>();

            return services;
        }
    }
}
