namespace RI.Web.Domain.Entities.Naciolidade
{
    public class Nacionalidade
    {
        public int Id { get; set; }
        public string? DescricaoNacionalidade { get; set; }
        public bool Estrangeiro { get; set; }
        public Pais.Pais Pais { get; set; }

        public Nacionalidade()
        {
            Pais = new Pais.Pais();
        }
    }
}
