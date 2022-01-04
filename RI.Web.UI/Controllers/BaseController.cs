using Microsoft.AspNetCore.Mvc;

namespace RI.Web.UI.Controllers
{
    public abstract class BaseController<T> : Controller
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

        public IEnumerable<T> ConfigurarPaginacao(IEnumerable<T> lista, int? totalResultado, int totalPorPagina, int Pagina)
        {
            double? numeroPaginasGrid = totalResultado / (float)totalPorPagina;
            ViewBag.TotalLinhas = Math.Ceiling(Convert.ToDecimal(numeroPaginasGrid));
            ViewBag.Pagina = Pagina;
            return lista.Skip(Pagina == 1 ? 0 : 10).Take(10);
        }
    }
}
