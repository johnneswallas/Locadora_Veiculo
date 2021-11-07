using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    class Veiculos
    {
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get ; set; }
        public DateTime Ano { get; set; }
        public float ValorDiaria { get; set; }
        public int KmAtual { get; set; }
        public char Situacao { get; set; }
        public string DocUsuario { get; set; }
        public Veiculos(string placa, string fabricante, string modelo, DateTime ano, float valorDiaria, int kmAtual, char situacao, string docUsuario)
        {
            Placa = placa;
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
            ValorDiaria = valorDiaria;
            KmAtual = kmAtual;
            Situacao = situacao;
        }
        public Veiculos( string fabricante, string modelo, DateTime ano, float valorDiaria, char situacao)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
            ValorDiaria = valorDiaria;
            Situacao = situacao;
        }
        public Veiculos(string placa, string fabricante, string modelo, DateTime ano, float valorDiaria, char situacao)
        {
            Placa = placa;
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
            ValorDiaria = valorDiaria;
            Situacao = situacao;
        }
    }
}
