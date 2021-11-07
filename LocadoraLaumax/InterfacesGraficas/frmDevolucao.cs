using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BancoDados;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }
        Comandos BancoDados = new Comandos();
        string foreingKey_Alugar;
        string placa;
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            //pesquisa pela placa e doc 
            try
            {
                if ((!txtPesquisarCliente.Text.Trim().Equals(string.Empty) && !txtPlaca.Text.Trim().Equals(string.Empty)))
                {
                    List<PesquisaDevolucao> lista = BancoDados.PesquisaDevolucao(txtPesquisarCliente.Text.Trim(), txtPlaca.Text.Trim());
                    if (lista.Count != 0)
                    {
                        foreach (var obj in lista)
                        {
                            lblPlaca.Text = obj.ForeingKey_Carro.Trim();
                            lblDiaria.Text = obj.ValorDiaria.ToString("c");
                            mskDocAluguel.Text = obj.ForeingKey_Cliente.ToUpper().Trim();
                            mskRetirada.Text = obj.DataInicio.ToString();
                            mskDevolucao.Text = obj.DataInicio.ToString();
                            lblNome.Text = obj.NomeCliente.ToUpper().Trim();
                            mskDevolucao.Text = obj.DataFim.ToString();
                            foreingKey_Alugar = obj.ForeingKey_Alugar;
                            placa = obj.ForeingKey_Carro.Trim();
                            btnCalcular.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente ou veículo incompativeis ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Campos vazios", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string data = Atalho.LimpaData(mskDevolucao.Text);
            btnPesquisarCliente_Click(btnPesquisarCliente, new EventArgs());
            mskDevolucao.Text = data;
            lblDias.Text = string.Empty;
            btnImprimir.Visible = false;
            btnFinalizar.Visible = false;
            btnImprimir.Visible = false;
            DateTime dataNow = DateTime.Now;
            if (txtPlaca.Text.Equals(string.Empty) || txtPesquisarCliente.Text.Equals(string.Empty)
                || Atalho.LimpaData(mskDevolucao.Text).Equals(string.Empty) || Atalho.LimpaKm(mskKm.Text).Equals(string.Empty))
            {
                MessageBox.Show("Preencha todos os campos!", "Campo(s) em Branco(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                return;
            }
            DialogResult result = MessageBox.Show("Data de devolução está correta ? ", "CONFIRMAÇÂO DE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (Atalho.LimpaData(mskDevolucao.Text).Length < 8 ||
                    Convert.ToDateTime(mskDevolucao.Text) < Convert.ToDateTime(mskRetirada.Text))
                {
                    throw new Exception();
                }
                TimeSpan quatDia = Convert.ToDateTime(mskDevolucao.Text) - Convert.ToDateTime(mskRetirada.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Data Incoreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                TimeSpan quatDia = Convert.ToDateTime(mskDevolucao.Text) - Convert.ToDateTime(mskRetirada.Text);
                if (result == DialogResult.No)
                {
                    mskDevolucao.Focus();
                    return;
                }
                //copiado 
                string condicao = gpbCondicao.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
                if (ckbJuros.Checked)
                {
                    if (Convert.ToDateTime(mskDevolucao.Text) < dataNow.Date)
                    {   // se a data de devolução for menor q a data de hoje 
                        // quando o cliente entrega depois da data combinada 
                        // cobrar juros por dia 
                        TimeSpan totDia = dataNow.Date - Convert.ToDateTime(mskRetirada.Text);
                        lblDias.Text = Convert.ToInt32(totDia.TotalDays + 1).ToString();
                        lblTotal.Text = (Convert.ToInt32(totDia.TotalDays + quatDia.TotalDays + 1) * Atalho.LimpaPreco(lblDiaria.Text)).ToString("C");

                    }
                }
                else
                {
                    if (quatDia.TotalDays != 0)
                    {
                        lblTotal.Text = (Convert.ToInt32(quatDia.TotalDays + 1) * Atalho.LimpaPreco(lblDiaria.Text)).ToString("C");
                        lblDias.Text = Convert.ToInt32(quatDia.TotalDays + 1).ToString();
                    }
                    else if (quatDia.TotalDays == 0)
                    {
                        lblTotal.Text = (Convert.ToInt32(quatDia.TotalDays + 1) * Atalho.LimpaPreco(lblDiaria.Text)).ToString("C");
                        lblDias.Text = Convert.ToInt32(quatDia.TotalDays + 1).ToString();
                    }
                }
                switch (condicao)
                {
                    case "Sem Avaria":
                        break;
                    case "Leve Avaria":
                        //10% de multa 
                        lblTotal.Text = (Atalho.Porcento(Atalho.LimpaPreco(lblTotal.Text), 10)).ToString("C");
                        break;
                    case "Media Avaria":
                        //15% de multa 
                        lblTotal.Text = (Atalho.Porcento(Atalho.LimpaPreco(lblTotal.Text), 15)).ToString("C");
                        break;
                    case "Grande Avaria":
                        //20% de multa 
                        lblTotal.Text = (Atalho.Porcento(Atalho.LimpaPreco(lblTotal.Text), 20)).ToString("C");
                        break;
                    case "Muito Avariado":
                        //25% de multa 
                        lblTotal.Text = (Atalho.Porcento(Atalho.LimpaPreco(lblTotal.Text), 25)).ToString("C");
                        break;
                    default:
                        MessageBox.Show("Seleciona qual a situação do veículo! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                if (!lblDias.Text.Equals(string.Empty))
                {
                    btnFinalizar.Visible = true;
                    pnlValores.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            btnCalcular_Click(btnCalcular, new EventArgs());
            DateTime dataAgora = DateTime.Now;
            string codDevolucao = Atalho.LimpaDataHora(dataAgora.ToString());
            if (BancoDados.Devolucao(new Devolucao(codDevolucao, frmLogin.docLogado, foreingKey_Alugar,
                Atalho.LimpaPreco(lblTotal.Text)), placa))
            {
                txtPlaca.Clear();
                txtPesquisarCliente.Clear();
                lblPlaca.Text = string.Empty;
                lblDiaria.Text = string.Empty;
                mskDocAluguel.Clear();
                mskRetirada.Clear();
                mskDevolucao.Clear();
                lblNome.Text = string.Empty;
                lblDias.Text = string.Empty;
                mskKm.Clear();
                lblTotal.Text = string.Empty;
                pnlValores.Visible = false;
                btnImprimir.Visible = true;
                MessageBox.Show("Devolução feita com sucesso, volte sempre!", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //estudar impressao de doc
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
        private void Teclas_PesquisarCliente(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarCliente_Click(btnPesquisarCliente, new EventArgs());
                e.Handled = true;
            }
        }
        private void Teclar_Calcular(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular_Click(btnCalcular, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void Start0_MouseClick(object sender, MouseEventArgs e)
        {
            if (mskKm.Text.Length == 0 || mskDevolucao.Text.Length == 0)
            {
                mskKm.SelectionStart = 0;
                mskDevolucao.SelectionStart = 0;
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //copiado
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
            }
        }
    }
}
