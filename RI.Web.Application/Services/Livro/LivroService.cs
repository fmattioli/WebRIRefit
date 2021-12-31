using AutoMapper;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Entities.Acoes;
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

        public async Task<RetornoAcaoService<IEnumerable<LivroViewModel>>> ObterLivros()
        {
            var retorno = new RetornoAcaoService<IEnumerable<LivroViewModel>>();
            try
            {
                var livrosEntity = await livroRepository.ObterTodos("tblWRILivro");
                var lirosViewModel = mapper.Map<IEnumerable<LivroViewModel>>(livrosEntity.Result);
                retorno.Result = lirosViewModel;
                retorno.Sucesso = true;
                return retorno;

            }
            catch(Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }

    }
}
