using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Cargo
    {
        public int id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string atribuicao { get; set; }

        public decimal SalarioBase { get; set; }

        public IList<Departamento> Departamentos { get; set; }
     
    }
}
