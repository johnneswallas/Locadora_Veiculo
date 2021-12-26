using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using BancoDados;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmVeiculoAlocados : Form
    {
        public frmVeiculoAlocados()
        {
            InitializeComponent();
        }
        BDAlugar bancoDados = new BDAlugar();
        private void frmVeiculoAlocados_Load(object sender, EventArgs e)
        {
            try
            {
                //pesquisar todos
                List<ListaVeiculos> lista = bancoDados.ConsultaVeiculosAlocados();
                foreach (var obj in lista)
                {
                    string situacao;
                    string modelo;
                    if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                    {
                        situacao = "DISPONÍVEL";
                    }
                    else
                    {
                        situacao = "INDISPONÍVEL";
                    }
                    if (obj.ModeloVeiculo.Trim().Contains(" "))
                    {
                        modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
                    }
                    else
                    {
                        modelo = obj.ModeloVeiculo.ToUpper();
                    }
                    ListViewItem itens = new ListViewItem(new[] { situacao, obj.PlacaVeiculo.ToUpper(), modelo,
                    obj.NomeCliente.ToUpper(),obj.DocCliente, obj.Telefone,obj.DataFim.Date.ToString("dd/MM/yyyy")});
                    ltvVeiculo.Items.Add(itens);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
            /*
             try
            {
                List<int> listaEstoque = bancoDados.TotVeiculos();
                for (int i = 0; i < 2; i++)
                {
                    lblDiponivel.Text = "Veiculos Disponiveis: " + listaEstoque[0];
                    lblIndisponivel.Text = "Veiculos Alocados: " + listaEstoque[1];
                }
            }
            catch (Exception erro){ }
            //*/
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //pesquisar pelo campo
            //copiado
            string rdb = panel1.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            DateTime datanow = DateTime.Now.Date;
            switch (rdb)
            {
                case "Todos":
                    ltvVeiculo.Items.Clear();
                    try
                    {
                        //pesquisar todos
                        List<ListaVeiculos> lista = bancoDados.ConsultaVeiculosAlocados();
                        foreach (var obj in lista)
                        {
                            string situacao;
                            string modelo;
                            if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                            {
                                situacao = "DISPONÍVEL";
                            }
                            else
                            {
                                situacao = "INDISPONÍVEL";
                            }
                            if (obj.ModeloVeiculo.Trim().Contains(" "))
                            {
                                modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
                            }
                            else
                            {
                                modelo = obj.ModeloVeiculo.ToUpper();
                            }
                            ListViewItem itens = new ListViewItem(new[] { situacao, obj.PlacaVeiculo.ToUpper(), modelo,
                    obj.NomeCliente.ToUpper(),obj.DocCliente, obj.Telefone,obj.DataFim.Date.ToString("dd/MM/yyyy")});
                            ltvVeiculo.Items.Add(itens);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(" " + erro);
                    }
                    break;
                case "Somente Alocados":
                    ltvVeiculo.Items.Clear();
                    try
                    {
                        //pesquisar todos
                        List<ListaVeiculos> lista = bancoDados.ConsultaVeiculosAlocados("I");
                        foreach (var obj in lista)
                        {
                            string situacao;
                            string modelo;
                            if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                            {
                                situacao = "DISPONÍVEL";
                            }
                            else
                            {
                                situacao = "INDISPONÍVEL";
                            }
                            if (obj.ModeloVeiculo.Trim().Contains(" "))
                            {
                                modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
                            }
                            else
                            {
                                modelo = obj.ModeloVeiculo.ToUpper();
                            }
                            ListViewItem itens = new ListViewItem(new[] { situacao, obj.PlacaVeiculo.ToUpper(), modelo,
                    obj.NomeCliente.ToUpper(),obj.DocCliente, obj.Telefone,obj.DataFim.Date.ToString("dd/MM/yyyy")});
                            ltvVeiculo.Items.Add(itens);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(" " + erro);
                    }
                    break;
                case "Somente Já Entregues":
                    ltvVeiculo.Items.Clear();
                    try
                    {
                        //pesquisar todos
                        List<ListaVeiculos> lista = bancoDados.ConsultaVeiculosAlocados("D");
                        foreach (var obj in lista)
                        {
                            string situacao;
                            string modelo;
                            if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                            {
                                situacao = "DISPONÍVEL";
                            }
                            else
                            {
                                situacao = "INDISPONÍVEL";
                            }
                            if (obj.ModeloVeiculo.Trim().Contains(" "))
                            {
                                modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
                            }
                            else
                            {
                                modelo = obj.ModeloVeiculo.ToUpper();
                            }
                            ListViewItem itens = new ListViewItem(new[] { situacao, obj.PlacaVeiculo.ToUpper(), modelo,
                    obj.NomeCliente.ToUpper(),obj.DocCliente, obj.Telefone,obj.DataFim.Date.ToString("dd/MM/yyyy")});
                            ltvVeiculo.Items.Add(itens);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(" " + erro);
                    }
                    break;
                case "Data de Entrega Vencida":
                    ltvVeiculo.Items.Clear();
                    try
                    {
                        //pesquisar todos
                        List<ListaVeiculos> lista = bancoDados.ConsultaVeiculosAlocados(DateTime.Now.Date);
                        foreach (var obj in lista)
                        {
                            string situacao;
                            string modelo;
                            if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                            {
                                situacao = "DISPONÍVEL";
                            }
                            else
                            {
                                situacao = "INDISPONÍVEL";
                            }
                            if (obj.ModeloVeiculo.Trim().Contains(" "))
                            {
                                modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
                            }
                            else
                            {
                                modelo = obj.ModeloVeiculo.ToUpper();
                            }
                            ListViewItem itens = new ListViewItem(new[] { situacao, obj.PlacaVeiculo.ToUpper(), modelo,
                    obj.NomeCliente.ToUpper(),obj.DocCliente, obj.Telefone,obj.DataFim.Date.ToString("dd/MM/yyyy")});
                            ltvVeiculo.Items.Add(itens);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(" " + erro);
                    }
                    break;
            }
            //List<int> qtnVeiculo = bancoDados.TotVeiculos();
            //lblDiponivel.Text = "Veiculos Disponiveis: " + qtnVeiculo[0];
            //lblIndisponivel.Text = "Veiculos Alocados: " + qtnVeiculo[1];
        }
    }
}
