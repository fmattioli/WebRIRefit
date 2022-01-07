using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.Application.Interfaces.Usuario
{
    public interface IUsuarioService
    {
        Task<RetornoAcaoService<UsuarioViewModel>> ObterUsuario(LoginViewModel login);
    }
}
