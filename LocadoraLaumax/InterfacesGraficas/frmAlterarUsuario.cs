using Entidades;
using System;
using System.Windows.Forms;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmAlterarUsuario : Form
    {
        public frmAlterarUsuario()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!new Atalho().CamposEmBranco(this))
                {
                    if (frmLogin.senhaLogado == txtSenha.Text.Trim() && frmLogin.usuarioLogado == txtUsuario.Text.Trim())
                    {
                        MessageBox.Show("Usuário alterada com sucesso! ", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPrincipal.facesso = true;
                        Dispose();
                        return;
                    }
                    MessageBox.Show("Usuário ou senha incoreto", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro inesperado" + erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
