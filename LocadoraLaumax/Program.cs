using BancoDados;
using LocadoraLaumax.InterfacesGraficas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LocadoraLaumax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                string path = @"C:\Program Files\locadora LauMax\log.csv";
                if (File.Exists(path))
                {
                    //se existir o arquivo eu leio e crio a strin de conexao
                    StreamReader sr = new StreamReader(path);
                    List<string> dado = new List<string>();
                    while (!(sr.EndOfStream))
                    {
                        string[] temp = sr.ReadLine().Split(',');
                        if (temp != null)
                        {
                            string ip = temp[0];
                            string dataBase = temp[1];
                            string uid = temp[2];
                            string pwd = temp[3];
                            BDComandos.stringConexao = $"Server = {ip}; Database = {dataBase}; Uid = {uid}; Pwd = {pwd};";
                            break;
                        }
                    }
                }
                else
                {
                    Application.Run(new frmServidor());
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            Application.Run(new frmPrincipal());
        }
    }
}
