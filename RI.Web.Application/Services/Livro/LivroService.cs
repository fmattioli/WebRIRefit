using AutoMapper;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Interfaces.Livro;

namespace RI.Web.Application.Services.Livro
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository livroRepository;
        private readonly IMapper mapper;
        public LivroService(ILivroRepository livroRepository, IMapper mapper)
        {
            this.livroRepository = livroRepository;
            this.mapper = mapper;
        }

        public Task<LivroViewModel> ObterLivro(LivroViewModel livroViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
