using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BancoDados
{
    class BDVeiculos
    {
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public float ValorDiaria { get; set; }
        public int KmAtual { get; set; }
        public char Situacao { get; set; }
        public string DocUsuario { get; set; }

    }
}