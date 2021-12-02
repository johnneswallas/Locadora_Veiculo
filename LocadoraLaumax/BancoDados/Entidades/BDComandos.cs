﻿using MySql.Data.MySqlClient;
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
        protected bool Inserir<T>(string tabela, ref T valores)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("insert into "+tabela+" values(" + valores + ");", Conexao);
                //command.Parameters.Clear();
                //command.Parameters.AddWithValue("@tabela", tabela);
                //command.Parameters.Add("@values", MySqlDbType.VarChar).Value = valores;
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
        protected bool Atualizar(string tabela, string coluna, string valor, string primaryKey)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("update " + tabela + " set " + coluna
                    + " = @valor where doc = @primaryKey;", Conexao);
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
        protected bool Excluir(string tabela, string primaryKey)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("delete @tabela where = @primaryKey", Conexao);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@tabela", tabela);
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
        protected bool Consultar(string tabela, string coluna, string dadoComparar1)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select " + coluna + " from " + tabela + " where "
                    + coluna + "= @dadoComparar1;", Conexao);
                command.Parameters.Clear();
                command.Parameters.Add("@dadoComparar1", MySqlDbType.VarChar).Value = dadoComparar1;
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
        protected bool Consultar(string tabela, string colunas, string coluna1, string coluna2, string dadoComparar1, string dadoComparar2)
        {
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select " + colunas + " from " + tabela + " where " + coluna1 +
                    " = @dadoComparar1 or " + coluna2 + " = @dadoComparar2", Conexao);
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