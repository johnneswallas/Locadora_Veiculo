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
        BDUsuarios bDUsuarios= new BDUsuarios();
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
            
            if (!txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenha.Text.Trim().Equals(string.Empty))
            {
                Usuarios usuario = new Usuarios(txtUsuario.Text.Trim(), txtSenha.Text.Trim());
                docGerente = bDUsuarios.RetornaDoc(usuario);
                if (bDUsuarios.Autenticar(usuario) && !docGerente.Equals(string.Empty))
                {
                    faltenticado = true;
                    Dispose();
                    return;
                }
            }
            MessageBox.Show("Erro ao tentar altenticar ", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
