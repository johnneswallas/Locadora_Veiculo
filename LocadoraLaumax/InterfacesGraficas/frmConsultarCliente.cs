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
    public partial class frmConsultarCliente : Form
    {
        BDClientes bancoDado = new BDClientes();
        public frmConsultarCliente()
        {
            InitializeComponent();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //pesquisar pelo campo
                ltvCliente.Items.Clear();
                List<Clientes> lista = bancoDado.ConsultarCampoClientes(txtPesquisar.Text);
                ltvCliente.Items.Clear();
                foreach (var obj in lista)
                {
                    ListViewItem itens = new ListViewItem(new[] { obj.Nome.ToUpper(), obj.Telefone.ToUpper() });
                    ltvCliente.Items.Add(itens);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro inesperado " + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtPesquisar.Text.Equals(string.Empty))
                {
                    btnPesquisar_Click(btnPesquisar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
					txtPesquisar.Focus();
                }
                else
                {
                    txtPesquisar.Focus();
                }
            }
        }
    }
}
