namespace RI.Web.Application.ViewModels.TipoPrenotacao
{
    public class TipoPrenotacaoViewModel
    {
        public int Id { get; set; }
        public string? DescricaoTipoPrenotacao { get; set; }
        public short Validade { get; set; }
        public bool NuncaExpira { get; set; }
        public bool Prenota { get; set; }
        public bool Duvida { get; set; }
        public bool PermiteCancelarAposRetirada { get; set; }
        public short QtdDiasAposReentrada { get; set; }
        public bool ExibeProtocoloOficial { get; set; }
        public bool TpPrenUsucExtr { get; set; }
        public bool TpPrenRetificacao { get; set; }
        public bool ExigirDadosBancarios { get; set; }
        public int IdTipoProtocoloApp { get; set; }
    }
}
