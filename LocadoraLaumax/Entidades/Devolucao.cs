using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Devolucao
    {
        public string CodDevolucao { get; set; }
        public string ForeingKey_Usuario { get; set; }
        public string ForeingKey_Alugar { get; set; }
        public double ValorTot { get; set; }

        public Devolucao(string codDevolucao, string foreingKey_Usuario, string foreingKey_Alugar, double valorTot)
        {
            CodDevolucao = codDevolucao;
            ForeingKey_Usuario = foreingKey_Usuario;
            ForeingKey_Alugar = foreingKey_Alugar;
            ValorTot = valorTot;
        }
    }
}
