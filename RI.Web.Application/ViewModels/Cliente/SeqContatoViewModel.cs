using RI.Web.Application.ViewModels.SIPTipoTelefone;
using RI.Web.Application.ViewModels.TipoDocumento;

namespace RI.Web.Application.ViewModels.Cliente
{
    public class SeqContatoViewModel
    {
        public int Id { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public short SeqContato { get; set; }
        public string? Nome { get; set; }
        public TipoDocumentoViewModel TipoDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Telefone2 { get; set; }
        public SIPTipoTelefoneViewModel TipoTelefone { get; set; }
        public SIPTipoTelefoneViewModel TipoTelefone2 { get; set; }

        public SeqContatoViewModel()
        {
            Cliente = new ClienteViewModel();
            TipoDocumento = new TipoDocumentoViewModel();
            TipoTelefone = new SIPTipoTelefoneViewModel();
            TipoTelefone2 = new SIPTipoTelefoneViewModel();
        }
    }
}
