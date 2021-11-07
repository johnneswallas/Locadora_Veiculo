using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    class Clientes
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string DocUsuario { get; set; }
        public Clientes(string documento, string nome, string telefone, DateTime nascimento, string estadoCivil, string docUsuario)
        {
            Documento = documento;
            Nome = nome;
            Telefone = telefone;
            Nascimento = nascimento;
            EstadoCivil = estadoCivil;
            DocUsuario = docUsuario;
        }
        public Clientes(string documento, string nome, string telefone, DateTime nascimento, string estadoCivil)
        {
            Documento = documento;
            Nome = nome;
            Telefone = telefone;
            Nascimento = nascimento;
            EstadoCivil = estadoCivil;
        }
        public Clientes(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
