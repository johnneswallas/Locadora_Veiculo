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

        private void frmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            ltvUsuario.Items.Clear();
            try
            {
                //pesquisar todos
                List<Usuarios> lista = new BDUsuarios().ConsultaUsuarios();
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
    }
}
