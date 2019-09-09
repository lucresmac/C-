using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Locacao
    {
        public int id { get; set; }
        [Required]
        public decimal Salario { get; set; }
        [Required]
        public DateTime inicio { get; set; }

        public DateTime fim { get; set; }
        [Required]
        public Cargo Cargo { get; set; }
        [Required]
        public Departamento Departamento { get; set; }


    }
}
