using RI.Application.ViewModels.Usuario;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.Application.Interfaces.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioViewModel> ObterUsuario(LoginViewModel login);
    }
}
