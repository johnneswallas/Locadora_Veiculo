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

        
    }
}
