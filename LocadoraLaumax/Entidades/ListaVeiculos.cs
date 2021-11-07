using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    class ListaVeiculos
    {
        public string SituacaoVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public DateTime DataFim { get; set; }
        public string NomeCliente { get; set; }
        public string DocCliente { get; set; }
        public string Telefone { get; set; }
        public ListaVeiculos(string situacaoVeiculo, string placaVeiculo, string modeloVeiculo,
            DateTime dataFim, string nomeCliente, string docCliente, string telefone)
        {
            SituacaoVeiculo = situacaoVeiculo;
            PlacaVeiculo = placaVeiculo;
            ModeloVeiculo = modeloVeiculo;
            DataFim = dataFim;
            NomeCliente = nomeCliente;
            DocCliente = docCliente;
            Telefone = telefone;
        }
    }
}
