using System;
using System.Windows.Forms;
using BancoDados;
using Entidades;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmAlteraSenha : Form
    {

        public frmAlteraSenha()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenhaAtual.Text.Trim().Equals(string.Empty)
                    && !txtDoc.Text.Trim().Equals(string.Empty) && !txtSenhaNova.Text.Trim().Equals(string.Empty))
                {
                    if (new BDUsuarios().AlterarSenha((new Usuarios(txtDoc.Text.Trim(), txtUsuario.Text.Trim(), txtSenhaAtual.Text.Trim(), frmLogin.docLogado)), txtSenhaNova.Text.Trim()))
                    {
                        MessageBox.Show("Senha alterada com sucesso! ", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLogin.senhaLogado = txtSenhaNova.Text.Trim();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incoreto", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Dados incompletos", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                if (!txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenhaAtual.Text.Trim().Equals(string.Empty)
                    && !txtDoc.Text.Trim().Equals(string.Empty) && !txtSenhaNova.Text.Trim().Equals(string.Empty))
                {
                    btnAtualizar_Click(btnAtualizar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    //copiado
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
