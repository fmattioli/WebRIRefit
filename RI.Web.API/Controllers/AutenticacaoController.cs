using Microsoft.AspNetCore.Mvc;
using RI.Web.API.Auth;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.API.Controllers
{
    public class AutenticacaoController : Controller
    {
        [HttpGet("Autenticar")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ObterChaveAutenticacao(string usuario)
        {
            var token = TokenAuth.GenerateToken(usuario, ObterSecretKey());
            if (!string.IsNullOrEmpty(token))
                return Ok("Bearer " + token);
            return BadRequest("Erro ao gerar chave de autenticacao");
        }

        private static string ObterSecretKey()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.json");
            var config = builder.Build();
            return config.GetSection("Secret:Key").Value;
        }
    }
}
