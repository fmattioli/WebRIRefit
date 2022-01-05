using RI.Web.Domain.Entities.Acoes;
using RI.Web.Domain.Entities.Recepcao;
using RI.Web.Domain.Entities.Recepcao.Titulo;
using RI.Web.Domain.Interfaces.Titulo;
using RI.Web.Infra.Data.ConfigDB;
using RI.Web.Infra.Data.DapperConfig;
using RI.Web.Infra.Data.Repositories.Base;
using System.Data.SqlClient;
using System.Text;

namespace RI.Web.Infra.Data.Recepcao
{
    public class RecepcaoRepository : BaseRepository<RecepcaoEntity>, IRecepcaoRepository
    {

        public RecepcaoRepository(ConfigDapper dapperConfig) : base(dapperConfig)
        {
        }

        public async Task<RecepcaoEntity> ObterRecepcao(TituloBasicoEntity Recepcao)
        {
            //var retornoAcao = new RetornoAcao<RecepcaoEntity>();
            //var recepcao = new RecepcaoEntity();
            //try
            //{
            //    SQL.Clear();
            //    SQL.AppendLine("Exec    pr_PesquisarRecepcao");
            //    SQL.AppendLine("         @PK_TipoPrenotacao = @TipoPrenotacao");
            //    SQL.AppendLine("        ,@PK_FlagRecepcao = @FlagRecepcao");
            //    SQL.AppendLine("        ,@PK_Recepcao = @Recepcao");
            //    SQL.AppendLine("        ,@PK_SeqTitulo = @SeqTitulo");
            //    SQL.AppendLine("        ,@PrimeiroProtocolo = @PrimeiroProtocolo");
            //    SQL.AppendLine("        ,@ProtocoloAnterior = @ProtocoloAnterior");
            //    SQL.AppendLine("        ,@ProtocoloPosterior = @ProtocoloPosterior");
            //    SQL.AppendLine("        ,@UltimoProtocolo = @UltimoProtocolo");
            //    SQL.AppendLine("        ,@PesquisarSelo = @PesquisarSelo");
            //    SQL.AppendLine("        ,@EstaAvancandoTitulo = @EstaAvancandoTitulo");

            //    Lista.Add(new SqlParameter("@TipoPrenotacao", Recepcao.TipoPrenotacaoId));
            //    Lista.Add(new SqlParameter("@FlagRecepcao", Recepcao.FlagRecepcao));
            //    Lista.Add(new SqlParameter("@Recepcao", Recepcao.Recepcao));
            //    Lista.Add(new SqlParameter("@SeqTitulo", Recepcao.SeqTitulo));
            //    Lista.Add(new SqlParameter("@PrimeiroProtocolo", false));
            //    Lista.Add(new SqlParameter("@ProtocoloAnterior", false));
            //    Lista.Add(new SqlParameter("@ProtocoloPosterior", false));
            //    Lista.Add(new SqlParameter("@UltimoProtocolo", false));
            //    Lista.Add(new SqlParameter("@PesquisarSelo", false));
            //    Lista.Add(new SqlParameter("@EstaAvancandoTitulo", false));

            //    using SqlDataReader reader = await _db.RetornarDadosSQLServer(SQL.ToString(), Lista);
            //    if (reader != null)
            //    {
            //        while (reader.Read())
            //        {
            //            recepcao.FlagRecepcao = (reader["PK_FlagRecepcao"] as short?).GetValueOrDefault();
            //            recepcao.Recepcao = (reader["PK_Recepcao"] as short?).GetValueOrDefault();
            //            recepcao.NumPrenotacao = (reader["NumPrenotacao"] as short?).GetValueOrDefault();
            //            recepcao.DataRecepcao = (reader["DtPrenotacao"] as DateTime?).GetValueOrDefault();
            //            recepcao.FlagRetirada = (reader["FlagRetirada"] as string);
            //            recepcao.FlagRegParcial = (reader["FlagRegParcial"] as string);
            //            recepcao.FlagCancelamento = (reader["FlagCancelamento"] as string);
            //            recepcao.FlagCancelamentoPedidoDaParte = (reader["FlagCancelPedParte"] as string);
            //            recepcao.FlagExpiraPrn = (reader["FlagExpiraPrn"] as string);
            //            recepcao.ValorTotalDeposito = (reader["VlrTotalDeposito"] as decimal?).GetValueOrDefault();
            //            recepcao.VlrCredito = (reader["VlrCredito"] as decimal?).GetValueOrDefault();
            //            recepcao.Saldo = (reader["Saldo"] as decimal?).GetValueOrDefault();
            //            recepcao.VlrDiversos = (reader["VlrDiversos"] as decimal?).GetValueOrDefault();
            //            recepcao.VlrTotCustas = (reader["VlrTotCustas"] as decimal?).GetValueOrDefault();
            //            recepcao.VlrTotCustas = (reader["VlrTotCustas"] as decimal?).GetValueOrDefault();
            //            recepcao.VlrPrenotacao = (reader["VlrPrenotacao"] as decimal?).GetValueOrDefault();
            //            recepcao.DtRecolhimentoPrenotacao = (reader["VlrPrenotacao"] as DateTime?).GetValueOrDefault();
            //            recepcao.RecolherEm = (reader["RecolherEm"] as short?).GetValueOrDefault();
            //            recepcao.PrenotacaoRecolhida = (reader["PrenotacaoRecolhida"] as bool?).GetValueOrDefault();
            //            recepcao.QtdTitulos = (reader["QtdTitulos"] as short?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.IdTipoPrenotacao = (reader["IdTipoPrenotacao"] as int?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.NuncaExpira = (reader["NuncaExpira"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.Prenota = (reader["Prenota"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.Duvida = (reader["Prenota"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.PermiteCancelarAposRetirada = (reader["PermiteCancelarAposRetirada"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.QtdDiasAposReentrada = (reader["QtdDiasAposReentrada"] as short?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.ExibeProtocoloOficial = (reader["ExibeProtocoloOficial"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.ExigirDadosBancarios = (reader["ExigirDadosBancarios"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.IdTipoProtocoloApp = (reader["IdTipoProtocoloApp"] as int?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.DescricaoTipoPrenotacao = (reader["TipoPrenotacaoDescricao"] as string);
            //            recepcao.TipoPrenotacao.TpPrenRetificacao = (reader["TpPrenRetificacao"] as bool?).GetValueOrDefault();
            //            recepcao.TipoPrenotacao.TpPrenUsucExtr = (reader["TpPrenRetificacao"] as bool?).GetValueOrDefault();
            //            recepcao.DataCancelamento = (reader["DtCancelamento"] as DateTime?).GetValueOrDefault();
            //            recepcao.TipoCancelamento = (reader["TipoCancelamento"] as short?).GetValueOrDefault();
            //            recepcao.ProtocoloImpresso = (reader["ProtocoloImpresso"] as bool?).GetValueOrDefault();
            //            recepcao.DataExpiraPrn = (reader["DtExpiraPrn"] as DateTime?).GetValueOrDefault();
            //            recepcao.Outorgado = (reader["Outorgado"] as string);
            //            recepcao.Outorgante = (reader["Outorgante"] as string);
            //            recepcao.ProtocoloEntidade = (reader["ProtocoloEntidade"] as string);
            //            recepcao.ComunicaSISCOAF = (reader["ComunicaSISCOAF"] as string);
            //            recepcao.DetalhamentoSISCOAF = (reader["DetalhamentoSISCOAF"] as string);
            //            recepcao.DataEnvioJudicial = (reader["DtEnvioJudicial"] as DateTime?).GetValueOrDefault();
            //            recepcao.Deferido = (reader["Deferido"] as bool?).GetValueOrDefault();
            //            recepcao.CodTabPrn = (reader["CodTabPrn"] as int?).GetValueOrDefault();
            //            recepcao.DivisorPrn = (reader["DivisorPrn"] as short?).GetValueOrDefault();
            //            recepcao.ValorPrn10 = (reader["ValorPrn10"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn9 = (reader["ValorPrn9"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn8 = (reader["ValorPrn8"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn7 = (reader["ValorPrn7"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn6 = (reader["ValorPrn6"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn5 = (reader["ValorPrn5"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn4 = (reader["ValorPrn4"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn3 = (reader["ValorPrn3"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn2 = (reader["ValorPrn2"] as int?).GetValueOrDefault();
            //            recepcao.ValorPrn1 = (reader["ValorPrn1"] as int?).GetValueOrDefault();
            //            recepcao.AptoQualificacao = (reader["AptoQualificacao"] as bool?).GetValueOrDefault();
            //            recepcao.DataExpiraReentrada = (reader["DtExpiraReentrada"] as DateTime?).GetValueOrDefault();
            //            recepcao.Cliente.Id = (reader["FK_tblWRIClientes_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.Nome = (reader["Nome"] as string);
            //            recepcao.Cliente.TipoDocumento.Id = (reader["FK_tblWRITpDocumento_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.NrDocumento = (reader["NrDocumento"] as string);
            //            recepcao.Cliente.TipoDocumento.TpDoc = (reader["TpDoc"] as string);
            //            recepcao.Cliente.TipoDocumento.Descricao = (reader["Descricao"] as string);
            //            recepcao.Cliente.Endereco = (reader["Endereco"] as string);
            //            recepcao.Cliente.TipoLogradouro.Id = (reader["FK_tblWRITipoLogradouro_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.Numero = (reader["Numero"] as string);
            //            recepcao.Cliente.Complemento = (reader["Complemento"] as string);
            //            recepcao.Cliente.Bairro = (reader["Bairro"] as string);
            //            recepcao.Cliente.Cidade.Id = (reader["FK_tblWRICidades_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.Cidade.NomeCidade = (reader["Cidade"] as string);
            //            recepcao.Cliente.Cidade.CodigoIBGE = (reader["CidadeIBGE"] as short?).GetValueOrDefault();
            //            recepcao.Cliente.Cidade.UF = (reader["UF"] as string);
            //            recepcao.Cliente.Cidade.ComarcaDoCartorio = (reader["ComarcaDoCartorio"] as short?).GetValueOrDefault();
            //            recepcao.Cliente.Cep = (reader["Cep"] as string);
            //            recepcao.Cliente.Telefone = (reader["Telefone"] as string);
            //            recepcao.Cliente.Telefone2 = (reader["Telefone2"] as string);
            //            recepcao.Cliente.Tp_Pessoa = (reader["TpPessoaCliente"] as bool?).GetValueOrDefault();
            //            recepcao.Cliente.Site = (reader["Site"] as string);
            //            recepcao.Cliente.Site = (reader["Email"] as string);
            //            recepcao.Cliente.DataCadastro = (reader["DataCadastro"] as DateTime?).GetValueOrDefault();
            //            recepcao.Cliente.QtdTitulosTrazidos = (reader["QtdTitulosTrazidos"] as short?).GetValueOrDefault();
            //            recepcao.Cliente.QtdContatos = (reader["QtdContatos"] as short?).GetValueOrDefault();
            //            recepcao.Cliente.NrDocumento = (reader["DOC"] as string);
            //            recepcao.Cliente.Nacionalidade.Id = (reader["FK_tblWRINacionalidade_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.EstadoCivil.Id = (reader["FK_tblWRIEstadoCivil_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.TipoTelefone.Id = (reader["FK_tblSIPTipoTelefone_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.TipoTelefone2.Id = (reader["FK_tblSIPTipoTelefone2_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.Sexo = (reader["Sexo"] as short?).GetValueOrDefault();
            //            recepcao.Cliente.Profissao.Id = (reader["FK_tblWRIProfissao_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.InscricaoEstadual = (reader["InscricaoEstadual"] as string);
            //            recepcao.Cliente.Banco.Id = (reader["FK_tblWRIBancos_Id"] as int?).GetValueOrDefault();
            //            recepcao.Cliente.Agencia = (reader["Agencia"] as string);
            //            recepcao.Cliente.Conta = (reader["Conta"] as string);
            //            recepcao.Cliente.TipoConta = (reader["TipoConta"] as string);
            //            recepcao.ClienteSeqContato.Id = (reader["FK_tblWRIClientesContato_SeqContato"] as int?).GetValueOrDefault();
            //            recepcao.ClienteSeqContato.TipoDocumento.Id = (reader["FK_tblWRITpDocumento_ID_Contato"] as int?).GetValueOrDefault();
            //            recepcao.ClienteSeqContato.TipoTelefone.Id = (reader["FK_tblSIPTipoTelefone_ID_Contato"] as int?).GetValueOrDefault();
            //            recepcao.ClienteSeqContato.Nome = (reader["Apresentante"] as string);
            //            recepcao.ClienteApresentante.TipoDocumento.Id = (reader["FK_tblWRITpDocumento_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Nome = (reader["Apresentante"] as string);
            //            recepcao.ClienteApresentante.Endereco = (reader["EnderecoApresentante"] as string);
            //            recepcao.ClienteApresentante.TipoLogradouro.Id = (reader["FK_tblWRITipoLogradouro_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Numero = (reader["NumeroApresentante"] as string);
            //            recepcao.ClienteApresentante.Complemento = (reader["ComplementoApresentante"] as string);
            //            recepcao.ClienteApresentante.Bairro = (reader["BairroApresentante"] as string);
            //            recepcao.ClienteApresentante.Cidade.Id = (reader["FK_tblWRICidades_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Cidade.NomeCidade = (reader["CidadeApresentante"] as string);
            //            recepcao.ClienteApresentante.Cidade.CodigoIBGE = (reader["CidadeIBGEApresentante"] as short?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Cidade.UF = (reader["UFApresentante"] as string);
            //            recepcao.ClienteApresentante.Cidade.ComarcaDoCartorio = (reader["ComarcaDoCartorioApresentante"] as short?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Cep = (reader["CepApresentante"] as string);
            //            recepcao.ClienteApresentante.Telefone = (reader["TelApresentante"] as string);
            //            recepcao.ClienteApresentante.Telefone2 = (reader["Tel2Apresentante"] as string);
            //            recepcao.ClienteApresentante.Email = (reader["EmailApresentante"] as string);
            //            recepcao.ClienteApresentante.TipoDocumento.TpDoc = (reader["TpDocApresentante"] as string);
            //            recepcao.ClienteApresentante.NrDocumento = (reader["NrDocumentoApresentante"] as string);
            //            recepcao.ClienteApresentante.Sexo = (reader["SexoApresentante"] as short?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Site = (reader["SiteApresentante"] as string);
            //            recepcao.ClienteApresentante.InscricaoEstadual = (reader["InscricaoEstadualApresentante"] as string);
            //            recepcao.ClienteApresentante.Nacionalidade.Id = (reader["FK_tblWRINacionalidade_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.EstadoCivil.Id = (reader["FK_tblWRIEstadoCivil_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.TipoTelefone.Id = (reader["FK_tblSIPTipoTelefone_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.TipoTelefone2.Id = (reader["FK_tblSIPTipoTelefone2_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Profissao.Id = (reader["FK_tblWRIProfissao_IdApresentante"] as int?).GetValueOrDefault();
            //            recepcao.ClienteApresentante.Tp_Pessoa = (reader["TpPessoaApresentante"] as bool?).GetValueOrDefault();
            //            recepcao.CodCalculo = (reader["CodCalculo"] as int?).GetValueOrDefault();
            //            recepcao.VlrCotac = (reader["VlrCotac"] as decimal?).GetValueOrDefault();
            //            recepcao.PK_FlagRecepcaoAnterior = (reader["PK_FlagRecepcaoAnterior"] as int?).GetValueOrDefault();
            //            recepcao.PK_RecepcaoAnterior = (reader["PK_RecepcaoAnterior"] as int?).GetValueOrDefault();
            //            recepcao.PK_FlagRecepcaoPosterior = (reader["PK_FlagRecepcaoPosterior"] as int?).GetValueOrDefault();
            //            recepcao.PK_RecepcaoPosterior = (reader["PK_RecepcaoPosterior"] as int?).GetValueOrDefault();
            //            recepcao.Observacao = (reader["Observacao"] as string);
            //            recepcao.Origem = (reader["Origem"] as string);
            //            recepcao.NumRPS = (reader["NumRPS"] as int?).GetValueOrDefault();
            //            recepcao.DtEnvioRPS = (reader["DtEnvioRPS"] as DateTime?).GetValueOrDefault();
            //            recepcao.AliquotaISS = (reader["AliquotaISS"] as decimal?).GetValueOrDefault();
            //            recepcao.VlrISS = (reader["VlrISS"] as decimal?).GetValueOrDefault();
            //            recepcao.BancoDeDevolucao.Id = (reader["FK_tblWRIBancos_IdDeDevolucao"] as int?).GetValueOrDefault();
            //            recepcao.AgenciaDeDevolucao = (reader["AgenciaDeDevolucao"] as string);
            //            recepcao.ContaDeDevolucao = (reader["ContaDeDevolucao"] as string);
            //            recepcao.TipoContaDeDevolucao = (reader["TipoContaDeDevolucao"] as string);
            //            recepcao.TituloInformacoes.Num_LivroTN = (reader["Num_LivroTN"] as int?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.Compl_Num_LivroTN = (reader["Compl_Num_LivroTN"] as string);
            //            recepcao.TituloInformacoes.FolhaTN = (reader["FolhaTN"] as short?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.ComplFolhaTN = (reader["Compl_FolhaTN"] as string);
            //            recepcao.TituloInformacoes.FolhaFinalTN = (reader["FolhaFinalTN"] as string);
            //            recepcao.TituloInformacoes.Compl_FolhaFinalTN = (reader["Compl_FolhaFinalTN"] as string);
            //            recepcao.TituloInformacoes.Orgao.OrgaoId = (reader["FK_tblWRIOrgao_Id"] as int?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.Processo = (reader["Processo"] as string);
            //            recepcao.TituloInformacoes.Oficio = (reader["Oficio"] as string);
            //            recepcao.TituloInformacoes.DataDoTituloApresentado = (reader["DataDoTituloApresentado"] as DateTime?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.Natureza.Id = (reader["FK_tblWRINatureza_Id"] as int?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.DataPrevisaoEntrega = (reader["DtPrevisaoEntrega"] as DateTime?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.DtRetirada = (reader["DtRetirada"] as DateTime?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.DtDevolucao = (reader["DtDevolucao"] as DateTime?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.Observacoes = (reader["Observacoes"] as string);
            //            recepcao.TituloInformacoes.QtdAndamento = (reader["QtdAndamento"] as short?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.QtdAtos = (reader["QtdAtos"] as short?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.DataDevolucaoLimite = (reader["DtDevolucaoLimite"] as DateTime?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.Orgao.OrgaoDescricao = (reader["Orgao"] as string);
            //            recepcao.TituloInformacoes.Orgao.Comarca = (reader["Comarca"] as string);
            //            recepcao.TituloInformacoes.Orgao.Estado = (reader["Estado"] as string);
            //            recepcao.TituloInformacoes.Natureza.Tipo = (reader["Natureza"] as string);
            //            recepcao.TituloInformacoes.Natureza.Descricao = (reader["Descricao"] as string);
            //            recepcao.TituloInformacoes.Natureza.Previsao = (reader["Previsao"] as short?).GetValueOrDefault();
            //            recepcao.TituloInformacoes.Natureza.TipoExibicao = (reader["Tipo_Exibicao"] as string);
            //            recepcao.TituloInformacoes.DataUltimoRegistro = (reader["DataUltimoRegistro"] as DateTime?).GetValueOrDefault();


            //        }
            //    }

            //    return recepcao;


            //}

            //catch (Exception ex)
            //{
            //    retornoAcao.ExceptionRetorno = ex;
            //    retornoAcao.MensagemRetorno = ex.Message;
            //    return recepcao;
            //}

            return null;
        }
    }
}

