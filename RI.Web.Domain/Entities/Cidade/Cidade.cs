namespace RI.Web.Domain.Entities.Cidade
{
    public class Cidade
    {
        public int Id { get; set; }
        public string? NomeCidade { get; set; }
        public string? UF { get; set; }
        public short ComarcaDoCartorio { get; set; }
        public short CodigoIBGE { get; set; }
    }
}
