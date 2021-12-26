using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;

namespace BancoDados
{
    class BDDevolucao : BDComandos
    {
        public string TabelaDevolucao{ get; private set; }
        //public string ForeingKey_Usuario { get; set; }
        
        public BDDevolucao()
        {
            TabelaDevolucao = "devolucao";
        }

        public bool Devolucao(Devolucao devolucao, string placa)
        {
            try
            {
                if (Consultar("veiculo", "situacao", "I", placa))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("insert into devolucao values(?, ?, ?, ?);", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.Add("@codDevolucao", MySqlDbType.VarChar).Value = devolucao.CodDevolucao;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = devolucao.ForeingKey_Usuario;
                    command.Parameters.Add("@fkAlugar_codigo", MySqlDbType.VarChar).Value = devolucao.ForeingKey_Alugar;
                    command.Parameters.Add("@valorTot", MySqlDbType.Double).Value = devolucao.ValorTot;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    Atualizar("veiculo", "situacao", "D", "placa", placa);
                    return true;
                }
                MessageBox.Show("Veículo não localizado! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public List<PesquisaDevolucao> PesquisaDevolucao(string documento, string placa)
        {
            List<PesquisaDevolucao> lista = new List<PesquisaDevolucao>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select alugar.codigoAluguel, alugar.fkCliente_doc, cliente.nome, alugar.fkCarro_placa, alugar.dataInicio, alugar.datafim, alugar.valorDiaria from alugar join veiculo on " +
                 "alugar.fkCarro_placa =  veiculo.placa join cliente on alugar.fkCliente_doc = cliente.doc where situacao = 'I';",Conexao);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["fkCliente_doc"].ToString() == documento && reader["fkCarro_placa"].ToString() == placa)
                        {
                            lista.Add(new PesquisaDevolucao(Convert.ToDateTime(reader["dataInicio"].ToString()), Convert.ToDateTime(reader["dataFim"].ToString()), Convert.ToDouble(reader["valorDiaria"].ToString()),
                                reader["fkCliente_doc"].ToString(), reader["nome"].ToString(), reader["fkCarro_placa"].ToString(), reader["codigoAluguel"].ToString()));
                            break;
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao vericar cliente " + erro, "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
    }
}