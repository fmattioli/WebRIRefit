namespace RI.Web.Application.ViewModels.Natureza
{
    public class NaturezaViewModel
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public string? Descricao { get; set; }
        public short Previsao { get; set; }
        public string? TipoExibicao { get; set; }
        public int MolduraExtratoAV { get; set; }
        public int MolduraExtratoREG { get; set; }
        public int MolduraExtratoABM { get; set; }
        public bool NaoValidarCampos { get; set; }
        public int Texto { get; set; }
        public bool AtualizarPrevisao { get; set; }
        public int CLETipoAto { get; set; }
        public int EDFTipoProcesso { get; set; }
        public int NaturezaPenhora { get; set; }
        public short PrenotacaoEspecifica { get; set; }
        public short QtdDiasAposReentrada { get; set; }
        public int NaturezaEProtocolo { get; set; }
        public int NaturezaPeer { get; set; }
        public string? PrazoDiasCorrido { get; set; }
        public int PeerNatureza { get; set; }
        public short Validade { get; set; }
        public int IdNaturezaApp { get; set; }
        public string? EvitarDiasNaoUteisPrazoFinal { get; set; }
        public string? PrazoFinalNoDiaUtilAnterior { get; set; }
        public string? PrazoFinalNoDiaUtilPosterior { get; set; }
        public string? ExpiraReentradaDiasCorridos { get; set; }
        public string? PrevisaoDiasCorridos { get; set; }
        public short Peso { get; set; }
        public bool DiasUteis { get; set; }

    }
}
