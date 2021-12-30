using RI.Web.Domain.Entities.Cliente;
using RI.Web.Domain.Entities.Recepcao.Titulo;

namespace RI.Web.Domain.Entities.Recepcao
{
    public class RecepcaoEntity 
    {
        public short? FlagRecepcao { get; set; }
        public int? Recepcao { get; set; }
        public int? SeqTitulo { get; set; }
        public short? TipoPrenotacaoId { get; set; }
        public TituloInformacoes TituloInformacoes { get; set; }
        public int? NumPrenotacao { get; set; }
        public DateTime? DataRecepcao { get; set; }
        public DateTime? DataPrenotacao { get; set; }
        public string? FlagRetirada { get; set; }
        public string? FlagRegParcial { get; set; }
        public string? FlagCancelamento { get; set; }
        public string? FlagCancelamentoPedidoDaParte { get; set; }
        public string? FlagExpiraPrn { get; set; }
        public decimal ValorTotalDeposito { get; set; }
        public decimal VlrCredito { get; set; }
        public decimal Saldo { get; set; }
        public decimal VlrTotCustas { get; set; }
        public short QtdTitulos { get; set; }
        public TipoPrenotacao TipoPrenotacao { get; set; }
        public DateTime DataCancelamento { get; set; }
        public short TipoCancelamento { get; set; }
        public DateTime DataExpiraPrn { get; set; }
        public Cliente.Cliente Cliente { get; set; }
        public ClienteSeqContato ClienteSeqContato { get; set; }
        public int CodCalculo { get; set; }
        public decimal VlrCotac { get; set; }
        public bool ProtocoloImpresso { get; set; }
        public string? Outorgante { get; set; }
        public string? Outorgado { get; set; }
        public decimal VlrPrenotacao { get; set; }
        public DateTime DtRecolhimentoPrenotacao { get; set; }
        public short RecolherEm { get; set; }
        public bool PrenotacaoRecolhida { get; set; }
        public Cliente.Cliente ClienteApresentante { get; set; }
        public decimal ValorTotal1 { get; set; }
        public decimal ValorTotal2 { get; set; }
        public decimal ValorTotal3 { get; set; }
        public decimal ValorTotal4 { get; set; }
        public decimal ValorTotal5 { get; set; }
        public decimal ValorTotal6 { get; set; }
        public decimal ValorTotal7 { get; set; }
        public decimal ValorTotal8 { get; set; }
        public decimal ValorTotal9 { get; set; }
        public decimal ValorTotal10 { get; set; }
        public decimal ValorPrn1 { get; set; }
        public decimal ValorPrn2 { get; set; }
        public decimal ValorPrn3 { get; set; }
        public decimal ValorPrn4 { get; set; }
        public decimal ValorPrn5 { get; set; }
        public decimal ValorPrn6 { get; set; }
        public decimal ValorPrn7 { get; set; }
        public decimal ValorPrn8 { get; set; }
        public decimal ValorPrn9 { get; set; }
        public decimal ValorPrn10 { get; set; }
        public short DivisorPrn { get; set; }
        public DateTime DataExpiraReentrada { get; set; }
        public string? ConsultaInternet { get; set; }
        public MensagemCertidaoTalao.MensagemCertidaoTalao MensagemCertidaoTalao { get; set; }
        public int PK_RecepcaoAnterior { get; set; }
        public int PK_FlagRecepcaoAnterior { get; set; }
        public DateTime DataUltimaReentrada { get; set; }
        public DateTime DataLimitePermanenciaContraditorio { get; set; }
        public int PK_RecepcaoPosterior { get; set; }
        public int PK_FlagRecepcaoPosterior { get; set; }
        public int CodTabPrn { get; set; }
        public string? Observacao { get; set; }
        public string? CodigoDeAutenticidade { get; set; }
        public string? Origem { get; set; }
        public int NumRPS { get; set; }
        public DateTime DtEnvioRPS { get; set; }
        public decimal AliquotaISS { get; set; }
        public decimal VlrISS { get; set; }
        public Usuario.Usuario Usuario { get; set; }
        public string? NumControle { get; set; }
        public string? ProtocoloEntidade { get; set; }
        public decimal VlrDiversos { get; set; }
        public int IdIntimacao { get; set; }
        public decimal VlrDesconto { get; set; }
        public decimal DespesasAcessoriasCompleta { get; set; }
        public decimal FlagPrenotarManual { get; set; }
        public bool AptoIntimacaoCIAF { get; set; }
        public Banco.Banco BancoDeDevolucao { get; set; }
        public string? AgenciaDeDevolucao { get; set; }
        public string? ContaDeDevolucao { get; set; }
        public string? TipoContaDeDevolucao { get; set; }
        public string? ComunicaSISCOAF { get; set; }
        public string? DetalhamentoSISCOAF { get; set; }
        public DateTime DataEnvioJudicial { get; set; }
        public DateTime DataCancelJudicial { get; set; }
        public DateTime DataParalisacao { get; set; }
        public bool Deferido { get; set; }
        public Cliente.Cliente ClienteRemetente { get; set; }
        public int IdProtocoloApp { get; set; }
        public bool AptoQualificacao { get; set; }
        public bool EnviarCustasArisp { get; set; }

        public RecepcaoEntity()
        {
            FlagRetirada = "N";
            FlagRegParcial = "N";
            FlagCancelamento = "N";
            FlagExpiraPrn = "";
            TipoPrenotacao = new TipoPrenotacao();
            Cliente = new Cliente.Cliente();
            ClienteSeqContato = new ClienteSeqContato();
            ClienteApresentante = new Cliente.Cliente();
            MensagemCertidaoTalao = new MensagemCertidaoTalao.MensagemCertidaoTalao();
            Usuario = new Usuario.Usuario();
            BancoDeDevolucao = new Banco.Banco();
            ClienteRemetente = new Cliente.Cliente();
            TituloInformacoes = new TituloInformacoes();
        }
    }
}
