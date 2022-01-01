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
        private ConfigSQLServer db { get; set; }
        private readonly ILivroTJRepository livroTJRepository;
        public LivroRepository(ConfigDapper _db, ConfigSQLServer configADO, ILivroTJRepository livroTJRepository) : base(_db)
        {
            db = configADO;
            this.livroTJRepository = livroTJRepository;
        }

        public async Task<RetornoAcao<IEnumerable<LivroEntity>>> ObterLivros()
        {
            var retornoAcao = new RetornoAcao<IEnumerable<LivroEntity>>();
            var ListaLivros = new List<LivroEntity>();
            try
            {
                SQL.Clear();
                SQL.AppendLine("SELECT                                                                          ");
                SQL.AppendLine("tblWRILivro.PK_Id AS IdLivro            ,                                       ");
                SQL.AppendLine("tblWRILivro.Descricao AS DescricaoLivro ,                                       ");
                SQL.AppendLine("Sigla                                   ,                                       ");
                SQL.AppendLine("UltimaSequenciaUtilizada                ,                                       ");
                SQL.AppendLine("Sessao                                  ,                                       ");
                SQL.AppendLine("ControlaSequenciaDoAto                  ,                                       ");
                SQL.AppendLine("SiglaOficial                            ,                                       ");
                SQL.AppendLine("PermiteSequenciaDoAtoZero               ,                                       ");
                SQL.AppendLine("ControlaSequenciaDoLivro                ,                                       ");
                SQL.AppendLine("UltimoLivroUtilizado                    ,                                       ");
                SQL.AppendLine("SequenciaInicialAtos                    ,                                       ");
                SQL.AppendLine("PermiteDescreverGarantia                ,                                       ");
                SQL.AppendLine("EnviarDOI                               ,                                       ");
                SQL.AppendLine("ValidarRegistroAnterior                 ,                                       ");
                SQL.AppendLine("Indisponibilidade                       ,                                       ");
                SQL.AppendLine("Transcricao                             ,                                       ");
                SQL.AppendLine("EnviaBDL                                ,	                                    ");
                SQL.AppendLine("fk_tblWriLivroTJ                        ,	                                    ");
                SQL.AppendLine("tblWRILivroTJ.Descricao AS DescricaoTJ  ,                                       ");
                SQL.AppendLine("tblWRILivroTJ.PK_ID AS IdLivroTJ                                                ");
                SQL.AppendLine("FROM tblWRILivro                                                                ");
                SQL.AppendLine("LEFT JOIN tblWRILivroTJ ON tblWRILivro.fk_tblWriLivroTJ = tblWRILivroTJ.PK_Id   ");

                using (var conn = dapper.Connection)
                {
                    using (SqlDataReader reader = await db.RetornarDadosSQLServer(SQL.ToString(), Lista))
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                #region Obter configurações de livros TJ (De-Para Selo Digital)
                                //Livro TJ
                                var LivroTJ = new LivroTJ();
                                int IdLivroTJ = (reader["fk_tblWriLivroTJ"] as int?).GetValueOrDefault();
                                if (IdLivroTJ != 0)
                                {
                                    var retornoLivroTJAcao = await livroTJRepository.ObterPorId("tblWRILivroTJ", "PK_Id", IdLivroTJ);
                                    LivroTJ = retornoLivroTJAcao.Result;
                                }
                                #endregion

                                ListaLivros.Add(new LivroEntity
                                {
                                    IdLivro = (reader["IdLivro"] as short?).GetValueOrDefault(),
                                    DescricaoLivro = (reader["DescricaoLivro"] as string),
                                    Sigla = (reader["Sigla"] as string),
                                    UltimaSequenciaUtilizada = (reader["UltimaSequenciaUtilizada"] as int?).GetValueOrDefault(),
                                    Sessao = (reader["Sessao"] as string),
                                    ControlaSequenciaDoAto = (reader["ControlaSequenciaDoAto"] as bool?).GetValueOrDefault(),
                                    ControlaSequenciaDoLivro = (reader["ControlaSequenciaDoAto"] as int?).GetValueOrDefault(),
                                    SiglaOficial = (reader["ControlaSequenciaDoAto"] as string),
                                    EnviaBDL = (reader["EnviaBDL"] as int?).GetValueOrDefault(),
                                    EnviarDOI = (reader["EnviarDOI"] as bool?).GetValueOrDefault(),
                                    Indisponibilidade = (reader["Indisponibilidade"] as bool?).GetValueOrDefault(),
                                    PermiteDescreverGarantia = (reader["PermiteDescreverGarantia"] as int?).GetValueOrDefault(),
                                    PermiteSequenciaDoAtoZero = (reader["PermiteSequenciaDoAtoZero"] as int?).GetValueOrDefault(),
                                    SequenciaInicialAtos = (reader["SequenciaInicialAtos"] as int?).GetValueOrDefault(),
                                    Transcricao = (reader["Transcricao"] as bool?).GetValueOrDefault(),
                                    UltimoLivroUtilizado = (reader["UltimoLivroUtilizado"] as int?).GetValueOrDefault(),
                                    ValidarRegistroAnterior = (reader["ValidarRegistroAnterior"] as bool?).GetValueOrDefault(),
                                    LivroTJ = LivroTJ ?? new LivroTJ()
                                });
                            }
                        }
                    }
                }

                retornoAcao.Sucesso = true;
                retornoAcao.Result = ListaLivros;
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
