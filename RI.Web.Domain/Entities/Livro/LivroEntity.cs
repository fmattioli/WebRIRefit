using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RI.Web.Domain.Entities.Livro
{
    [Table("tblWRILivro")]
    public class LivroEntity
    {
        [Column("PK_Id")]
        public short Id { get; set; }
        [Column("Descricao")]
        public string? DescricaoLivro { get; set; }
        [Column("Sigla")]
        public string? Sigla { get; set; }
        [Column("UltimaSequenciaUtilizada")]
        public int UltimaSequenciaUtilizada { get; set; }
        [Column("Sessao")]
        public string? Sessao { get; set; }
        [Column("ControlaSequenciaDoAto")]
        public bool ControlaSequenciaDoAto { get; set; }
        [Column("SiglaOficial")]
        public string? SiglaOficial { get; set; }
        [Column("PermiteSequenciaDoAtoZero")]
        public int PermiteSequenciaDoAtoZero { get; set; }
        [Column("ControlaSequenciaDoLivro")]
        public int ControlaSequenciaDoLivro { get; set; }
        [Column("UltimoLivroUtilizado")]
        public int UltimoLivroUtilizado { get; set; }
        [Column("SequenciaInicialAtos")]
        public int SequenciaInicialAtos { get; set; }
        [Column("PermiteDescreverGarantia")]
        public int PermiteDescreverGarantia { get; set; }
        [Column("EnviarDOI")]
        public bool EnviarDOI { get; set; }
        [Column("ValidarRegistroAnterior")]
        public bool ValidarRegistroAnterior { get; set; }
        [Column("Indisponibilidade")]
        public bool Indisponibilidade { get; set; }
        [Column("Transcricao")]
        public bool Transcricao { get; set; }
        [Column("EnviaBDL")]
        public int EnviaBDL { get; set; }

        public LivroTJ LivroTJ { get; set; }

        [Column("fk_tblWriLivroTJ")]
        public int IdLivroTJ { get; set; }

        public LivroEntity()
        {
            LivroTJ = new LivroTJ();
        }

    }
}
