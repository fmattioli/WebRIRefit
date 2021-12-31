using AutoMapper;
using RI.Application.ViewModels.Livro;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Livro;
using RI.Web.Domain.Interfaces.Livro;

namespace RI.Web.Application.Services.Livro
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository livroRepository;
        private readonly ILivroTJRepository livroTJRepository;
        private readonly IMapper mapper;
        public LivroService(ILivroRepository livroRepository, IMapper mapper, ILivroTJRepository livroTJRepository)
        {
            this.livroRepository = livroRepository;
            this.livroTJRepository = livroTJRepository;
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

        public async Task<RetornoAcaoService<IEnumerable<LivroTJViewModel>>> ObterLivrosTJ()
        {
            var retorno = new RetornoAcaoService<IEnumerable<LivroTJViewModel>>();
            try
            {
                var livrosEntity = await livroTJRepository.ObterTodos("tblWRILivroTJ");
                var lirosTJViewModel = mapper.Map<IEnumerable<LivroTJViewModel>>(livrosEntity.Result);
                retorno.Result = lirosTJViewModel;
                retorno.Sucesso = true;
                return retorno;

            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.ExceptionRetorno = ex;
                retorno.MensagemRetorno = ex.Message;
                return retorno;
            }
        }
    }
}
