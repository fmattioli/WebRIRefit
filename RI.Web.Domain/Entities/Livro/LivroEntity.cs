using System.ComponentModel.DataAnnotations.Schema;

namespace RI.Web.Domain.Entities.Livro
{
    public class LivroEntity
    {
        //[Column("PK_Id")]
        public int PK_Id { get; set; }
        public string? Descricao { get; set; }
        public string? Siga { get; set; }
        public int UltimaSequenciaUtilizada { get; set; }
        public string? Sessao { get; set; }
        public bool ControlaSequenciaDoAto { get; set; }
        public string? SiglaOficial { get; set; }
        public int PermiteSequenciaDoAtoZero { get; set; }
        public int ControlaSequenciaDoLivro { get; set; }
        public int UltimoLivroUtilizado { get; set; }
        public int SequenciaInicialAtos { get; set; }
        public int PermiteDescreverGarantia { get; set; }
        public bool EnviarDOI { get; set; }
        public bool ValidarRegistroAnterior { get; set; }
        public bool Indisponibilidade { get; set; }
        public bool Transcricao { get; set; }
        public int fk_tblWriLivroTJ { get; set; }
        public int EnviaBDL { get; set; }
    }
}
