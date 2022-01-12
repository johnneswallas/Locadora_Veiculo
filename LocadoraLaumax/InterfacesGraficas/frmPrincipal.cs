using BancoDados;
using MySql.Data.MySqlClient;
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
using System.IO;

namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmPrincipal : Form
    {
        public static bool facesso = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                //copiado
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.Black;
                    break;
                }
            }
            mnsPrincipal.Visible = false;
            frmLogin frmLogin = new frmLogin();
            //frmLogin.MdiParent = this;
            frmLogin.ShowDialog();
            if (frmLogin.flogado)
            {
                mnsPrincipal.Visible = true;
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //troca de usuario
            frmLogin frmLogin = new frmLogin();
            frmAlterarUsuario frmFilho = new frmAlterarUsuario();
            frmPrincipal.facesso = false;
            frmFilho.ShowDialog();
            if (facesso)
            {
                mnsPrincipal.Visible = false;
                frmLogin.flogado = false;
                frmLogin.ShowDialog();
                if (frmLogin.flogado)
                {
                    mnsPrincipal.Visible = true;
                }
            }
            else
            {
                frmPrincipal.facesso = true;
                //Dispose();
            }
        }
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //alterar senha
            frmAlteraSenha frmAlteraSenha = new frmAlteraSenha();
            frmAlteraSenha.ShowDialog();
        }
        private void usuarioMenu_Click(object sender, EventArgs e)
        {
            // cadastrar usuario
            frmAcesssoRestrito frmAcesssoRestrito = new frmAcesssoRestrito();
            frmAcesssoRestrito.ShowDialog();
            if (frmAcesssoRestrito.faltenticado)
            {
                frmCadUsuario frmCadUsuario = new frmCadUsuario();
                frmCadUsuario.ShowDialog();
            }
        }
        private void veiculoMenu_Click(object sender, EventArgs e)
        {
            // cadastrar veiculo
            frmCadVeiculo frmCadVeiculo = new frmCadVeiculo();
            frmCadVeiculo.ShowDialog();
        }
        private void clienteMenu_Click(object sender, EventArgs e)
        {
            // cadastrar cliente
            frmCadCliente frmCadCliente = new frmCadCliente();
            frmCadCliente.StartPosition = FormStartPosition.CenterScreen;
            frmCadCliente.ShowDialog();
        }
        private void retiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // retirar de veiculo
            frmLocacao frmLocacao = new frmLocacao();
            frmLocacao.MdiParent = this;
            frmLocacao.Show();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // entrega de veiculo
            frmDevolucao frmDevolucao = new frmDevolucao();
            frmDevolucao.MdiParent = this;
            frmDevolucao.Show();
        }

        private void veiculosAlocadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRelatorioVeiculoAlocados frmVeiculoAlocados = new frmRelatorioVeiculoAlocados();
            frmVeiculoAlocados.MdiParent = this;
            frmVeiculoAlocados.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcesssoRestrito frmAcesssoRestrito = new frmAcesssoRestrito();
            frmAcesssoRestrito.ShowDialog();

            frmRelatorioUsuario frmRelatorioUsuario = new frmRelatorioUsuario();
            frmRelatorioUsuario.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcesssoRestrito frmAcesssoRestrito = new frmAcesssoRestrito();
            frmAcesssoRestrito.ShowDialog();

            frmRelatorioCliente frmRelatorioCliente = new frmRelatorioCliente();
            frmRelatorioCliente.ShowDialog();

        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcesssoRestrito frmAcesssoRestrito = new frmAcesssoRestrito();
            frmAcesssoRestrito.ShowDialog();

            frmRelatorioVeiculos frmRelatorioVeiculos = new frmRelatorioVeiculos();
            frmRelatorioVeiculos.ShowDialog();

        }
    }
}