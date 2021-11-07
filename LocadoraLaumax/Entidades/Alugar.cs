using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
        public Alugar(string codigoAluguel, DateTime dataInicio, DateTime dataFim, double valorDiaria,
            string foreingKey_Cliente, string foreingKey_Carro, string foreingKey_Usuario)
        {
            CodigoAluguel = codigoAluguel;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ValorDiaria = valorDiaria;
            ForeingKey_Cliente = foreingKey_Cliente;
            ForeingKey_Carro = foreingKey_Carro;
            ForeingKey_Usuario = foreingKey_Usuario;
        }
    }
}
