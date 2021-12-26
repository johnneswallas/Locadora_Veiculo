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
    public partial class frmAcesssoRestrito : Form
    {
        BDUsuarios bDUsuarios = new BDUsuarios();
        public static string docGerente = string.Empty;

        public static bool faltenticado = false;
        public frmAcesssoRestrito()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            faltenticado = false;
            Dispose();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!new Atalho().CamposEmBranco(this))
            {
                Usuarios usuario = new Usuarios(txtUsuario.Text.Trim(), txtSenha.Text.Trim());
                docGerente = bDUsuarios.RetornaDoc(usuario);
                if (bDUsuarios.Autenticar(usuario) && !docGerente.Equals(string.Empty))
                {
                    faltenticado = true;
                    Dispose();
                    return;
                }
                MessageBox.Show("Erro ao tentar altenticar ", null, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!new Atalho().CamposEmBranco(this))
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
