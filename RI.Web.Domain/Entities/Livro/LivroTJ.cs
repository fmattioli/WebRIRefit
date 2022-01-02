using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RI.Web.Domain.Entities.Livro
{
    public class LivroTJ
    {
        [Column("PK_ID")]
        public int Id { get; set; }
        [Column("Descricao")]
        public string? Descricao { get; set; }
    }
}
