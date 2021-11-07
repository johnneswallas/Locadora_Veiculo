using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BancoDados;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }
        Comandos bancoDados = new Comandos();
        private void btnPesquisarPlaca_Click(object sender, EventArgs e)
        {
            //pesquisa pela placa
            List<Veiculos> lista = bancoDados.ConsultarPlacaVeiculo(txtPlaca.Text.Trim());
            try
            {
                if (lista.Count != 0)
                {
                    foreach (var obj in lista)
                    {
                        lblFabricante.Text = obj.Fabricante.Trim().ToUpper().ToString();
                        if (obj.Modelo.Contains(" "))
                        {
                            //corto a string apartir do 0 ate encontra o primeiro espaço
                            lblModelo.Text = obj.Modelo.ToUpper().ToString().Substring(0, obj.Modelo.IndexOf(" "));
                        }
                        else
                        {
                            lblModelo.Text = obj.Modelo.ToUpper().ToString();
                        }
                        lblDiaria.Text = obj.ValorDiaria.ToString("c");
                        lblAnoFabricacao.Text = obj.Ano.Year.ToString();
                        if (obj.Situacao == 'D' || obj.Situacao == 'd')
                        {
                            lblSituacao.Text = "DISPONÍVEL";
                        }
                        else
                        {
                            lblSituacao.Text = "INDISPONÍVEL";
                        }
                        txtPlacaAluguel.Text = txtPlaca.Text;
                        mskDiariaAluguel.Text = obj.ValorDiaria.ToString("c");
                    }
                }
                else
                {
                    MessageBox.Show("Placa não encontrada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            //pesquisar pelo campo
            if (!txtPesquisarCliente.Text.Trim().Equals(string.Empty))
            {
                List<Clientes> lista = bancoDados.ConsultarCampoClientes(txtPesquisarCliente.Text.Trim(), 0);
                if (lista.Count != 0)
                {
                    try
                    {
                        txtNome.Clear();
                        mkbDoc.Clear();
                        mkbNascimento.Clear();
                        mkbTel.Clear();
                        foreach (var obj in lista)
                        {
                            txtPesquisarCliente.Clear();
                            txtNome.Text = obj.Nome;
                            mkbDoc.Text = obj.Documento;
                            mkbNascimento.Text = obj.Nascimento.ToString();
                            mkbTel.Text = obj.Telefone;
                            mskDocAluguel.Text = mkbDoc.Text;
                            switch (obj.EstadoCivil)
                            {
                                case "Casado":
                                    rdbCasado.Checked = true;
                                    break;
                                case "Solteiro":
                                    rdbSolteiro.Checked = true;
                                    break;
                                case "Divorciado":
                                    rdbDivorciado.Checked = true;
                                    break;
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro inesperado " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campo(s) em Branco ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //cadastrar cliente
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
                mskDocAluguel.Text = mkbDoc.Text;
            }
        }
        private void btnAtualisarCliente_Click(object sender, EventArgs e)
        {
            //atualizar cliente
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
                MessageBox.Show("Erro ao passar dados para o banco de dados " + erro);
            }
            if (fsucesso)
            {
                MessageBox.Show("Atualização feita com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDocAluguel.Text = mkbDoc.Text;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //calcular
            bool fsucesso = false;
            try
            {
                DateTime dataagora = DateTime.Now;
                string dataRet = Atalho.LimpaData(mskRetirada.Text);
                string dataDev = Atalho.LimpaData(mskDevolucao.Text);
                if (!dataRet.Equals(string.Empty) && !dataDev.Equals(string.Empty))
                {
                    DateTime dataRetirada = DateTime.Parse(mskRetirada.Text.Trim());
                    DateTime dataDevolucao = DateTime.Parse(mskDevolucao.Text.Trim());
                    //como e so pra calcular posso deixa a data de retirada maior q a data now
                    if (dataRetirada > dataDevolucao)
                    {   
                        MessageBox.Show("Data de DEVOLUÇÂO menor que data de ENTREGA ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string doc = Atalho.LimpaDoc(mskDocAluguel.Text);
                        string diaria = Atalho.LimpaPreco(mskDiariaAluguel.Text).ToString();
                        if (mskDiariaAluguel.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("Campo preenchido inadequadamente ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!doc.Equals(string.Empty))
                        {
                            if (!mskDiariaAluguel.Text.Equals(string.Empty) && !(Atalho.LimpaPreco(mskDiariaAluguel.Text).ToString() == ""))
                            {
                                TimeSpan dias = dataDevolucao - dataRetirada;
                                int totDias = dias.Days + 1;
                                lblResumo.Visible = true;
                                lblTotDiaTitulo.Visible = true;
                                lblTotalDia.Visible = true;
                                lblTotalTitulo.Visible = true;
                                lblTotal.Visible = true;
                                btnFinalizar.Visible = true;
                                lblTotalDia.Text = totDias.ToString();
                                lblTotal.Text = (totDias * Atalho.LimpaPreco(mskDiariaAluguel.Text)).ToString("c");
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
                mskDocAluguel.Text = mkbDoc.Text;
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataagora = DateTime.Now;
                string dataRet = Atalho.LimpaData(mskRetirada.Text);
                string dataDev = Atalho.LimpaData(mskDevolucao.Text);
                if (!dataRet.Equals(string.Empty) && !dataDev.Equals(string.Empty))
                {
                    DateTime dataRetirada = DateTime.Parse(mskRetirada.Text.Trim());
                    DateTime dataDevolucao = DateTime.Parse(mskDevolucao.Text.Trim());
                    if (dataRetirada < dataagora.Date || dataRetirada > dataDevolucao)
                    {   
                        MessageBox.Show("Datas incompatíveis ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        string doc = Atalho.LimpaDoc(mskDocAluguel.Text);
                        string diaria = Atalho.LimpaPreco(mskDiariaAluguel.Text).ToString();
                        if (!doc.Equals(string.Empty))
                        {
                            if (!mskDiariaAluguel.Text.Equals(string.Empty) || !(diaria.Length == 0))
                            {
                                /*Random rnd = new Random();
                                rnd.Next(100, 99999);*/
                                string codAlugar = Atalho.LimpaDataHora(dataagora);
                                if (bancoDados.RetiradaVeiculo(new Alugar(codAlugar, dataRetirada, dataDevolucao, Convert.ToDouble(diaria), doc, txtPlacaAluguel.Text, frmLogin.docLogado)))
                                {
                                    MessageBox.Show("Registro feito com sucesso ", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    mskDevolucao.Clear();
                                    btnImprimir.Visible = true;
                                }
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
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //copiado
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void Teclas_PesquisarPlaca(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //copiado
                btnPesquisarPlaca_Click(btnPesquisarPlaca, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void Teclas_PesquisarCliente(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                btnPesquisarCliente_Click(btnPesquisarCliente, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
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
            if (mkbDoc.Text.Length == 0 || mkbTel.Text.Length == 0 || mkbNascimento.Text.Length == 0)
            {
                mkbDoc.SelectionStart = 0;
                mkbTel.SelectionStart = 0;
                mkbNascimento.SelectionStart = 0;
                mskRetirada.SelectionStart = 0;
                mskDevolucao.SelectionStart = 0;
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
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //estudar impressao de doc
        }
    }
}
