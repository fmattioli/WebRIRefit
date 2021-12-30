namespace RI.Web.Application.RetornoAcaoService
{
    public class RetornoAcaoService
    {
        public bool Sucesso { get; set; }
        public string? MensagemRetorno { get; set; }
        public Exception? ExceptionRetorno { get; set; }
    }

    public class RetornoAcaoServices<T> : RetornoAcaoService
    {
        public T? Result { get; set; }
    }
}
