using BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmServidor : Form
    {
        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\locadora LauMax\log.csv";
            if (new Atalho().CamposEmBranco(this))
            {
                MessageBox.Show("campo em branco!", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string ip = txtIp.Text.Trim();
            string dataBase = txtDataBase.Text.Trim();
            string uid = txtUsuario.Text.Trim();
            string pwd = txtSenha.Text.Trim();

            string stringConexao = $"Server = {ip}; Database = {dataBase}; Uid = {uid}; Pwd = {pwd};";

            if (new BDComandos().TesteConexao(stringConexao))
            {
                BDComandos.stringConexao = stringConexao;
                FileInfo arquivo = new FileInfo(path);
                arquivo.CreateText().Close();
                arquivo.Attributes = FileAttributes.Hidden;
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{ip},{dataBase},{uid},{pwd}");
                    MessageBox.Show("Conectado com servidor com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                    return;
                }
            }
            MessageBox.Show("Erro ao conectar com servidor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        private void Teclas_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!new Atalho().CamposEmBranco(this))
                    {
                        btnEntrar_Click(btnEntrar, new EventArgs());
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        return;
                    }
                    //copiado
                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }

            }
        }
    }
}
