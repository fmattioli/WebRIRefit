using Microsoft.AspNetCore.Mvc;

namespace RI.Web.API.Controllers
{
    public class BaseController : Controller
    {
        protected static string ObterSecretKey()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.json");
            var config = builder.Build();
            return config.GetSection("Secret:Key").Value;
        }
    }
}
