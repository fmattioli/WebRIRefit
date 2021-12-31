using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RI.Web.Application.Services.Acoes
{
    public class RetornoAcaoService
    {
        public bool Sucesso { get; set; }
        public string? MensagemRetorno { get; set; }
        [JsonIgnore]
        public Exception? ExceptionRetorno { get; set; }
    }

    public class RetornoAcaoService<T> : RetornoAcaoService
    {
        public T? Result { get; set; }
    }
}
