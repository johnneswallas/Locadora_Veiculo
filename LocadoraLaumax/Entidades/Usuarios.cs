using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    class Usuarios
    {
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string DocGerente { get; set; }
        public string DocUsuarioLogado { get; set; }
        public Usuarios(string documento, string nome, string usuario, string senha, string cargo, string docGerente, string docUsuarioLogado)
        {
            Documento = documento;
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            Cargo = cargo;
            DocGerente = docGerente;
            DocUsuarioLogado = docUsuarioLogado;
        }
        public Usuarios(string documento, string nome, string usuario, string cargo, string docGerente, string docUsuarioLogado)
        {
            Documento = documento;
            Nome = nome;
            Usuario = usuario;
            Cargo = cargo;
            DocGerente = docGerente;
            DocUsuarioLogado = docUsuarioLogado;
        }
        public Usuarios(string documento, string usuario, string senha, string docUsuarioLogado)
        {
            Documento = documento;
            Usuario = usuario;
            Senha = senha;
            DocUsuarioLogado = docUsuarioLogado;
        }
        public Usuarios(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
