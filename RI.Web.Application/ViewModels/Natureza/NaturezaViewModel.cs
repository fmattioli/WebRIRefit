using RI.Application.ViewModels.MolduraExtrato;
using RI.Application.ViewModels.Texto;

namespace RI.Application.ViewModels.Natureza
{
    public struct NaturezaViewModel
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public short Previsao { get; set; }
        public string TipoExibicao { get; set; }
        public MolduraExtratoViewModel MolduraExtratoAV { get; set; }
        public MolduraExtratoViewModel MolduraExtratoREG { get; set; }
        public MolduraExtratoViewModel MolduraExtratoABM { get; set; }
        public bool NaoValidarCampos { get; set; }
        public TextoViewModel Texto { get; set; }
        public bool AtualizarPrevisao { get; set; }
        public NaturezaPenhoraViewModel NaturezaPenhora { get; set; }
        public short PrenotacaoEspecifica { get; set; }
        public short QtdDiasAposReentrada { get; set; }
        public NaturezaEProtocoloViewModel NaturezaEProtocolo { get; set; }
        public string PrazoDiasCorrido { get; set; }
        public PeerNaturezaViewModel PeerNatureza { get; set; }
        public short Validade { get; set; }
        public int IdNaturezaApp { get; set; }

    }
}
