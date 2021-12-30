using AutoMapper;
using RI.Web.Application.Interfaces.Livro;
using RI.Web.Application.RetornoAcaoService;
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

        public async Task<IEnumerable<LivroViewModel>> ObterLivros()
        {
            var retorno = new RetornoAcaoServices<IEnumerable<LivroViewModel>>();
            try
            {
                var listaLivros = new List<LivroViewModel>();
                var livrosRepository = await livroRepository.ObterTodos("tblWRILivro");
                if (livroRepository is not null)
                {
                    foreach (var item in livrosRepository.Result ?? throw new Exception("Erro ao obter a lista"))
                    {
                        listaLivros.Add(new LivroViewModel
                        {
                            ControlaSequenciaDoAto = item.ControlaSequenciaDoAto,
                            ControlaSequenciaDoLivro = item.ControlaSequenciaDoLivro,
                            Descricao = item.Descricao,
                            EnviaBDL = item.EnviaBDL,
                            EnviarDOI = item.EnviarDOI,
                            fk_tblWriLivroTJ = item.fk_tblWriLivroTJ,
                            Indisponibilidade = item.Indisponibilidade,
                            PermiteDescreverGarantia = item.PermiteDescreverGarantia,
                            PermiteSequenciaDoAtoZero = item.PermiteSequenciaDoAtoZero,
                            PK_Id = item.PK_Id,
                            SequenciaInicialAtos = item.SequenciaInicialAtos,
                            Sessao = item.Sessao,
                            Siga = item.Siga,
                            SiglaOficial = item.SiglaOficial,
                            Transcricao = item.Transcricao,
                            UltimaSequenciaUtilizada = item.UltimaSequenciaUtilizada,
                            UltimoLivroUtilizado = item.UltimoLivroUtilizado,
                            ValidarRegistroAnterior = item.ValidarRegistroAnterior
                        });
                    }
                }
                return listaLivros;

            }
            catch
            {
                throw;
            }
        }

    }
}
