using RI.Application.ViewModels.Usuario;
using RI.Web.Application.Interfaces.Usuario;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.Application.Services.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        public async Task<RetornoAcaoService<UsuarioViewModel>> ObterUsuario(LoginViewModel login)
        {
            throw new NotImplementedException();
        }
    }
}
