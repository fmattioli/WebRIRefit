using Microsoft.AspNetCore.Mvc;

namespace RI.Web.UI.Controllers
{
    public abstract class BaseController : Controller
    {
        protected async Task<HttpResponseMessage> RequisicaoAPI(string Metodo)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(GetUrlAPI(Metodo));
            return response;
        }

        protected string GetUrlAPI(string action)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json");
            var config = builder.Build();

            return config.GetSection("ApiSettings:Url").Value + action;
        }
    }
}
