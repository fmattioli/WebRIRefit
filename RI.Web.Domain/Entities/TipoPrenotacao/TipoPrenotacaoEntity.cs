using System.ComponentModel.DataAnnotations.Schema;

namespace RI.Web.Domain.Entities.TipoPrenotacao
{
    public class TipoPrenotacaoEntity
    {
        [Column("PK_Id")]
        public int Id { get; set; }
        [Column("TipoPrenotacao")]
        public string? DescricaoTipoPrenotacao { get; set; }
        [Column("Validade")]
        public short Validade { get; set; }
        [Column("NuncaExpira")]
        public bool NuncaExpira { get; set; }
        [Column("Prenota")]
        public bool Prenota { get; set; }
        [Column("Duvida")]
        public bool Duvida { get; set; }
        [Column("PermiteCancelarAposRetirada")]
        public bool PermiteCancelarAposRetirada { get; set; }
        [Column("QtdDiasAposReentrada")]
        public short QtdDiasAposReentrada { get; set; }
        [Column("ExibeProtocoloOficial")]
        public bool ExibeProtocoloOficial { get; set; }
        [Column("TpPrenUsucExtr")]
        public bool TpPrenUsucExtr { get; set; }
        [Column("TpPrenRetificacao")]
        public bool TpPrenRetificacao { get; set; }
        [Column("ExigirDadosBancarios")]
        public bool ExigirDadosBancarios { get; set; }
        [Column("IdTipoProtocoloApp")]
        public int IdTipoProtocoloApp { get; set; }
        [Column("DiasUteis")]
        public bool DiasUteis { get; set; }
    }
}
