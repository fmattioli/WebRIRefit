namespace RI.Web.Domain.Entities.Usuario
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Descricao { get; set; }
        public string? SenhaUser { get; set; }
        public string? NomeCompletoUser { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public string? OrgaoEmissor { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? CEP { get; set; }
        public string? UF { get; set; }
        public string? Conjuge { get; set; }
        public string? Telefone { get; set; }
        public string? Ramal { get; set; }
        public string? Email { get; set; }
        public DateTime DtInicioTrabalho { get; set; }
        public string? CargoFuncao { get; set; }
        public string? Escolaridade { get; set; }
        public string? Observacoes { get; set; }
        public string? FingerPrint { get; set; }
        public bool AssinaNegativa { get; set; }
        public string? AssinaturaDigitalizada { get; set; }
        public string? Carimbo { get; set; }
        public bool Ativo { get; set; }
        public string? ExecucaoRel { get; set; }
        public bool RegistroAntecipado { get; set; }
        public Setores? Setores { get; set; }
        public int IMGPermiteConfigurar { get; set; }
        public int IMGPermiteImprimir { get; set; }
        public int IMGPermiteImprimirCertidao { get; set; }
        public int IMGPermiteExcluir { get; set; }
        public int IMGPermiteDigitalizar { get; set; }
        public int IdLoginOutroSistema { get; set; }
        public bool OficialDeCumprimento { get; set; }
    }
}
