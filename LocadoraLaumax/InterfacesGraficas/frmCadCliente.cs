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
        BDClientes bancoDados = new BDClientes();
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
            try
            {
                DateTime dataAgora = DateTime.Now;

                if (!new Atalho().CamposEmBranco(this))
                {
                    DateTime data = DateTime.Parse(mkbNascimento.Text.Trim());

                    if (data.Year > dataAgora.Year - 18)
                    {
                        MessageBox.Show("Não podemos cadastrar menores de 18 anos ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //copiado
                    string estadoCivil = grpBox.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;

                    Clientes cliente = new Clientes(Atalho.LimpaDoc(mkbDoc.Text), txtNome.Text.Trim(), mkbTel.Text.Trim(), data, estadoCivil, frmLogin.docLogado);

                    if (bancoDados.CadastrarCliente(cliente))
                    {
                        MessageBox.Show("Registro feito com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao passar informações para o banco de dados " + erro);
            }
        }
        private void btnAtualisar_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime dataAgora = DateTime.Now;

                if (!new Atalho().CamposEmBranco(this))
                {
                    DateTime dataNascimento = DateTime.Parse(mkbNascimento.Text.Trim());
                    if (dataNascimento.Year > dataAgora.Year - 18)
                    {
                        MessageBox.Show("Não podemos cadastrar menores de 18 anos ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //copiado
                    string estadoCivil = grpBox.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;

                    Clientes cliente = new Clientes(Atalho.LimpaDoc(mkbDoc.Text), txtNome.Text.Trim(), mkbTel.Text.Trim(), dataNascimento, estadoCivil, frmLogin.docLogado);

                    if (bancoDados.AtualizarCliente(cliente))
                    {
                        MessageBox.Show("Atualização feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao passar informações para o banco de dados " + erro);
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!new Atalho().CamposEmBranco(this))
                {
                    btnCadastrar_Click(btnCadastrar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    return;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    //copiado
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
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
