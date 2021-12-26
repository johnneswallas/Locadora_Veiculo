using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;
using BancoDados;

namespace BancoDados
{
    class BDAlugar : BDComandos
    {
        public string TabelaAlugar { get; private set; }
        public string TabelaVeiculo { get; private set; }

        public BDAlugar()
        {
            TabelaVeiculo = "veiculo";
            TabelaAlugar = "alugar";
        }

        public bool RetiradaVeiculo(Alugar alugar)
        {
            try
            {
                if (!Consultar(TabelaAlugar, "codigoAluguel", alugar.CodigoAluguel)
                    && Consultar(TabelaVeiculo, "situacao","D", alugar.ForeingKey_Carro)
                    && !new BDClientes().SituacaoCliente(alugar.ForeingKey_Cliente))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("insert into alugar values(?, ?, ?, ?, ?, ?, ?, ?);", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.Add("@codigoAluguel", MySqlDbType.Double).Value = alugar.CodigoAluguel;
                    command.Parameters.Add("@dataInicio", MySqlDbType.Date).Value = alugar.DataInicio;
                    command.Parameters.Add("@dataFim", MySqlDbType.Date).Value = alugar.DataFim;
                    command.Parameters.Add("@dataContrato", MySqlDbType.Date).Value = DateTime.Now;
                    command.Parameters.Add("@valorDiaria", MySqlDbType.Decimal).Value = alugar.ValorDiaria;
                    command.Parameters.Add("@fkveiculo_doc ", MySqlDbType.VarChar).Value = alugar.ForeingKey_Usuario;
                    command.Parameters.Add("@fkCliente_doc ", MySqlDbType.VarChar).Value = alugar.ForeingKey_Cliente;
                    command.Parameters.Add("@fkCarro_placa ", MySqlDbType.VarChar).Value = alugar.ForeingKey_Carro;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    if (Atualizar(TabelaVeiculo, "situacao", "I", "placa", alugar.ForeingKey_Carro))
                    {
                        return true;
                    }
                }
                MessageBox.Show("Erro tente novamente ", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir registro " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }

        public List<ListaVeiculos> ConsultaVeiculosAlocados()
        {
            List<ListaVeiculos> lista = new List<ListaVeiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select veiculo.situacao, alugar.fkCarro_placa, veiculo.modelo, alugar.dataFim," +
                    " cliente.nome, alugar.fkCliente_doc, cliente.telefone from alugar join veiculo on alugar.fkCarro_placa = veiculo.placa" +
                    " join cliente on alugar.fkCliente_doc = cliente.doc;", Conexao);
                command.Parameters.Clear();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(new ListaVeiculos(reader["situacao"].ToString(), reader["fkCarro_placa"].ToString(), reader["modelo"].ToString(),
                            Convert.ToDateTime(reader["dataFim"].ToString()), reader["nome"].ToString(), reader["fkCliente_doc"].ToString(), reader["telefone"].ToString()));
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao pesquisar dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        public List<ListaVeiculos> ConsultaVeiculosAlocados(string situacao)
        {
            List<ListaVeiculos> lista = new List<ListaVeiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select veiculo.situacao, alugar.fkCarro_placa, veiculo.modelo, alugar.dataFim," +
                    " cliente.nome, alugar.fkCliente_doc, cliente.telefone from alugar join veiculo on alugar.fkCarro_placa = veiculo.placa" +
                    " join cliente on alugar.fkCliente_doc = cliente.doc where situacao = '" + situacao + "' ;", Conexao);
                command.Parameters.Clear();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(new ListaVeiculos(reader["situacao"].ToString(), reader["fkCarro_placa"].ToString(), reader["modelo"].ToString(),
                            Convert.ToDateTime(reader["dataFim"].ToString()), reader["nome"].ToString(), reader["fkCliente_doc"].ToString(), reader["telefone"].ToString()));
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao pesquisar dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        public List<ListaVeiculos> ConsultaVeiculosAlocados(DateTime data)
        {
            List<ListaVeiculos> lista = new List<ListaVeiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select veiculo.situacao, alugar.fkCarro_placa, veiculo.modelo, alugar.dataFim," +
                    " cliente.nome, alugar.fkCliente_doc, cliente.telefone from alugar join veiculo on alugar.fkCarro_placa = veiculo.placa" +
                    " join cliente on alugar.fkCliente_doc = cliente.doc where situacao = 'I' and dataFim < ? ;", Conexao);
                command.Parameters.Clear();
                command.Parameters.Add("@dataFim", MySqlDbType.Date).Value = data;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(new ListaVeiculos(reader["situacao"].ToString(), reader["fkCarro_placa"].ToString(), reader["modelo"].ToString(),
                            Convert.ToDateTime(reader["dataFim"].ToString()), reader["nome"].ToString(), reader["fkCliente_doc"].ToString(), reader["telefone"].ToString()));
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao pesquisar dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }


    }
}