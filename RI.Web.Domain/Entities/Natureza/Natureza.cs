namespace RI.Web.Domain.Entities.Natureza
{
    public class Natureza
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public string? Descricao { get; set; }
        public short Previsao { get; set; }
        public string? TipoExibicao { get; set; }
        public MolduraExtrato.MolduraExtrato MolduraExtratoAV { get; set; }
        public MolduraExtrato.MolduraExtrato MolduraExtratoREG { get; set; }
        public MolduraExtrato.MolduraExtrato MolduraExtratoABM { get; set; }
        public bool NaoValidarCampos { get; set; }
        public Texto.Texto Texto { get; set; }
        public bool AtualizarPrevisao { get; set; }
        public NaturezaPenhora NaturezaPenhora { get; set; }
        public short PrenotacaoEspecifica { get; set; }
        public short QtdDiasAposReentrada { get; set; }
        public NaturezaEProtocolo NaturezaEProtocolo { get; set; }
        public string? PrazoDiasCorrido { get; set; }
        public PeerNatureza PeerNatureza { get; set; }
        public short Validade { get; set; }
        public int IdNaturezaApp { get; set; }

        public Natureza()
        {
            MolduraExtratoAV = new MolduraExtrato.MolduraExtrato();
            MolduraExtratoREG = new MolduraExtrato.MolduraExtrato();
            MolduraExtratoABM = new MolduraExtrato.MolduraExtrato();
            Texto = new Texto.Texto();
            NaturezaPenhora = new NaturezaPenhora();
            NaturezaEProtocolo = new NaturezaEProtocolo();
            PeerNatureza = new PeerNatureza();
        }

    }
}
