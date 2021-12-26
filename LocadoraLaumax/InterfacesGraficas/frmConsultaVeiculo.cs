using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using BancoDados;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmConsultaVeiculo : Form
    {
        BDVeiculos bancoDado = new BDVeiculos();
        public frmConsultaVeiculo()
        {
            InitializeComponent();
        }
        internal void btnPesquisarPlaca_Click(object sender, EventArgs e)
        {
            //pesquisar por placa
            List<Veiculos> lista = bancoDado.DadosPorPlaca(txtPlaca.Text.Trim());
            try
            {
                if (lista.Count != 0)
                {
                    foreach (var obj in lista)
                    {
                        lblFabricante.Text = obj.Fabricante.Trim().ToUpper().ToString();
                        lblModelo.Text = obj.Modelo.ToUpper().ToString();
                        if (obj.Modelo.Contains(" "))
                        {
                            //corto a string apartir do 0 ate encontra o primeiro espaço
                            lblModelo.Text = obj.Modelo.ToUpper().ToString().Substring(0, obj.Modelo.IndexOf(" "));
                        }
                        lblDiaria.Text = obj.ValorDiaria.ToString("c");
                        lblAnoFabricacao.Text = obj.Ano.Year.ToString();
                        lblSituacao.Text = "INDISPONÍVEL";
                        if (obj.Situacao == 'D' || obj.Situacao == 'd')
                        {
                            lblSituacao.Text = "DISPONÍVEL";
                        }
                    }
                    return;
                }
                MessageBox.Show("Placa não encontrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO" + erro);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //pesquisar pelo campo
            List<Veiculos> lista = bancoDado.DadosPorCampoPesquisar(txtPesquisar.Text);
            try
            {
                ltvVeiculo.Items.Clear();
                if (lista.Count != 0)
                {
                    foreach (var obj in lista)
                    {
                        string situacao = "INDISPONÍVEL";
                        if (obj.Situacao.ToString().ToUpper() == "D")
                        {
                            situacao = "DISPONÍVEL";
                        }
                        ListViewItem itens = new ListViewItem(new[] { obj.Placa.ToUpper(), obj.Fabricante.ToUpper(), obj.Modelo.ToUpper(),
                            obj.Ano.Year.ToString().ToUpper(), obj.ValorDiaria.ToString("c").ToUpper(), situacao });
                        ltvVeiculo.Items.Add(itens);
                    }
                    return;
                }
                MessageBox.Show("Dados não encontrados ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }
        }
        private void Placa_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisarPlaca_Click(btnPesquisarPlaca, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtPlaca.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //copiado
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtPlaca.Focus();
            }
        }
        private void Pesquisar_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar_Click(btnPesquisar, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtPesquisar.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //copiado
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtPesquisar.Focus();
            }
        }
    }
}
