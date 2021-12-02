using System;
using System.Windows.Forms;
using LocadoraLaumax.InterfacesGraficas;
using MySql.Data.MySqlClient;
using Entidades;
using System.Collections.Generic;

namespace BancoDados
{
    class BDUsuarios : BDComandos
    {
        public string TabelaUsuario { get; private set; }

        public BDUsuarios()
        {
            TabelaUsuario = "usuario";
        }
        public bool Login(Usuarios usuario)
        {
            try
            {
                string colunas = "usuario, senha";

                if (Consultar(TabelaUsuario, colunas, "usuario", "senha", usuario.Usuario, usuario.Senha))
                {
                    return true;
                }
                MessageBox.Show("Erro executar login ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro executar login " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        public bool AlterarSenha(Usuarios usuario, string senhaNova)
        {
            try
            {
                if (Consultar(TabelaUsuario, "usuario", usuario.Usuario) && Consultar(TabelaUsuario, "senha", usuario.Senha)
                    && Consultar(TabelaUsuario, "doc", usuario.Documento))
                {
                    Atualizar(TabelaUsuario, "senha", senhaNova, usuario.Documento);
                    return true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar selecionar os dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Autenticar(Usuarios usuario)
        {
            try
            {
                string colunas = "usuario, senha, cargo";
                if (Consultar(TabelaUsuario, colunas, "usuario", "senha", "cargo", usuario.Usuario, usuario.Senha, "Gerente"))
                {
                    return true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar autenticar usuário " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        public bool CadastrarUsuario(Usuarios usuario)
        {
            //para cadastrar usuario devo consultar se ja tem algum com o nome de usuario e doc igual, caso nao insiro 
            // criei uma variavel das colunas a serem pesquisadas para ficar facil a manunteção futura 
            string colunas = "usuario, doc";
            try
            {
                /*string valores = $"{usuario.Documento},{usuario.Nome},{usuario.Usuario},{usuario.Senha},{usuario.Cargo}" +
                        $"{frmAcesssoRestrito.docGerente},{frmLogin.docLogado},";*/

                string valores = $"'{usuario.Documento}','{usuario.Nome}','{usuario.Usuario}','{usuario.Senha}','{usuario.Cargo}'," +
                            $"'{frmAcesssoRestrito.docGerente}','{frmLogin.docLogado}'";
                if (!Consultar(TabelaUsuario, colunas, "usuario", "doc", usuario.Usuario, usuario.Documento) && Inserir(TabelaUsuario, ref valores))
                {
                    return true;
                }
                MessageBox.Show("Favor colocar dados não cadastrados", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Inserir usuário" + e);
            }
            finally
            {
                Desconectar();
            }
            return false;
        }
        public bool AtualizarUsuario(Usuarios usuario)
        {
            try
            {
                //olho se tem alguem já com o doc e altero se for true
                if (Consultar(TabelaUsuario, "doc", usuario.Documento))
                {
                    //olho se tem alguem já usando o usuario e so altero caso seja false
                    if (!Consultar(TabelaUsuario, "doc", usuario.Documento))
                    {   
                        //preciso melhor a forma de atualização 
                        Atualizar(TabelaUsuario, "doc", usuario.Documento, usuario.Documento);
                        Atualizar(TabelaUsuario, "nome", usuario.Nome, usuario.Documento);
                        Atualizar(TabelaUsuario, "usuario", usuario.Usuario, usuario.Documento);
                        Atualizar(TabelaUsuario, "senha", usuario.Senha, usuario.Documento);
                        Atualizar(TabelaUsuario, "cargo", usuario.Cargo, usuario.Documento);
                        Atualizar(TabelaUsuario, "kUsuarioGerente_doc", usuario.DocGerente, usuario.Documento);
                        Atualizar(TabelaUsuario, "fkUsuario_doc", usuario.DocUsuarioLogado, usuario.Documento);
                        return true;
                    }
                    MessageBox.Show("Nome de usuário indisponível", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Dados não encontrado ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Dados não encontrado " + erro, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            MessageBox.Show("Erro ao Inserir usuário ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        public string RetornaDoc(Usuarios usuario)
        {
            try
            {
                string colunas = "usuario, doc";
                if (Consultar(TabelaUsuario, colunas, "usuario", "doc", usuario.Usuario, usuario.Documento))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand("select doc from usuario where usuario = @usuario;", Conexao);
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@usuario", usuario.Usuario);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader["doc"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro inesperado" + e);
            }
            finally
            {
                Desconectar();
            }
            return string.Empty;
        }
        public List<Usuarios> ConsultaUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select * from usuario where usuario <> 'master';", Conexao);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(new Usuarios(reader["doc"].ToString(), reader["nome"].ToString(), reader["usuario"].ToString(),
                            reader["cargo"].ToString(), reader["fkUsuarioGerente_doc"].ToString(), reader["fkUsuario_doc"].ToString()));
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