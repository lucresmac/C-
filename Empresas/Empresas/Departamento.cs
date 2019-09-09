using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas
{
    public class Departamento
    {
        public int id { get; set; }

        public string Nome { get; set; }

        public IList<Cargo> Cargos {get;set;}
    }
}
