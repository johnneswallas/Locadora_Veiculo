using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LocadoraLaumax.InterfacesGraficas;
using MySql.Data.MySqlClient;
using System.Data;

namespace BancoDados
{
    class BDVeiculos : BDComandos
    {
        public string TabelaVeiculo { get; private set; }
        public string TabelaAlugar { get; private set; }



        public BDVeiculos()
        {
            TabelaVeiculo = "veiculo";
            TabelaAlugar = "alugar";
        }



        public bool CadastrarVeiculo(Veiculos veiculo)
        {
            try
            {
                //consultar se ja tem algum placa cadastrada
                if (!Consultar(TabelaVeiculo, "placa", veiculo.Placa))
                {
                    //insiro registro manualmente ou posso chamar o inserir() mas tenho q inserir 1 por 1 
                    Conectar();
                    MySqlCommand command = new MySqlCommand("insert into veiculo values(?, ?, ?, ?, ?, ?, ?, ?);", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = veiculo.Placa;
                    command.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = veiculo.Fabricante;
                    command.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = veiculo.Modelo;
                    command.Parameters.Add("@ano", MySqlDbType.Date).Value = veiculo.Ano;
                    command.Parameters.Add("@valorDiaria", MySqlDbType.Float).Value = veiculo.ValorDiaria;
                    command.Parameters.Add("@km", MySqlDbType.Int32).Value = veiculo.KmAtual;
                    command.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = veiculo.Situacao;
                    command.Parameters.Add("@fkveiculo_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
                MessageBox.Show("Favor colocar dados não cadastrados", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            MessageBox.Show("Erro ao inserir registro ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public bool AtualizarVeiculo(Veiculos veiculo)
        {
            try
            {
                if (Consultar(TabelaVeiculo, "placa", veiculo.Placa))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("update veiculo set placa = @placa, fabricante = @fabricante, modelo = @modelo, ano = @ano, " +
                        "valorDiaria = @valorDiaria, km = @km, situacao = @situacao, fkUsuario_doc = @fkUsuario_doc where placa = @primaryKey;", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@placa", veiculo.Placa);
                    command.Parameters.AddWithValue("@fabricante", veiculo.Fabricante);
                    command.Parameters.AddWithValue("@modelo", veiculo.Modelo);
                    command.Parameters.AddWithValue("@ano", veiculo.Ano);
                    command.Parameters.AddWithValue("@valorDiaria", veiculo.ValorDiaria);
                    command.Parameters.AddWithValue("@km", veiculo.KmAtual);
                    command.Parameters.AddWithValue("@situacao", veiculo.Situacao);
                    command.Parameters.AddWithValue("@fkUsuario_doc", veiculo.DocUsuario);
                    command.Parameters.AddWithValue("@primaryKey", veiculo.Placa);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
                MessageBox.Show("Veículo não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        public bool ExcluirVeiculo(string primaryKey)
        {
            try
            {
                if (Excluir(TabelaVeiculo, "placa", primaryKey))
                {
                    return true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            return false;
        }
        public List<Veiculos> DadosPorPlaca(string placa)
        {
            List<Veiculos> lista = new List<Veiculos>();
            try
            {
                if (Consultar(TabelaVeiculo, "placa", placa))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("select placa, fabricante, modelo, ano, valorDiaria, km, situacao from veiculo where placa = ?;", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string fabricante = reader["fabricante"].ToString();
                        string modelo = reader["modelo"].ToString();
                        DateTime ano = DateTime.Parse(reader["ano"].ToString());
                        float valorDiaria = float.Parse(reader["valorDiaria"].ToString());
                        char situacao = char.Parse(reader["situacao"].ToString());
                        lista.Add(new Veiculos(reader["placa"].ToString(), fabricante, modelo, ano, valorDiaria, situacao));
                        return lista;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        public List<Veiculos> DadosPorCampoPesquisar(string pesquisa)
        {
            List<Veiculos> lista = new List<Veiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select placa, fabricante, modelo, ano, valorDiaria, situacao from veiculo " +
                    "where placa like @placa or fabricante like @fabricante or modelo like @modelo or ano like @ano " +
                    "or valorDiaria like @valorDiaria or situacao like @situacao;", Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@placa", "%" + pesquisa.ToUpper().Trim() + "%");
                command.Parameters.AddWithValue("@fabricante", "%" + pesquisa.ToUpper().Trim() + "%");
                command.Parameters.AddWithValue("@modelo", "%" + pesquisa.ToUpper().Trim() + "%");
                command.Parameters.AddWithValue("@ano", "%" + pesquisa.Trim() + "%");
                command.Parameters.AddWithValue("@valorDiaria", "%" + pesquisa.Trim() + "%");
                command.Parameters.AddWithValue("@situacao", "%" + pesquisa.ToUpper().Trim().FirstOrDefault() + "%");
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string placa = reader["placa"].ToString();
                        string fabricante = reader["fabricante"].ToString();
                        string modelo = reader["modelo"].ToString();
                        DateTime ano = DateTime.Parse(reader["ano"].ToString());
                        float valorDiaria = float.Parse(reader["valorDiaria"].ToString());
                        char situacao = char.Parse(reader["situacao"].ToString());
                        lista.Add(new Veiculos(placa, fabricante, modelo, ano, valorDiaria, situacao));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        public List<Veiculos> ListaVeiculo()
        {
            List<Veiculos> lista = new List<Veiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select * from " + TabelaVeiculo + ";", Conexao);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Veiculos veiculo = new Veiculos(reader["placa"].ToString(), reader["fabricante"].ToString(), 
                            reader["modelo"].ToString(), Convert.ToDateTime(reader["ano"].ToString()), 
                            float.Parse(reader["valorDiaria"].ToString()), int.Parse(reader["km"].ToString()), 
                            char.Parse(reader["situacao"].ToString()), reader["fkUsuario_Doc"].ToString());
                        lista.Add(veiculo);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        public List<Veiculos> ListaVeiculoPorSituacao(string situacao)
        {
            List<Veiculos> lista = new List<Veiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select * from " + TabelaVeiculo + " where situacao = @condicao;", Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@condicao", situacao);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Veiculos veiculo = new Veiculos(reader["placa"].ToString(), reader["fabricante"].ToString(),
                            reader["modelo"].ToString(), Convert.ToDateTime(reader["ano"].ToString()),
                            float.Parse(reader["valorDiaria"].ToString()), int.Parse(reader["km"].ToString()),
                            char.Parse(reader["situacao"].ToString()), reader["fkUsuario_Doc"].ToString());
                        lista.Add(veiculo);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
       
    }
}