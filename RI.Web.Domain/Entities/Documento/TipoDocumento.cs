namespace RI.Web.Domain.Entities.Documento
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string? TpDoc { get; set; }
        public string? Descricao { get; set; }
        public string? Mascara { get; set; }
        public CLETipoDocumento CLETipoDocumento { get; set; }
        public bool MostrarRecepcao { get; set; }
        public short OrdemAto { get; set; }

        public TipoDocumento()
        {
            CLETipoDocumento = new CLETipoDocumento();
        }
    }
}
