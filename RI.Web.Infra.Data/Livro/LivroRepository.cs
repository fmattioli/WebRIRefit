using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Livro;
using RI.Web.Domain.Interfaces.Livro;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.DapperConfig;
using RI.Web.Infra.Data.Repositories.Base;
using System.Data.SqlClient;

namespace RI.Web.Infra.Data.Livro
{
    public class LivroRepository : BaseRepository<LivroEntity>, ILivroRepository
    {
        private ConfigSQLServer ConfigSql { get; set; }
        private readonly ILivroTJRepository livroTJRepository;
        public LivroRepository(ConfigDapper _db, ConfigSQLServer configADO, ILivroTJRepository livroTJRepository) : base(_db)
        {
            ConfigSql = configADO;
            this.livroTJRepository = livroTJRepository;
        }

        public async Task<RetornoAcao<IEnumerable<LivroEntity>>> ObterLivros()
        {
            var retornoAcao = new RetornoAcao<IEnumerable<LivroEntity>>();
            try
            {
                var livros = await ObterTodos("tblWRILivro");
                if (livros.Result is not null)
                {
                    foreach (var livro in livros.Result)
                    {
                        //Livro TJ
                        var livroTJ = await livroTJRepository.ObterPorId("tblWRILivroTJ", "PK_Id", livro.IdLivroTJ);
                        if (livroTJ.Result is not null)
                            livro.LivroTJ = livroTJ.Result;
                    }
                }

                retornoAcao.Sucesso = true;
                retornoAcao.Result = livros.Result;
                return retornoAcao;
            }
            catch (Exception ex)
            {
                retornoAcao.Sucesso = false;
                retornoAcao.ExceptionRetorno = ex;
                retornoAcao.MensagemRetorno = ex.Message;
                return retornoAcao;
            }
        }
    }
}
