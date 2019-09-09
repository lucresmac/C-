using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }

        [Required]

        public DateTime admissao { get; set; }

        public DateTime demissao { get; set; }
    
    }
}
