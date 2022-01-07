using Microsoft.AspNetCore.Mvc;
using RI.Web.Application.ViewModels.Usuario;
using System.Net.Http.Headers;

namespace RI.Web.UI.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        protected async Task<HttpResponseMessage> RequisicaoAPI(string Metodo)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));
            var response = await httpClient.GetAsync(GetUrlAPI(Metodo));
            return response;
        }

        protected async Task<HttpResponseMessage> AutenticarUsuarioRequest(string Metodo, LoginViewModel loginViewModel)
        {
            using var httpClient = new HttpClient();
            Metodo += $"?NomeUsuario={loginViewModel.NomeUsuario}?SenhaUsuario={loginViewModel.SenhaUsuario}";
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
