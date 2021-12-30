using System.ComponentModel.DataAnnotations;

namespace RI.Application.ViewModels.Recepcao.Titulo
{
    public class TituloBasicoViewModel
    {
        public short? FlagRecepcao { get; set; }
        public int? Recepcao { get; set; }
        public int? SeqTitulo { get; set; }
        public short? TipoPrenotacaoId { get; set; }
    }
}
