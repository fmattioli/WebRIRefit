using RI.Web.Domain.Entities.Documento;
using RI.Web.Domain.Entities.Naciolidade;
using RI.Web.Domain.Entities.SIPEntities;

namespace RI.Web.Domain.Entities.Cliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public Cidade.Cidade Cidade { get; set; }
        public string? Cep { get; set; }
        public string? Telefone { get; set; }
        public string? Site { get; set; }
        public string? Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public short QtdTitulosTrazidos { get; set; }
        public short QtdContatos { get; set; }
        public bool ApareceContaCorrente { get; set; }
        public bool Desativado { get; set; }
        public Nacionalidade Nacionalidade { get; set; }
        public EstadoCivil.EstadoCivil EstadoCivil { get; set; }
        public SIPTipoTelefone TipoTelefone { get; set; }
        public short Sexo { get; set; }
        public Profissao.Profissao Profissao { get; set; }
        public string? InscricaoEstadual { get; set; }
        public bool Tp_Pessoa { get; set; }
        public SIPTipoTelefone TipoTelefone2 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Observacao { get; set; }
        public TipoLogradouro.TipoLogradouro TipoLogradouro { get; set; }
        public bool ClienteBloqueado { get; set; }
        public string? ObsClienteBloqueado { get; set; }
        public string? Agencia { get; set; }
        public Banco.Banco Banco { get; set; }
        public string? Conta { get; set; }
        public string? TipoConta { get; set; }

        public Cliente()
        {
            TipoDocumento = new TipoDocumento();
            Cidade = new Cidade.Cidade();
            Nacionalidade = new Nacionalidade();
            EstadoCivil = new EstadoCivil.EstadoCivil();
            TipoTelefone = new SIPTipoTelefone();
            TipoTelefone2 = new SIPTipoTelefone();
            Profissao = new Profissao.Profissao();
            TipoLogradouro = new TipoLogradouro.TipoLogradouro();
            Banco = new Banco.Banco();

        }
    }
}
