using BancoDados;
using System;
using System.Windows.Forms;
using Entidades;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmLogin : Form
    {
        public static string usuarioLogado = string.Empty;
        public static string senhaLogado = string.Empty;
        public static string docLogado = string.Empty;
        public static bool flogado = false;
        BDUsuarios bdUsuario = new BDUsuarios();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //copiado
            string assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
            string productVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
            lblVersao.Text = string.Format("Assembly Version: {0} \nFile Version: {1} \nProduct Version: {2}", assemblyVersion, fileVersion, productVersion);
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuario.Text.Trim().Equals(string.Empty) && !txtSenha.Text.Trim().Equals(string.Empty))
                {
                    Usuarios usuario = new Usuarios(txtUsuario.Text.Trim(), txtSenha.Text.Trim());
                    docLogado = bdUsuario.RetornaDoc(usuario);
                    if (bdUsuario.Login(usuario) && !docLogado.Equals(string.Empty))
                    {
                        usuarioLogado = usuario.Usuario;
                        senhaLogado = usuario.Senha;
                        flogado = true;
                        Dispose();
                        return;
                    }
                    MessageBox.Show("Usuário ou senha incorreto", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!txtSenha.Text.Equals(string.Empty) && !txtUsuario.Equals(string.Empty))
                {
                    btnEntrar_Click(btnEntrar, new EventArgs());
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        txtSenha.Focus();
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
