using System;
using System.Windows.Forms;
using BancoDados;
using Entidades;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmCadVeiculo : Form
    {
        Comandos bancoDado = new Comandos();
        public frmCadVeiculo()
        {
            InitializeComponent();
        }
        private void frmCadVeiculo_Load(object sender, EventArgs e)
        {
            int anoAtual = DateTime.Today.Year;
            for (int i = anoAtual; i >= anoAtual - 15; i--)
            {
                cmbAnoFabricacao.Items.Add(i.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool fsucesso = false;
            try
            {
                DateTime dataagora = DateTime.Now;
                if (cmbAnoFabricacao.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Data de fabricação incorreta", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string ano = cmbAnoFabricacao.Text.Trim() + "/01/01";
                DateTime data = DateTime.Parse(ano);
                if (data.Year > dataagora.Year)
                {
                    MessageBox.Show("Data de fabricação incorreta", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string km = Atalho.LimpaKm(mkbKm.Text);
                if (!txtPlaca.Text.Trim().Equals(string.Empty) && !txtFabricante.Text.Trim().Equals(string.Empty) && !txtModelo.Text.Trim().Equals(string.Empty)
                && !Atalho.LimpaPreco(txtDiaria.Text).ToString().Equals(string.Empty) && !mkbKm.Text.Trim().Equals(string.Empty))
                {
                    fsucesso = bancoDado.CadastrarVeiculo(new Veiculos(txtPlaca.Text.Trim().ToUpper(), txtFabricante.Text.Trim().ToUpper(), txtModelo.Text.Trim().ToUpper(), data,
                    float.Parse(Atalho.LimpaPreco(txtDiaria.Text).ToString()), int.Parse(km), 'D', frmLogin.docLogado));
                }
                else
                {
                    MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro a passar informações para o banco de dados " + erro, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
            }
            if (fsucesso)
            {
                MessageBox.Show("Registro feito com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            bool fsucesso = false;
            try
            {
                DateTime dataagora = DateTime.Now;
                if (cmbAnoFabricacao.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Data de fabricação incorreta", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string ano = cmbAnoFabricacao.Text.Trim() + "/01/01";
                DateTime data = DateTime.Parse(ano);
                if (data.Year > dataagora.Year)
                {
                    MessageBox.Show("Data de fabricação incorreta", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string km = Atalho.LimpaKm(mkbKm.Text);
                if (!txtPlaca.Text.Trim().Equals(string.Empty) && !txtFabricante.Text.Trim().Equals(string.Empty) && !txtModelo.Text.Trim().Equals(string.Empty)
                && !Atalho.LimpaPreco(txtDiaria.Text).ToString().Equals(string.Empty) && !mkbKm.Text.Trim().Equals(string.Empty))
                {
                    Veiculos veiculo = new Veiculos(txtPlaca.Text.Trim().ToUpper(), txtFabricante.Text.Trim().ToUpper(), txtModelo.Text.Trim().ToUpper(), data,
                    float.Parse(Atalho.LimpaPreco(txtDiaria.Text).ToString()), int.Parse(km), 'D', frmLogin.docLogado);
                    fsucesso = bancoDado.AtualizarVeiculo(veiculo);
                }
                else
                {
                    MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro a passar informções para o banco de dados " + erro, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (fsucesso)
            {
                MessageBox.Show("Atualização feita com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERRO na atualização ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtPlaca.Text.Trim().Equals(string.Empty) && !txtFabricante.Text.Trim().Equals(string.Empty) && !txtModelo.Text.Trim().Equals(string.Empty)
               && !Atalho.LimpaPreco(txtDiaria.Text).ToString().Equals(string.Empty) && !mkbKm.Text.Trim().Equals(string.Empty))
                {
                    btnCadastrar_Click(btnCadastrar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
					txtPlaca.Focus();
                }
                else
                {
                    //copiado
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        private void mkbKm_MouseClick(object sender, MouseEventArgs e)
        {
            if (mkbKm.Text.Length == 0)
            {
                mkbKm.SelectionStart = 0;
            }
        }
        private void Apenas_Numeros(object sender, KeyPressEventArgs e)
        {
            //IsDifgit se o caractere Unicode especificado é categorizado como um dígito decimal
            //copiado
            //aceita apenas números, tecla backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
