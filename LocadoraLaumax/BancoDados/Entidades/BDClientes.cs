using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BancoDados
{
    class BDClientes
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string DocUsuario { get; set; }

    }
}