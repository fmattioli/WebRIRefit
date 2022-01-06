using RI.Application.ViewModels.Natureza;
using RI.Web.Application.Services.Acoes;
using RI.Web.Application.ViewModels.Natureza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Application.Interfaces.Natureza
{
    public interface INaturezaService
    {
        Task<RetornoAcaoService<IEnumerable<NaturezaViewModel>>> ObterNaturezas();
    }
}
