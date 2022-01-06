using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Domain.Entities.Distribuicao
{
    public class NegocioCDS
    {
        [Column("PK_Id")]
        public int Id { get; set; }
        [Column("CodigoNegocio")]
        public int CodigoNegocio { get; set; }
        [Column("Negocio")]
        public string? Negocio { get; set; }
    }
}
