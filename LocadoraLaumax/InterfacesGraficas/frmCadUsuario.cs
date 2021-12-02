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
using System.Text.RegularExpressions;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmCadUsuario : Form
    {
        BDUsuarios BDUsuarios = new BDUsuarios();
        public frmCadUsuario()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cargo = rdbVendedor.Text.Trim();
                if (rdbGerente.Checked)
                {
                    cargo = rdbGerente.Text.Trim();
                }
                string doc = Atalho.LimpaDoc(mkbDoc.Text);
                if (!doc.Equals(string.Empty) && !txtNome.Text.Trim().Equals(string.Empty) && !txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenha.Text.Trim().Equals(string.Empty))
                {
                    if (cargo == "Gerente")
                    {
                        frmAcesssoRestrito frmAcesssoRestrito = new frmAcesssoRestrito();
                        frmAcesssoRestrito.ShowDialog();
                        if (frmAcesssoRestrito.faltenticado &&
                            BDUsuarios.CadastrarUsuario(new Usuarios(doc, txtNome.Text.Trim(), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), cargo, frmAcesssoRestrito.docGerente, frmLogin.docLogado)))
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                            return;
                        }
                    }
                    if (BDUsuarios.CadastrarUsuario(new Usuarios(doc, txtNome.Text.Trim(), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), cargo, frmAcesssoRestrito.docGerente, frmLogin.docLogado)))
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Dados incompletos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro a inserir Usuário! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAtualisar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAcesssoRestrito frmAcesssoRestrito = new frmAcesssoRestrito();
                frmAcesssoRestrito.ShowDialog();
                if (frmAcesssoRestrito.faltenticado)
                {
                    string doc = Atalho.LimpaDoc(mkbDoc.Text);
                    string cargo = rdbVendedor.Text.Trim();
                    if (rdbGerente.Checked)
                    {
                        cargo = rdbGerente.Text.Trim();
                    }
                    if (!doc.Equals(string.Empty) && !txtNome.Text.Trim().Equals(string.Empty) && !txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenha.Text.Trim().Equals(string.Empty))
                    {
                        if (BDUsuarios.AtualizarUsuario(new Usuarios(doc, txtNome.Text.Trim(), txtUsuario.Text.Trim(), txtSenha.Text.Trim(), cargo, frmAcesssoRestrito.docGerente, frmLogin.docLogado)))
                        {
                            MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dispose();
                            return;
                        }
                        MessageBox.Show("Erro a atualizar usuário! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Dados incompletos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro não indentificado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!mkbDoc.Equals(string.Empty) && !txtNome.Text.Trim().Equals(string.Empty) && !txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenha.Text.Trim().Equals(string.Empty))
                {
                    btnCadastrar_Click(btnCadastrar, new EventArgs());
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    txtNome.Focus();
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
        private void Start0_MouseClick(object sender, MouseEventArgs e)
        {
            if (mkbDoc.Text.Length == 0)
            {
                mkbDoc.SelectionStart = 0;
            }
        }
        private void Apenas_Numeros(object sender, KeyPressEventArgs e)
        {
            //IsDifgit se o caractere Unicode especificado é categorizado como um dígito decimal
            //copiado
            //aceita apenas números, tecla backspace.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
