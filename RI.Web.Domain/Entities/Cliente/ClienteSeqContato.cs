using RI.Web.Domain.Entities.Documento;
using RI.Web.Domain.Entities.SIPEntities;

namespace RI.Web.Domain.Entities.Cliente
{
    public class ClienteSeqContato
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public short SeqContato { get; set; }
        public string? Nome { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Telefone2 { get; set; }
        public SIPTipoTelefone TipoTelefone { get; set; }
        public SIPTipoTelefone TipoTelefone2 { get; set; }

        public ClienteSeqContato()
        {
            Cliente = new Cliente();
            TipoDocumento = new TipoDocumento();
            TipoTelefone = new SIPTipoTelefone();
            TipoTelefone2 = new SIPTipoTelefone();
        }
    }
}
