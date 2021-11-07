using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Entidades;
using System.Data;
using LocadoraLaumax.InterfacesGraficas;
namespace BancoDados
{
    class Comandos
    {
        public bool fBdAberto = false;
        MySqlConnection conexao = new MySqlConnection();
        public static string servidor;
        public void Conectar()
        {
            try
            {
                if (!fBdAberto)
                {
                    conexao.ConnectionString = servidor;
                    conexao.Open();
                    fBdAberto = true;
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro na abertura do banco de dados" + erro);
                Application.Exit();
            }
        }
        public void Desconectar()
        {
            try
            {
                if (fBdAberto)
                {
                    conexao.Close();
                    fBdAberto = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no fechamento do banco de dados" + e);
            }
        }
        public bool Login(Usuarios usuarios)
        {
            bool fsucesso = false;
            try
            {
                string bdUsuario = null;
                string bdSenha = null;
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select usuario, senha, nome, doc from usuario where usuario = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuarios.Usuario;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        frmLogin.nomeLogado = reader["usuario"].ToString();
                        frmLogin.docLogado = reader["doc"].ToString();
                        bdUsuario = reader["usuario"].ToString();
                        bdSenha = reader["senha"].ToString();
                        if (reader["usuario"].ToString() == usuarios.Usuario && reader["senha"].ToString() == usuarios.Senha)
                        {
                            fsucesso = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro executar login " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public bool AlterarSenha(Usuarios usuario, string senhaNova)
        {
            bool fsucesso = false;
            string bdUsuario = null;
            string bdSenha = null;
            string bdDocumento = null;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select usuario, senha, doc from usuario where doc = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = usuario.Documento;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bdUsuario = reader["usuario"].ToString();
                        bdSenha = reader["senha"].ToString();
                        bdDocumento = reader["doc"].ToString();
                        Desconectar();
                        break;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar selecionar os dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (bdUsuario == usuario.Usuario && bdSenha == usuario.Senha && usuario.Documento == bdDocumento)
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("update usuario set senha = ?, fkUsuario_doc = ? where doc = ?;");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senhaNova;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = usuario.Documento;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fsucesso = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar atualizar os dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public bool Autenticar(string usuario, string senha)
        {
            bool fautenticar = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select usuario, senha, doc from usuario where cargo = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = "Gerente";
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["usuario"].ToString() == usuario && reader["senha"].ToString() == senha)
                        {
                            frmAcesssoRestrito.docGerente = reader["doc"].ToString();
                            fautenticar = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar autenticar usuário " + erro, "ERRO",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return fautenticar;
        }
        public bool CadastrarUsuario(Usuarios usuario)
        {
            string bdDocumento = string.Empty;
            string bdUsuario = string.Empty;
            bool fsucesso = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select usuario, doc from usuario where doc = ? or usuario = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = usuario.Documento;
                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.Usuario;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bdUsuario = reader["usuario"].ToString();
                        bdDocumento = reader["doc"].ToString();
                        if (usuario.Usuario == bdUsuario || usuario.Documento == bdDocumento)
                        {
                            MessageBox.Show("Favor colocar dados não cadastrados", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Desconectar();
                            break;
                        }
                    }
                }
                Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao tentar selecionar informações no banco de dados" + e);
            }
            try
            {
                if (bdDocumento.Equals(string.Empty) && bdUsuario.Equals(string.Empty))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("insert into usuario values(?, ?, ?, ?, ?, ?, ?);");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = usuario.Documento;
                    command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nome;
                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.Usuario;
                    command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
                    command.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = usuario.Cargo;
                    command.Parameters.Add("@fkUsuarioGerente_doc", MySqlDbType.VarChar).Value = frmAcesssoRestrito.docGerente;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fsucesso = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Inserir usuário" + e);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public bool CadastrarVeiculo(Veiculos veiculo)
        {
            bool fcadastrar = false;
            string bdPlaca = string.Empty;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select placa from veiculo where placa = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = veiculo.Placa;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //so para conferir mesmo
                        bdPlaca = reader["placa"].ToString();
                        if (veiculo.Placa == bdPlaca)
                        {
                            MessageBox.Show("Favor colocar dados não cadastrados", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Desconectar();
                            break;
                        }
                    }
                }
                Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (bdPlaca.Equals(string.Empty))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("insert into veiculo values(?, ?, ?, ?, ?, ?, ?, ?);");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = veiculo.Placa;
                    command.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = veiculo.Fabricante;
                    command.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = veiculo.Modelo;
                    command.Parameters.Add("@ano", MySqlDbType.Date).Value = veiculo.Ano;
                    command.Parameters.Add("@valorDiaria", MySqlDbType.Float).Value = veiculo.ValorDiaria;
                    command.Parameters.Add("@km", MySqlDbType.Int32).Value = veiculo.KmAtual;
                    command.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = veiculo.Situacao;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fcadastrar = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir registro " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return fcadastrar;
        }
        public bool CadastrarCliente(Clientes cliente)
        {
            string bdDocumento = string.Empty;
            bool fsucesso = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select doc from cliente where doc = ? ;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = cliente.Documento;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bdDocumento = reader["doc"].ToString();
                        MessageBox.Show("Favor colocar dados não cadastrados", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Desconectar();
                        break;
                    }
                }
                Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao tentar selecionar informações no banco de dados" + e);
            }
            try
            {
                if (bdDocumento.Equals(string.Empty))
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("insert into cliente values(?, ?, ?, ?, ?, ?);");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = cliente.Documento;
                    command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cliente.Nome;
                    command.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cliente.Telefone;
                    command.Parameters.Add("@nascimento", MySqlDbType.Date).Value = cliente.Nascimento;
                    command.Parameters.Add("@estadoCivil", MySqlDbType.VarChar).Value = cliente.EstadoCivil;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fsucesso = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao Inserir Cliente" + e);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public List<Veiculos> ConsultarPlacaVeiculo(string placa)
        {
            List<Veiculos> lista = new List<Veiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select placa, fabricante, modelo, ano, valorDiaria, km, situacao from veiculo where placa = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string fabricante = reader["fabricante"].ToString();
                        string modelo = reader["modelo"].ToString();
                        DateTime ano = DateTime.Parse(reader["ano"].ToString());
                        float valorDiaria = float.Parse(reader["valorDiaria"].ToString());
                        char situacao = char.Parse(reader["situacao"].ToString());
                        //add o retorno de uma lista em outra lista 
                        lista.Add(new Veiculos(reader["placa"].ToString(), fabricante, modelo, ano, valorDiaria, situacao));
                        Desconectar();
                        break;
                    }
                }
                Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        public List<Veiculos> ConsultarCampoVeiculo(string pesquisa)
        {
            List<Veiculos> lista = new List<Veiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand(); // or ano like '%?%' or valorDiaria like '%?%'
                command.CommandText = ("select placa, fabricante, modelo, ano, valorDiaria, situacao from veiculo where placa like @placa or fabricante like @fabricante or modelo like @modelo" +
                    " or ano like @ano or valorDiaria like @valorDiaria or situacao like @situacao;");
                command.Connection = conexao;
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
                Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }
        public List<Clientes> ConsultarCampoClientes(string pesquisa)
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select nome, telefone from cliente where nome like @nome or telefone like @telefone or doc like @doc;");
                command.Connection = conexao;
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
        //Sobrecarga
        public List<Clientes> ConsultarCampoClientes(string pesquisar, int n)
        {
            List<Clientes> lista = new List<Clientes>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select nome, telefone, doc, estadoCivil, nascimento  from cliente where doc = @doc;");
                command.Connection = conexao;
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
        public bool AtualizarUsuario(Usuarios usuario)
        {
            string bdDocumento = string.Empty;
            bool fsucesso = false;
            bool fAltenticado = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select doc from usuario where doc = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = usuario.Documento;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bdDocumento = reader["doc"].ToString();
                        if (!bdDocumento.Equals(string.Empty))
                        {
                            fAltenticado = true;
                            Desconectar();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Dados não encontrado", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Dados não encontrado " + erro, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select usuario from usuario where usuario = '" + usuario.Usuario + "'; ");
                command.Connection = conexao;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        fAltenticado = false;
                        MessageBox.Show("Nome de usuário indisponível", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Desconectar();
                        break;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Dados não encontrado " + erro, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                if (fAltenticado)
                {
                    Desconectar();
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("update usuario set senha = ?, doc = ?, nome = ?, usuario = ?, cargo = ?, fkUsuarioGerente_doc = ?, fkUsuario_doc = ? where doc = '" + usuario.Documento + "';");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.Senha;
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = usuario.Documento;
                    command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = usuario.Nome;
                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.Usuario;
                    command.Parameters.Add("@cargo", MySqlDbType.VarChar).Value = usuario.Cargo;
                    command.Parameters.Add("@fkUsuarioGerente_doc", MySqlDbType.VarChar).Value = frmAcesssoRestrito.docGerente;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fsucesso = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir usuário "+ erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public bool AtualizarCliente(Clientes cliente)
        {
            string bdDocumento = string.Empty;
            bool fsucesso = false;
            bool fAltenticado = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select doc from cliente where doc = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = cliente.Documento;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bdDocumento = reader["doc"].ToString();
                        fAltenticado = true;
                        Desconectar();
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar selecionar dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (fAltenticado)
                {
                    Desconectar();
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("update cliente set doc = ?, nome = ?, telefone = ?, nascimento = ?, estadoCivil = ?, fkUsuario_doc = ? where doc = '" + cliente.Documento + "';");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = cliente.Documento;
                    command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = cliente.Nome;
                    command.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = cliente.Telefone;
                    command.Parameters.Add("@nascimento", MySqlDbType.DateTime).Value = cliente.Nascimento;
                    command.Parameters.Add("@estadoCivil", MySqlDbType.VarChar).Value = cliente.EstadoCivil;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fsucesso = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir usuário " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public bool AtualizarVeiculo(Veiculos veiculo)
        {
            bool fsucesso = false;
            string bdDocumento = string.Empty;
            bool fAltenticado = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select placa from veiculo where placa = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = veiculo.Placa;
                MySqlDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        fAltenticado = true;
                        Desconectar();
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Placa não cadastrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar selecionar dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (fAltenticado)
                {
                    Desconectar();
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("update veiculo set placa = ?, fabricante = ?, modelo = ?, ano = ?, valorDiaria = ?, km = ?, situacao = ?, fkUsuario_doc = ? where placa = '" + veiculo.Placa + "';");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = veiculo.Placa;
                    command.Parameters.Add("@fabricante", MySqlDbType.VarChar).Value = veiculo.Fabricante;
                    command.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = veiculo.Modelo;
                    command.Parameters.Add("@ano", MySqlDbType.Date).Value = veiculo.Ano;
                    command.Parameters.Add("@valorDiaria", MySqlDbType.Decimal).Value = veiculo.ValorDiaria;
                    command.Parameters.Add("@km", MySqlDbType.Int32).Value = veiculo.KmAtual;
                    command.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = veiculo.Situacao;
                    command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = frmLogin.docLogado;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    fsucesso = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Inserir dados " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        //Sobrecarga
        public bool AtualizarVeiculo(string placa, string situacao)
        {
            bool fsucesso = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("update veiculo set situacao = ? where placa = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@situacao", MySqlDbType.VarChar).Value = situacao;
                command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                fsucesso = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao aterar dados do veículo " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public bool SituacaoVeiculo(string placa)
        {
            bool fDisponivel = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select situacao from veiculo where placa = ?;");
                command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.ToChar(reader["situacao"]) == 'D')
                        {
                            fDisponivel = true;
                        }
                        else
                        {
                            MessageBox.Show("Erro veiculo INDISPONÍVEL ", "Indisponibilidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro tente novamente " + erro, "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Desconectar();
            }
            return fDisponivel;
        }
        public bool SituacaoCliente(string documento)
        {
            bool fDisponivel = true;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select veiculo.placa, alugar.fkCliente_doc from alugar join veiculo on alugar.fkCarro_placa = veiculo.placa" +
                    " join cliente on alugar.fkCliente_doc = cliente.doc where situacao = 'I';");
                command.Connection = conexao;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["fkCliente_doc"].ToString() == documento)
                        {
                            fDisponivel = false;
                            MessageBox.Show("Cliente já esta alugando veículo", "Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return fDisponivel;
        }
        public bool RetiradaVeiculo(Alugar alugar)
        {
            bool fsucesso = false;
            bool faltenticado = false;
            if (SituacaoCliente(alugar.ForeingKey_Cliente) && SituacaoVeiculo(alugar.ForeingKey_Carro))
            {
                try
                {
                    Conectar();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("select codigoAluguel from alugar where codigoAluguel = ?;");
                    command.Connection = conexao;
                    command.Parameters.Clear();
                    command.Parameters.Add("@codigoAluguel", MySqlDbType.Double).Value = alugar.CodigoAluguel;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Erro tente novamente ", "Conflito de dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        faltenticado = true;
                    }
                    Desconectar();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao conferir dados " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    if (faltenticado)
                    {
                        Conectar();
                        MySqlCommand command = new MySqlCommand();
                        command.CommandText = ("insert into alugar values(?, ?, ?, ?, ?, ?, ?, ?);");
                        command.Connection = conexao;
                        command.Parameters.Clear();
                        command.Parameters.Add("@codigoAluguel", MySqlDbType.Double).Value = alugar.CodigoAluguel;
                        command.Parameters.Add("@dataInicio", MySqlDbType.Date).Value = alugar.DataInicio;
                        command.Parameters.Add("@dataFim", MySqlDbType.Date).Value = alugar.DataFim;
                        command.Parameters.Add("@dataContrato", MySqlDbType.Date).Value = DateTime.Now;
                        command.Parameters.Add("@valorDiaria", MySqlDbType.Decimal).Value = alugar.ValorDiaria;
                        command.Parameters.Add("@fkUsuario_doc ", MySqlDbType.VarChar).Value = alugar.ForeingKey_Usuario;
                        command.Parameters.Add("@fkCliente_doc ", MySqlDbType.VarChar).Value = alugar.ForeingKey_Cliente;
                        command.Parameters.Add("@fkCarro_placa ", MySqlDbType.VarChar).Value = alugar.ForeingKey_Carro;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        if (AtualizarVeiculo(alugar.ForeingKey_Carro, "I"))
                        {
                            fsucesso = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao inserir registro " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Desconectar();
                }
            }
            return fsucesso;
        }
        public List<PesquisaDevolucao> PesquisaDevolucao(string documento, string placa)
        {
            List<PesquisaDevolucao> lista = new List<PesquisaDevolucao>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select alugar.codigoAluguel, alugar.fkCliente_doc, cliente.nome, alugar.fkCarro_placa, alugar.dataInicio, alugar.datafim, alugar.valorDiaria from alugar join veiculo on " +
                 "alugar.fkCarro_placa =  veiculo.placa join cliente on alugar.fkCliente_doc = cliente.doc where situacao = 'I';");
                command.Connection = conexao;
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
        public bool Devolucao(Devolucao devolucao, string placa)
        {
            bool fsucesso = false;
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("insert into devolucao values(?, ?, ?, ?);", conexao);
                //command.CommandText = ("insert into devolucao values(?, ?, ?, ?);");
                //command.Connection = conexao;
                command.Parameters.Clear();
                command.Parameters.Add("@codDevolucao", MySqlDbType.VarChar).Value = devolucao.CodDevolucao;
                command.Parameters.Add("@fkUsuario_doc", MySqlDbType.VarChar).Value = devolucao.ForeingKey_Usuario;
                command.Parameters.Add("@fkAlugar_codigo", MySqlDbType.VarChar).Value = devolucao.ForeingKey_Alugar;
                command.Parameters.Add("@valorTot", MySqlDbType.Double).Value = devolucao.ValorTot;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                if (AtualizarVeiculo(placa, "D"))
                {
                    fsucesso = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao inserir registro " + e, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
            return fsucesso;
        }
        public List<ListaVeiculos> ConsultaVeiculosAlocados()
        {
            List<ListaVeiculos> lista = new List<ListaVeiculos>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select veiculo.situacao, alugar.fkCarro_placa, veiculo.modelo, alugar.dataFim," +
                    " cliente.nome, alugar.fkCliente_doc, cliente.telefone from alugar join veiculo on alugar.fkCarro_placa = veiculo.placa" +
                    " join cliente on alugar.fkCliente_doc = cliente.doc;", conexao);
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
                    " join cliente on alugar.fkCliente_doc = cliente.doc where situacao = '" + situacao + "' ;", conexao);
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
                    " join cliente on alugar.fkCliente_doc = cliente.doc where situacao = 'I' and dataFim < ? ;", conexao);
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
        /*
        public List<int> TotVeiculos()
        {
            List<int> lista = new List<int>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select situacao ,count(*) from veiculo group by situacao;", conexao);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add((int)command.ExecuteScalar());
                        int teste = 1;
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
        //*/
        public List<Usuarios> ConsultaUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                Conectar();
                MySqlCommand command = new MySqlCommand("select * from usuario where usuario <> 'master';", conexao);
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
