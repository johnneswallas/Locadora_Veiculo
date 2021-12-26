using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using LocadoraLaumax.InterfacesGraficas;

namespace BancoDados
{
    class BDClientes : BDComandos
    {
        public string TabelaCliente { get; private set; }
        public string ColunaDoc { get; private set; }


        public BDClientes()
        {
            TabelaCliente = "cliente";
            ColunaDoc = "doc";
        }

        public bool CadastrarCliente(Clientes cliente)
        {
            try
            {
                if (!Consultar(TabelaCliente, ColunaDoc, cliente.Documento))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("insert into cliente values(?, ?, ?, ?, ?, ?);", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = cliente.Documento;
                    command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cliente.Nome;
                    command.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cliente.Telefone;
                    command.Parameters.Add("@nascimento", MySqlDbType.Date).Value = cliente.Nascimento;
                    command.Parameters.Add("@estadoCivil", MySqlDbType.VarChar).Value = cliente.EstadoCivil;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
                MessageBox.Show("Favor colocar dados não cadastrados", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cadastrar usuário" + e);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        public bool AtualizarCliente(Clientes cliente)
        {
            try
            {
                if (Consultar(TabelaCliente, ColunaDoc, cliente.Documento))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("update cliente set doc = ?, nome = ?, telefone = ?, nascimento = ?," +
                        " estadoCivil = ?, fkUsuario_doc = ? where doc = '" + cliente.Documento + "';",Conexao);
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = cliente.Documento;
                    command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cliente.Nome;
                    command.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cliente.Telefone;
                    command.Parameters.Add("@nascimento", MySqlDbType.DateTime).Value = cliente.Nascimento;
                    command.Parameters.Add("@estadoCivil", MySqlDbType.VarChar).Value = cliente.EstadoCivil;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true;
                }
                MessageBox.Show("Cliente não cadastrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir usuário " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        public bool SituacaoCliente(string documento)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select veiculo.placa, alugar.fkCliente_doc from alugar join veiculo on alugar.fkCarro_placa = veiculo.placa " +
                    "join cliente on alugar.fkCliente_doc = @fkCliente_doc where situacao = 'I'; ", Conexao);
                command.Parameters.AddWithValue("@fkCliente_doc", documento);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Cliente já esta alugando veículo", "Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
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
            return false;
        }
        
        public List<Clientes> ConsultarCampoClientes(string pesquisar, int n)
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select nome, telefone, doc, estadoCivil, nascimento  from cliente where doc = @doc;",Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@doc", pesquisar.Trim());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(new Clientes(reader["doc"].ToString().Trim(), reader["nome"].ToString().Trim(), reader["telefone"].ToString().Trim(), DateTime.Parse(reader["nascimento"].ToString().Trim()), reader["estadoCivil"].ToString().Trim()));
                        break;
                    }
                }
                Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conferir dados " + erro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        public List<Clientes> ConsultarCampoClientes(string pesquisa)
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select nome, telefone from cliente where nome like @nome " +
                    "or telefone like @telefone or doc like @doc;",Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nome", "%" + pesquisa.ToUpper().Trim() + "%");
                command.Parameters.AddWithValue("@telefone", "%" + pesquisa.ToUpper().Trim() + "%");
                command.Parameters.AddWithValue("@doc", "%" + pesquisa.ToUpper().Trim() + "%");
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(new Clientes(reader["nome"].ToString().ToUpper().Trim(), reader["telefone"].ToString().ToUpper().Trim()));
                    }
                }
                Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conferir dados " + erro, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        

    }
}