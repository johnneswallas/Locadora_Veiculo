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
    public partial class frmRelatorioUsuario : Form
    {
        public frmRelatorioUsuario()
        {
            InitializeComponent();
        }

        BDUsuarios BDUsuarios = new BDUsuarios();

        private void frmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (!frmAcesssoRestrito.faltenticado)
                {
                    btnExcluir.Visible = false;
                }
                //pesquisar todos
                ltvUsuario.Items.Clear();
                List<Usuarios> lista = BDUsuarios.ConsultaUsuarios();
                foreach (var obj in lista)
                {
                    ListViewItem itens = new ListViewItem(new[] { obj.Documento, obj.Nome.ToUpper(), obj.Usuario,
                    obj.Cargo.ToUpper(),obj.DocGerente, obj.DocUsuarioLogado});
                    ltvUsuario.Items.Add(itens);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //se tiver 1 item selecionado 
                if (ltvUsuario.SelectedItems.Count == 1)
                {
                    //pego a possiçao que estar selecionado 
                    int possicao = ltvUsuario.SelectedIndices[0];

                    //pego o primeiro item da linha selecionada que no caso e o cpf
                    string primaryKey = ltvUsuario.Items[possicao].Text.ToString();

                    //pego o segundo item da linha selecionada que no caso e o nome 
                    string nomeUsuario = ltvUsuario.Items[possicao].SubItems[1].Text.ToString();

                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + nomeUsuario + " ?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes && BDUsuarios.ExcluirUsuario(primaryKey))
                    {
                        ltvUsuario.Items.RemoveAt(ltvUsuario.SelectedIndices[0]);
                        MessageBox.Show("Exclussao feita com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        }
    }
}
