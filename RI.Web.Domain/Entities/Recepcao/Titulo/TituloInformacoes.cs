namespace RI.Web.Domain.Entities.Recepcao.Titulo
{
    public class TituloInformacoes
    {
        public int Num_LivroTN { get; set; }
        public string? Compl_Num_LivroTN { get; set; }
        public short FolhaTN { get; set; }
        public string? ComplFolhaTN { get; set; }
        public string? FolhaFinalTN { get; set; }
        public string? Compl_FolhaFinalTN { get; set; }
        public Orgao.Orgao Orgao { get; set; }
        public string? Processo { get; set; }
        public string? Oficio { get; set; }
        public short FK_tblWRINatureza_Id { get; set; }
        public Natureza.NaturezaEntity Natureza { get; set; }
        public DateTime DataDoTituloApresentado { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public DateTime DtRetirada { get; set; }
        public DateTime DtDevolucao { get; set; }
        public string? Observacoes { get; set; }
        public short QtdAndamento { get; set; }
        public short QtdAtos { get; set; }
        public DateTime DataUltimoRegistro { get; set; }
        public decimal ValorTotTit1 { get; set; }
        public decimal ValorTotTit2 { get; set; }
        public decimal ValorTotTit3 { get; set; }
        public decimal ValorTotTit4 { get; set; }
        public decimal ValorTotTit5 { get; set; }
        public decimal ValorTotTit6 { get; set; }
        public decimal ValorTotTit7 { get; set; }
        public decimal ValorTotTit8 { get; set; }
        public decimal ValorTotTit9 { get; set; }
        public decimal ValorTotTit10 { get; set; }
        public decimal ValorTotTitTotal { get; set; }
        public DateTime DataDevolucaoLimite { get; set; }
        public TipoContrato TipoContrato { get; set; }
        public TipoGrau TipoGrau { get; set; }
        public Indice Indice { get; set; }
        public decimal ValorFGTS { get; set; }
        public int QtdeParcelas { get; set; }
        public decimal ValorParcela { get; set; }
        public DateTime DataParcela { get; set; }
        public decimal TaxaNominal { get; set; }
        public decimal TaxaEfetiva { get; set; }
        public decimal ValorLeilao { get; set; }
        public string? NumeroContrato { get; set; }
        public int NumeroCancelamentoRegistro { get; set; }
        public DateTime DataTransitoJulgado { get; set; }
        public string? EspecieJudicial { get; set; }
        public Amortizacao Amortizacao { get; set; }
        public Periodicidade Periodicidade { get; set; }
        public short QtdePeriodicidade { get; set; }
        public string? DescricaoComplementarDoTitulo { get; set; }
        public Cidade.Cidade Cidade { get; set; }
        public string? NomeAcao { get; set; }
        public DateTime DataSentenca { get; set; }
        public DateTime DataLeilao { get; set; }
        public string? NomeLeiloeiro { get; set; }
        public DateTime DataDocumentoComprobatorio { get; set; }
        public string? EspecieDocumentoComprobatorio { get; set; }
        public Orgao.Orgao OrgaoDocumentoComprabatorio { get; set; }
        public DateTime DataDistribuicaoAcao { get; set; }
        public Orgao.Orgao OrgaoDistribuicaoAcao { get; set; }
        public string? ProximoGravame { get; set; }
        public Usuario.Usuario Usuario { get; set; }

        public TituloInformacoes()
        {
            Orgao = new Orgao.Orgao();
            Natureza = new Natureza.NaturezaEntity();
            TipoContrato = new TipoContrato();
            TipoGrau = new TipoGrau();
            Indice = new Indice();
            Amortizacao = new Amortizacao();
            Periodicidade = new Periodicidade();
            Cidade = new Cidade.Cidade();
            Usuario = new Usuario.Usuario();
            OrgaoDistribuicaoAcao = new Orgao.Orgao();
            OrgaoDocumentoComprabatorio = new Orgao.Orgao();
        }
    }
}
