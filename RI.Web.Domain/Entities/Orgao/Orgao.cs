namespace RI.Web.Domain.Entities.Orgao
{
    public class Orgao
    {
        public int OrgaoId { get; set; }
        public string? OrgaoDescricao { get; set; }
        public string? Comarca { get; set; }
        public string? Estado { get; set; }
        public bool PossuiRI { get; set; }
        public bool PossuiTN { get; set; }
        public bool PossuiRC { get; set; }
        public bool PossuiTD { get; set; }
        public bool Outros { get; set; }
        public string? NumeroVara { get; set; }
        public string? NumeroCircunscricao { get; set; }
        public string? CNS { get; set; }
    }
}
