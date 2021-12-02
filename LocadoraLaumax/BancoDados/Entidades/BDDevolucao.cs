using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    class BDDevolucao
    {
        public string CodDevolucao { get; set; }
        public string ForeingKey_Usuario { get; set; }
        public string ForeingKey_Alugar { get; set; }
        public double ValorTot { get; set; }

    }
}