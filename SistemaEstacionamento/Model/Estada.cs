using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Model
{
    class Estada
    {
        public DateTime entrada { get; set; }
        public DateTime saida { get; set; }
        public String tipo { get; set; }
        public String usuario { get; set; }

    }
}
