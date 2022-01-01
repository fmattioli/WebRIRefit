using AutoMapper;
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

            var retornoLivroEntity = await livroRepository.ObterLivros();
            if (retornoLivroEntity.Sucesso)
            {
                var livroViewModel = mapper.Map<IEnumerable<LivroViewModel>>(retornoLivroEntity.Result);
                retorno.Result = livroViewModel;
                retorno.Sucesso = true;
                return retorno;
            }
            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoLivroEntity.ExceptionRetorno;
            retorno.MensagemRetorno = retornoLivroEntity.MensagemRetorno;
            return retorno;
        }


        public async Task<RetornoAcaoService<LivroViewModel>> ObterLivroPorId(int Id)
        {
            var retorno = new RetornoAcaoService<LivroViewModel>();
            var retornoObterLivro = await livroRepository.ObterPorId("tblWRILivro", "PK_Id", Id);
            if (retornoObterLivro.Sucesso)
            {
                var livroViewModel = mapper.Map<LivroViewModel>(retornoObterLivro.Result);
                var retornoObterLivroTJ = await ObterLivroTJPorId(livroViewModel.IdLivroTJ);
                if (retornoObterLivroTJ.Sucesso)
                    livroViewModel.LivroTJ = mapper.Map<LivroTJViewModel>(retornoObterLivroTJ.Result);

                retorno.Result = livroViewModel;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoObterLivro.ExceptionRetorno;
            retorno.MensagemRetorno = retornoObterLivro.MensagemRetorno;
            return retorno;
        }

        public async Task<RetornoAcaoService<IEnumerable<LivroTJViewModel>>> ObterLivrosTJ()
        {
            var retorno = new RetornoAcaoService<IEnumerable<LivroTJViewModel>>();

            var retornoLivroEntity = await livroTJRepository.ObterTodos("tblWRILivroTJ");
            if (retornoLivroEntity.Sucesso)
            {
                var lirosTJViewModel = mapper.Map<IEnumerable<LivroTJViewModel>>(retornoLivroEntity.Result);
                retorno.Result = lirosTJViewModel;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoLivroEntity.ExceptionRetorno;
            retorno.MensagemRetorno = retornoLivroEntity.MensagemRetorno;
            return retorno;
        }

        public async Task<RetornoAcaoService<LivroTJViewModel>> ObterLivroTJPorId(int Id)
        {
            var retorno = new RetornoAcaoService<LivroTJViewModel>();
            var retornoLivroTJ = await livroTJRepository.ObterPorId("tblWRILivroTJ", "PK_Id", Id);
            if (retornoLivroTJ.Sucesso)
            {
                var lirosTJViewModel = mapper.Map<LivroTJViewModel>(retornoLivroTJ.Result);
                retorno.Result = lirosTJViewModel;
                retorno.Sucesso = true;
                return retorno;
            }

            retorno.Sucesso = false;
            retorno.ExceptionRetorno = retornoLivroTJ.ExceptionRetorno;
            retorno.MensagemRetorno = retornoLivroTJ.MensagemRetorno;
            return retorno;
        }
    }
}
