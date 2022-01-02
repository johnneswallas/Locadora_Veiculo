using System;
using System.Windows.Forms;
using BancoDados;
using Entidades;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmCadVeiculo : Form
    {
        BDVeiculos bancoDado = new BDVeiculos();
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
            try
            {
                DateTime dataAgora = DateTime.Now;
                if (!new Atalho().CamposEmBranco(this))
                {
                    DateTime dataFabricacao = DateTime.Parse(cmbAnoFabricacao.Text.Trim() + "/01/01");
                    if (dataFabricacao.Year > dataAgora.Year)
                    {
                        MessageBox.Show("Data de fabricação incorreta", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string km = Atalho.LimpaKm(mkbKm.Text);

                    Veiculos veiculo = new Veiculos(txtPlaca.Text.Trim().ToUpper(), txtFabricante.Text.Trim().ToUpper(),
                        txtModelo.Text.Trim().ToUpper(), dataFabricacao, float.Parse(Atalho.LimpaPreco(txtDiaria.Text).ToString()),
                        int.Parse(km), 'D', frmLogin.docLogado);

                    if (bancoDado.CadastrarVeiculo(veiculo))
                    {
                        MessageBox.Show("Registro feito com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("ERRO ao cadastrar veículo ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro a passar informações para o banco de dados " + erro, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataAgora = DateTime.Now;
                if (!new Atalho().CamposEmBranco(this))
                {
                    DateTime dataFabricacao = DateTime.Parse(cmbAnoFabricacao.Text.Trim() + "/01/01");
                    if (dataFabricacao.Year > dataAgora.Year)
                    {
                        MessageBox.Show("Data de fabricação incorreta", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string km = Atalho.LimpaKm(mkbKm.Text);

                    Veiculos veiculo = new Veiculos(txtPlaca.Text.Trim().ToUpper(), txtFabricante.Text.Trim().ToUpper(),
                        txtModelo.Text.Trim().ToUpper(), dataFabricacao, float.Parse(Atalho.LimpaPreco(txtDiaria.Text).ToString()),
                        int.Parse(km), 'D', frmLogin.docLogado);

                    if (bancoDado.CadastrarVeiculo(veiculo))
                    {
                        MessageBox.Show("Registro feito com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    MessageBox.Show("ERRO ao atualizar veículo ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro a passar informções para o banco de dados " + erro, "erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtPlaca.Focus();
                    return;
                }
                //copiado
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
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
