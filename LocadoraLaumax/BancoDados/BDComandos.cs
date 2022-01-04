using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDados
{
    class BDComandos
    {
        public MySqlConnection Conexao { get; private set; }
        public BDComandos()
        {
            Conexao = new MySqlConnection(stringConexao);
        }
        public static string stringConexao;
        protected bool fBdAberto = false;
        protected void Conectar()
        {
            try
            {
                if (!fBdAberto)
                {
                    Conexao.Open();
                    fBdAberto = true;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro na abertura do banco de dados" + erro);
                Application.Exit();
            }
        }
        protected void Desconectar()
        {
            try
            {
                if (fBdAberto)
                {
                    Conexao.Close();
                    fBdAberto = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no fechamento do banco de dados" + e);
            }
        }
        public bool TesteConexao(string stringConexao)
        {
            try
            {
                MySqlConnection testeConexao = new MySqlConnection(stringConexao);
                testeConexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        protected bool Inserir<T>(string tabela, ref T valores)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("insert into " + tabela + " values(" + valores + ");", Conexao);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        protected bool Atualizar(string tabela, string coluna, string valor, string where, string primaryKey)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("update " + tabela + " set " + coluna + " = @valor where " + where + "= @primaryKey;", Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@valor", valor);
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.ExecuteNonQuery();
                return true;
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
        protected bool Excluir(string tabela, string nomeKey, string primaryKey)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("delete from "+tabela+" where " + nomeKey + " = @primaryKey;", Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@primaryKey", primaryKey);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        protected bool Consultar(string tabela, string coluna, string dadoComparar)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select " + coluna + " from " + tabela + " where "
                    + coluna + "= @dadoComparar1;", Conexao);
                command.Parameters.Clear();
                command.Parameters.Add("@dadoComparar1", MySqlDbType.VarChar).Value = dadoComparar;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na consulta ao banco de dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        protected bool Consultar(string tabela, string coluna, string dadoComparar, string primaryKey)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select " + coluna + " from " + tabela + " where "
                    + coluna + "= @dadoComparar and placa = @primaryKey;", Conexao);
                command.Parameters.Clear();
                command.Parameters.Add("@dadoComparar", MySqlDbType.VarChar).Value = dadoComparar;
                command.Parameters.Add("@@primaryKey", MySqlDbType.VarChar).Value = @primaryKey;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na consulta ao banco de dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        //posso colocar um vetor ao inves de pedir esse monte de parametros
        protected bool Consultar(string tabela, string colunas, string coluna1, string coluna2, string dadoComparar1, string dadoComparar2)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select " + colunas + " from " + tabela + " where " + coluna1 +
                    " = @dadoComparar1 and " + coluna2 + " = @dadoComparar2", Conexao);
                command.Parameters.Clear();
                command.Parameters.Add("@dadoComparar1", MySqlDbType.VarChar).Value = dadoComparar1;
                command.Parameters.Add("@dadoComparar2", MySqlDbType.VarChar).Value = dadoComparar2;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na consulta ao banco de dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        protected bool Consultar(string tabela, string colunas, string coluna1, string coluna2, string coluna3, string dadoComparar1, string dadoComparar2, string dadoComparar3)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select " + colunas + " from " + tabela + " where " + coluna1 +
                    " = @dadoComparar1 and " + coluna2 + " = @dadoComparar2 and " + coluna3 + " = @dadoComparar3;", Conexao);
                command.Parameters.Clear();
                command.Parameters.Add("@dadoComparar1", MySqlDbType.VarChar).Value = dadoComparar1;
                command.Parameters.Add("@dadoComparar2", MySqlDbType.VarChar).Value = dadoComparar2;
                command.Parameters.Add("@dadoComparar3", MySqlDbType.VarChar).Value = dadoComparar3;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na consulta ao banco de dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }

    }
}
