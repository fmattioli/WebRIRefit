namespace RI.Web.Domain.Entities.EstadoCivil
{ 
    public class EstadoCivil
    {
        public int Id { get; set; }
        public string? Estado { get; set; }
        public string? Descricao { get; set; }
        public bool UsaConjuge { get; set; }
        public int IdEstadoCivilContrario { get; set; }
        public short Sexo { get; set; }
        public bool Divorciado { get; set; }
        public PeerEstadoCivil PeerEstadoCivil { get; set; }
        public EstadoCivil()
        {
            PeerEstadoCivil = new PeerEstadoCivil();
        }
    }
}
