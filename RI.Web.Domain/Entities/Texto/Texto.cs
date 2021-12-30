namespace RI.Web.Domain.Entities.Texto
{
    public class Texto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Conteudo { get; set; }
        public bool Devolucao { get; set; }
        public string? PatchImagem { get; set; }
    }
}
