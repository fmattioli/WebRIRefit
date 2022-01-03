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
        private readonly ConfigSQLServer ConfigSql;
        private readonly ILivroTJRepository livroTJRepository;
        public LivroRepository(ConfigDapper _db, ConfigSQLServer configADO, ILivroTJRepository livroTJRepository) : base(_db)
        {
            ConfigSql = configADO;
            this.livroTJRepository = livroTJRepository;
        }

        public async Task<RetornoAcao> InserirLivro(LivroEntity Livro)
        {
            var retorno = new RetornoAcao();
            try
            {
                SQL.Clear();
                SQL.AppendLine("INSERT INTO tblWRILivro");
                SQL.AppendLine("(                                      ");
                SQL.AppendLine("PK_Id,                                 ");
                SQL.AppendLine("Descricao,                             ");
                SQL.AppendLine("Sigla,                                 ");
                SQL.AppendLine("UltimaSequenciaUtilizada,              ");
                SQL.AppendLine("Sessao,                                ");
                SQL.AppendLine("ControlaSequenciaDoAto,                ");
                SQL.AppendLine("PermiteSequenciaDoAtoZero,             ");
                SQL.AppendLine("ControlaSequenciaDoLivro,              ");
                SQL.AppendLine("UltimoLivroUtilizado,                  ");
                SQL.AppendLine("SequenciaInicialAtos,                  ");
                SQL.AppendLine("PermiteDescreverGarantia,              ");
                SQL.AppendLine("EnviarDOI,                             ");
                SQL.AppendLine("ValidarRegistroAnterior,               ");
                SQL.AppendLine("Indisponibilidade,                     ");
                SQL.AppendLine("Transcricao,                           ");
                SQL.AppendLine("EnviaBDL,                              ");
                SQL.AppendLine("Ativo,                                 ");
                SQL.AppendLine("fk_tblWriLivroTJ                       ");
                SQL.AppendLine(")                                      ");
                SQL.AppendLine("VALUES                                 ");
                SQL.AppendLine("(                                      ");
                SQL.AppendLine($"(SELECT MAX(PK_Id) + 1 FROM tblWRILivro),");
                SQL.AppendLine($"'{Livro.DescricaoLivro}',             ");
                SQL.AppendLine($"'{Livro.Sigla}',                      ");
                SQL.AppendLine($"'{Livro.UltimaSequenciaUtilizada}',   ");
                SQL.AppendLine($"'{Livro.Sessao}',                     ");
                SQL.AppendLine($"'{Livro.ControlaSequenciaDoAto}',     ");
                SQL.AppendLine($"'{Livro.PermiteSequenciaDoAtoZero}',  ");
                SQL.AppendLine($"'{Livro.ControlaSequenciaDoLivro}',   ");
                SQL.AppendLine($"'{Livro.UltimoLivroUtilizado}',       ");
                SQL.AppendLine($"'{Livro.SequenciaInicialAtos}',       ");
                SQL.AppendLine($"'{Livro.PermiteDescreverGarantia}',   ");
                SQL.AppendLine($"'{Livro.EnviarDOI}',                  ");
                SQL.AppendLine($"'{Livro.ValidarRegistroAnterior}',    ");
                SQL.AppendLine($"'{Livro.Indisponibilidade}',          ");
                SQL.AppendLine($"'{Livro.Transcricao}',                ");
                SQL.AppendLine($"'{Livro.EnviaBDL}',                   ");
                SQL.AppendLine($"'{Livro.Ativo}',                      ");
                SQL.AppendLine($"'{Livro.IdLivroTJ}'                   ");
                SQL.AppendLine(")                                      ");
                var retornoSQL = await ConfigSql.ExecutarComandoSQLServer(SQL.ToString());
                retorno.Sucesso = retornoSQL >= 1;
                return retorno;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.MensagemRetorno = ex.Message;
                retorno.ExceptionRetorno = ex.InnerException;
                return retorno;
            }
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
