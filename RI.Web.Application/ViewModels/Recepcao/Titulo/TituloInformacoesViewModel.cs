using RI.Web.Application.ViewModels.Cidade;
using RI.Web.Application.ViewModels.Natureza;
using RI.Web.Application.ViewModels.Orgao;
using RI.Web.Application.ViewModels.Usuario;

namespace RI.Web.Application.ViewModels.Recepcao.Titulo
{
    public class TituloInformacoesViewModel : TituloViewModel
    {
        public int Num_LivroTN { get; set; }
        public short FolhaTN { get; set; }
        public string? ComplFolhaTN { get; set; }
        public string? FolhaFinalTN { get; set; }
        public string? Compl_FolhaFinalTN { get; set; }
        public OrgaoViewModel Orgao { get; set; }
        public string? Processo { get; set; }
        public string? Oficio { get; set; }
        public NaturezaViewModel Natureza { get; set; }
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
        public TipoContratoViewModel TipoContrato { get; set; }
        public TipoGrauViewModel TipoGrau { get; set; }
        public IndiceViewModel Indice { get; set; }
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
        public AmortizacaoViewModel Amortizacao { get; set; }
        public PeriodicidadeViewModel Periodicidade { get; set; }
        public short QtdePeriodicidade { get; set; }
        public string? DescricaoComplementarDoTitulo { get; set; }
        public CidadeViewModel Cidade { get; set; }
        public string? NomeAcao { get; set; }
        public DateTime DataSentenca { get; set; }
        public DateTime DataLeilao { get; set; }
        public string? NomeLeiloeiro { get; set; }
        public DateTime DataDocumentoComprobatorio { get; set; }
        public string? EspecieDocumentoComprobatorio { get; set; }
        public OrgaoViewModel OrgaoDocumentoComprabatorio { get; set; }
        public DateTime DataDistribuicaoAcao { get; set; }
        public OrgaoViewModel OrgaoDistribuicaoAcao { get; set; }
        public string? ProximoGravame { get; set; }
        public UsuarioViewModel Usuario { get; set; }

        public TituloInformacoesViewModel()
        {
            Orgao = new OrgaoViewModel();
            OrgaoDocumentoComprabatorio = new OrgaoViewModel();
            OrgaoDistribuicaoAcao = new OrgaoViewModel();
            Natureza = new NaturezaViewModel();
            TipoContrato = new TipoContratoViewModel();
            TipoGrau = new TipoGrauViewModel();
            Indice = new IndiceViewModel();
            Amortizacao = new AmortizacaoViewModel();
            Periodicidade = new PeriodicidadeViewModel();
            Cidade = new CidadeViewModel();
            Usuario = new UsuarioViewModel();
        }

    }
}
