namespace RI.Application.ViewModels.Texto
{
    public struct TextoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public bool Devolucao { get; set; }
        public string PatchImagem { get; set; }
    }
}
