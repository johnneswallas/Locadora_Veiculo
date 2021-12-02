using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDBancoDados
{
    class Alugar
    {
        public string CodigoAluguel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double ValorDiaria { get; set; }
        public string ForeingKey_Cliente { get; set; }
        public string ForeingKey_Carro { get; set; }
        public string ForeingKey_Usuario { get; set; }

    }
}