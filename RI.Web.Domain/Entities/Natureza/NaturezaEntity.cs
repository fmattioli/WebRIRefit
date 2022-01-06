using System.ComponentModel.DataAnnotations.Schema;

namespace RI.Web.Domain.Entities.Natureza
{
    public class NaturezaEntity
    {
        [Column("PK_Id")]
        public int Id { get; set; }
        [Column("Tipo")]
        public string? Tipo { get; set; }
        [Column("Descricao")]
        public string? Descricao { get; set; }
        [Column("Previsao")]
        public short Previsao { get; set; }
        [Column("Tipo_Exibicao")]
        public string? TipoExibicao { get; set; }
        [Column("FK_tblWRIMoldurasEstratoAV_Id")]
        public int MolduraExtratoAV { get; set; }
        [Column("FK_tblWRIMoldurasEstratoREG_Id")]
        public int MolduraExtratoREG { get; set; }
        [Column("FK_tblWRIMoldurasEstratoABM_Id")]
        public int MolduraExtratoABM { get; set; }
        [Column("NaoValidarCampos")]
        public bool NaoValidarCampos { get; set; }
        [Column("FK_tblWRITextos_Id")]
        public int Texto { get; set; }
        [Column("AtualizarPrevisao")]
        public bool AtualizarPrevisao { get; set; }
        [Column("FK_tblCLETipoAto_Id")]
        public int CLETipoAto { get; set; }
        [Column("FK_tblEDFTipoProcesso_Id")]
        public int EDFTipoProcesso { get; set; }
        [Column("FK_tblWRINaturezaPenhora_Id")]
        public int NaturezaPenhora { get; set; }
        [Column("PrenotacaoEspecifica")]
        public short PrenotacaoEspecifica { get; set; }
        [Column("QtdDiasAposReentrada")]
        public short QtdDiasAposReentrada { get; set; }
        [Column("FK_tblWRINaturezaEProtocolo_Id")]
        public int NaturezaEProtocolo { get; set; }
        [Column("FK_tblWRINaturezaPeer_Id")]
        public int NaturezaPeer { get; set; }
        [Column("PrazoDiasCorrido")]
        public string? PrazoDiasCorrido { get; set; }
        [Column("FK_tblWRIPeerNatureza_Id")]
        public int PeerNatureza { get; set; }
        [Column("Validade")]
        public short Validade { get; set; }
        [Column("IdNaturezaApp")]
        public int IdNaturezaApp { get; set; }

        [Column("Evitar_Dias_Nao_Uteis_Prazo_Final")]
        public string? EvitarDiasNaoUteisPrazoFinal { get; set; }
        [Column("Prazo_Final_No_Dia_Util_Anterior")]
        public string? PrazoFinalNoDiaUtilAnterior { get; set; }
        [Column("Prazo_Final_No_Dia_Util_Posterior")]
        public string? PrazoFinalNoDiaUtilPosterior { get; set; }
        [Column("Expira_Reentrada_Dias_Corridos")]
        public string? ExpiraReentradaDiasCorridos { get; set; }
        [Column("Previsao_Dias_Corridos")]
        public string? PrevisaoDiasCorridos { get; set; }
        [Column("Peso")]
        public short Peso { get; set; }
        [Column("DiasUteis")]
        public bool DiasUteis { get; set; }
    }
}
