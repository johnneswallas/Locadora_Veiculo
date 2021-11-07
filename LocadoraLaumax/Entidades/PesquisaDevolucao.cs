using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    class PesquisaDevolucao
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double ValorDiaria { get; set; }
        public string ForeingKey_Cliente { get; set; }
        public string NomeCliente { get; set; }
        public string ForeingKey_Carro { get; set; }
        public string ForeingKey_Alugar { get; set; }
        public PesquisaDevolucao(DateTime dataInicio, DateTime dataFim, double valorDiaria, string foreingKey_Cliente, 
            string nomeCliente, string foreingKey_Carro, string foreingKey_Alugar)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            ValorDiaria = valorDiaria;
            ForeingKey_Cliente = foreingKey_Cliente;
            NomeCliente = nomeCliente;
            ForeingKey_Carro = foreingKey_Carro;
            ForeingKey_Alugar = foreingKey_Alugar;
        }
    }
}
