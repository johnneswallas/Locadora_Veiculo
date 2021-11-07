using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BancoDados;
using Entidades;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmCadCliente : Form
    {
        Comandos bancoDados = new Comandos();
        public frmCadCliente()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool fsucesso = false;
            try
            {
                DateTime dataagora = DateTime.Now;
                string dataTeste = Atalho.LimpaData(mkbNascimento.Text);
                if (!dataTeste.Equals(string.Empty))
                {
                    DateTime data = DateTime.Parse(mkbNascimento.Text.Trim());
                    if (data.Year > dataagora.Year - 18)
                    {
                        MessageBox.Show("Data de Nascimento incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string doc = Atalho.LimpaDoc(mkbDoc.Text);
                        if (!doc.Equals(string.Empty))
                        {
                            //copiado
                            string estadoCivil = grpBox.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                            if (!doc.Equals(string.Empty) && !mkbNascimento.Text.Equals(string.Empty) && !txtNome.Text.Trim().Equals(string.Empty)
                                && !mkbTel.Text.Trim().Equals(string.Empty))
                            {
                                Clientes cliente = new Clientes(doc, txtNome.Text.Trim(), mkbTel.Text.Trim(), data, estadoCivil, frmLogin.docLogado);
                                fsucesso = bancoDados.CadastrarCliente(cliente);
                            }
                            else
                            {
                                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("CPF incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao passar informações para o banco de dados " + erro);
            }
            if (fsucesso)
            {
                MessageBox.Show("Registro feito com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAtualisar_Click(object sender, EventArgs e)
        {
            bool fsucesso = false;
            try
            {
                DateTime dataagora = DateTime.Now;
                string dataTeste =Atalho.LimpaData(mkbNascimento.Text);
                if (!dataTeste.Equals(string.Empty))
                {
                    DateTime data = DateTime.Parse(mkbNascimento.Text.Trim());
                    if (data.Year > dataagora.Year - 18)
                    {
                        MessageBox.Show("Data de Nascimento incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string doc = Atalho.LimpaDoc(mkbDoc.Text);
                        if (!doc.Equals(string.Empty))
                        {
                            //copiado
                            string estadoCivil = grpBox.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                            if (!doc.Equals(string.Empty) && !mkbNascimento.Text.Equals(string.Empty) && !txtNome.Text.Trim().Equals(string.Empty)
                                && !mkbTel.Text.Trim().Equals(string.Empty))
                            {
                                Clientes cliente = new Clientes(doc, txtNome.Text.Trim(), mkbTel.Text.Trim(), data, estadoCivil, frmLogin.docLogado);
                                fsucesso = bancoDados.AtualizarCliente(cliente);
                            }
                            else
                            {
                                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("CPF incorreto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao passar informações para o banco de dados " + erro);
            }
            if (fsucesso)
            {
                MessageBox.Show("Atualização feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!mkbDoc.Equals(string.Empty) && !mkbNascimento.Text.Equals(string.Empty) && !txtNome.Text.Trim().Equals(string.Empty)
                    && !mkbTel.Equals(string.Empty))
                {
                    btnCadastrar_Click(btnCadastrar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    txtNome.Focus();
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        //copiado
                        this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
        private void Start0_MouseClick(object sender, MouseEventArgs e)
        {
            if (mkbDoc.Text.Length == 0 || mkbTel.Text.Length == 0 || mkbNascimento.Text.Length == 0)
            {
                mkbDoc.SelectionStart = 0;
                mkbTel.SelectionStart = 0;
                mkbNascimento.SelectionStart = 0;
            }
        }
        private void Apenas_Numeros(object sender, KeyPressEventArgs e)
        {
            //IsDifgit se o caractere Unicode especificado é categorizado como um dígito decimal
            //copiado
            //aceita apenas números, tecla backspace.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
