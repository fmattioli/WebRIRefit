using RI.Web.Application.ViewModels.Banco;
using RI.Web.Application.ViewModels.Cidade;
using RI.Web.Application.ViewModels.EstadoCivil;
using RI.Web.Application.ViewModels.Nacionalidade;
using RI.Web.Application.ViewModels.Profissao;
using RI.Web.Application.ViewModels.Recepcao.TipoLogradouro;
using RI.Web.Application.ViewModels.SIPTipoTelefone;
using RI.Web.Application.ViewModels.TipoDocumento;

namespace RI.Web.Application.ViewModels.Cliente
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public TipoDocumentoViewModel TipoDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public CidadeViewModel Cidade { get; set; }
        public string? Cep { get; set; }
        public string? Telefone { get; set; }
        public string? Site { get; set; }
        public string? Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public short QtdTitulosTrazidos { get; set; }
        public short QtdContatos { get; set; }
        public bool ApareceContaCorrente { get; set; }
        public bool Desativado { get; set; }
        public NacionalidadeViewModel Nacionalidade { get; set; }
        public EstadoCivilViewModel EstadoCivil { get; set; }
        public SIPTipoTelefoneViewModel TipoTelefone { get; set; }
        public short Sexo { get; set; }
        public ProfissaoViewModel Profissao { get; set; }
        public string? InscricaoEstadual { get; set; }
        public bool Tp_Pessoa { get; set; }
        public SIPTipoTelefoneViewModel TipoTelefone2 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Observacao { get; set; }
        public TipoLogradouroViewModel TipoLogradouro { get; set; }
        public bool ClienteBloqueado { get; set; }
        public string? ObsClienteBloqueado { get; set; }
        public string? Agencia { get; set; }
        public BancoViewModel Banco { get; set; }
        public string? Conta { get; set; }
        public string? TipoConta { get; set; }

        public ClienteViewModel()
        {
            TipoDocumento = new TipoDocumentoViewModel();
            Cidade = new CidadeViewModel();
            Nacionalidade = new NacionalidadeViewModel();
            EstadoCivil = new EstadoCivilViewModel();
            TipoTelefone = new SIPTipoTelefoneViewModel();
            Profissao = new ProfissaoViewModel();
            TipoTelefone2 = new SIPTipoTelefoneViewModel();
            TipoLogradouro = new TipoLogradouroViewModel();
            Banco = new BancoViewModel();
        }
    }
}
