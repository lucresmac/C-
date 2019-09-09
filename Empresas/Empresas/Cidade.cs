using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Cidade
    {
        [Required]
        public String Nome { get; set; }
        [Required]
        public String Estado { get; set; }

    }
}
