using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;

namespace RI.Web.Application.Interfaces.Livro
{
    public interface ILivroService
    {
        Task<RetornoAcaoService<IEnumerable<LivroViewModel>>> ObterLivros();
        Task<RetornoAcaoService<LivroViewModel>> ObterLivroPorId(int Id);
        Task<RetornoAcaoService<IEnumerable<LivroTJViewModel>>> ObterLivrosTJ();
        Task<RetornoAcaoService<LivroTJViewModel>> ObterLivroTJPorId(int Id);
        Task<RetornoAcaoService> AdicionarLivro(LivroViewModel Livro);
        Task<RetornoAcaoService> EditarLivro(LivroViewModel Livro);
        Task<RetornoAcaoService> DesativarLivro(int Id);
    }
}
