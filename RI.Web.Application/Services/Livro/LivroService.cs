using AutoMapper;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.RetornoAcaoService;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Acao;
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

        public async Task<RetornoAcao<IEnumerable<LivroViewModel>>> ObterLivro()
        {
            var retorno = new RetornoAcao<IEnumerable<LivroViewModel>>();
            try
            {
                var livros = mapper.Map<IEnumerable<LivroViewModel>>(await livroRepository.ObterTodos("tblWRILivro"));
                retorno.Sucesso = true;
                retorno.Result = livros;
                return retorno;
                
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.MensagemRetorno = ex.Message;
                retorno.ExceptionRetorno = ex;
                return retorno;
            }
        }

    }
}
