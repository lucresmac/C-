using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Endereço
    {
        [Required]
        public String Rua { get; set; }

        public int CEP { get; set; }

        public String numero { get; set; }

        public String Complemento  { get; set; }

        [Required]
        public Cidade cidade { get; set; }

    }
}
