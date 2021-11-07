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
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmAcesssoRestrito : Form
    {
        Comandos BancoDados = new Comandos();
        public static bool faltenticado = false;
        public static string docGerente = string.Empty;
        public frmAcesssoRestrito()
        {
            InitializeComponent();
        }
        private void frmAcesssoRestrito_Load(object sender, EventArgs e)
        {
            faltenticado = false;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenha.Text.Trim().Equals(string.Empty))
            {
                faltenticado = BancoDados.Autenticar(txtUsuario.Text.Trim(), txtSenha.Text.Trim());
                if (faltenticado)
                {
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Dados incorretos ", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txtSenha.Text.Equals(string.Empty) && !txtUsuario.Equals(string.Empty))
                {
                    btnEntrar_Click(btnEntrar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        txtSenha.Focus();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
    }
}
