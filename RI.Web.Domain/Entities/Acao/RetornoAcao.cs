namespace RI.Web.Domain.Entities.Acao
{
    public class RetornoAcao
    {
        public bool Sucesso { get; set; }
        public string? MensagemRetorno { get; set; }
        public Exception? ExceptionRetorno { get; set; }
    }

    public class RetornoAcao<T> : RetornoAcao
    {
        public T? Result { get; set; }
    }
}
