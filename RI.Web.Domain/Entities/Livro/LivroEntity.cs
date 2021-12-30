namespace RI.Web.Domain.Entities.Livro
{
    public class LivroEntity
    {
        public LivroEntity(int id, string descricao, string? siga, int ultimaSequenciaUtilizada, 
            string sessao, bool controlaSequenciaDoAto, string? siglaOficial, int? permiteSequenciaDoAtoZero, 
            int? controlaSequenciaDoLivro, int? ultimoLivroUtilizado, int? sequenciaInicialAtos, 
            int? permiteDescreverGarantia, bool? enviarDOI, bool? validarRegistroAnterior, 
            bool? indisponibilidade, bool? transcricao, int? fk_tblWriLivroTJ, int enviaBDL)
        {
            Id = id;
            Descricao = descricao;
            Siga = siga;
            UltimaSequenciaUtilizada = ultimaSequenciaUtilizada;
            Sessao = sessao;
            ControlaSequenciaDoAto = controlaSequenciaDoAto;
            SiglaOficial = siglaOficial;
            PermiteSequenciaDoAtoZero = permiteSequenciaDoAtoZero;
            ControlaSequenciaDoLivro = controlaSequenciaDoLivro;
            UltimoLivroUtilizado = ultimoLivroUtilizado;
            SequenciaInicialAtos = sequenciaInicialAtos;
            PermiteDescreverGarantia = permiteDescreverGarantia;
            EnviarDOI = enviarDOI;
            ValidarRegistroAnterior = validarRegistroAnterior;
            Indisponibilidade = indisponibilidade;
            Transcricao = transcricao;
            this.fk_tblWriLivroTJ = fk_tblWriLivroTJ;
            EnviaBDL = enviaBDL;
        }

        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string? Siga { get; set; }
        public int UltimaSequenciaUtilizada { get; set; }
        public string? Sessao { get; set; }
        public bool ControlaSequenciaDoAto { get; set; }
        public string? SiglaOficial { get; set; }
        public int? PermiteSequenciaDoAtoZero { get; set; }
        public int? ControlaSequenciaDoLivro { get; set; }
        public int? UltimoLivroUtilizado { get; set; }
        public int? SequenciaInicialAtos { get; set; }
        public int? PermiteDescreverGarantia { get; set; }
        public bool? EnviarDOI { get; set; }
        public bool? ValidarRegistroAnterior { get; set; }
        public bool? Indisponibilidade { get; set; }
        public bool? Transcricao { get; set; }
        public int? fk_tblWriLivroTJ { get; set; }
        public int EnviaBDL { get; set; }
    }
}
