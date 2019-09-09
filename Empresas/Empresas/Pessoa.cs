using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Pessoa
    {
        public int id { get; set; }
        [Required]
        public String Nome { get; set; }
        [Required]
        public int CPF { get; set; }
        [Required]
        public Cargo Cargo { get; set; }
    
        public IList<Locacao> Locacao { get; set; }

        public DateTime Admissao { get; set; }

        public DateTime Demissao { get; set; }
        [Required]
        public Departamento Departamento { get; set; }
    }
}
