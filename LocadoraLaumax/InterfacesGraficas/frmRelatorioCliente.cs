using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDados;
using Entidades;

namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }
        BDClientes BDCliente = new BDClientes();

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {

            
            try
            {
                if (!frmAcesssoRestrito.faltenticado)
                {
                    btnExcluir.Visible = false;
                }
                //pesquisar todos
                ltvCliente.Items.Clear();
                List<Clientes> lista = BDCliente.ListaCliente();
                foreach (var obj in lista)
                {
                    ListViewItem itens = new ListViewItem(new[] { obj.Documento, obj.Nome.ToUpper(), obj.Telefone,
                    obj.Nascimento.ToString(),obj.EstadoCivil.ToUpper()});
                    ltvCliente.Items.Add(itens);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //se tiver 1 item selecionado 
            if (ltvCliente.SelectedItems.Count == 1)
            {
                //pego a possiçao que estar selecionado 
                int possicao = ltvCliente.SelectedIndices[0];

                //pego o primeiro item da linha selecionada que no caso e o cpf
                string primaryKey = ltvCliente.Items[possicao].Text.ToString();

                //pego o segundo item da linha selecionada que no caso e o nome 
                string nomeUsuario = ltvCliente.Items[possicao].SubItems[1].Text.ToString();

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + nomeUsuario + " ?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes && BDCliente.ExcluirCliente(primaryKey))
                {
                    ltvCliente.Items.RemoveAt(ltvCliente.SelectedIndices[0]);
                    MessageBox.Show("Exclussao feita com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
