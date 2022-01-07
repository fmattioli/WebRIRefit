using System.ComponentModel.DataAnnotations;

namespace RI.Web.Application.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo {0} corretamente!")]
        public string? NomeUsuario { get; set; }
        public string? DescricaoUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o campo {0} corretamente!")]
        public string? SenhaUsuario { get; set; }
        public string? NomeCompletoUsuario { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? CPF { get; set; }
        public string? OrgaoEmissor { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }
        public string? UF { get; set; }
        public string? Conjuge { get; set; }
        public string? Telefone { get; set; }
        public string? Ramal { get; set; }
        public string? Email { get; set; }
        public DateTime DataInicioTrabalho { get; set; }
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
        public int IDSetor { get; set; }
        public int IMGPermiteConfigurar { get; set; }
        public int IMGPermiteImprimir { get; set; }
        public int IMGPermiteImprimirCertidao { get; set; }
        public int IMGPermiteExcluir { get; set; }
        public int IMGPermiteDigitalizar { get; set; }
        public int IdLoginOutroSistema { get; set; }
        public bool OficialDeCumprimento { get; set; }
        public string? Token { get; set; }
        public string? UrlAplicacao { get; set; }
        
    }
}
