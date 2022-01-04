using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using BancoDados;
namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmRelatorioVeiculoAlocados : Form
    {
        public frmRelatorioVeiculoAlocados()
        {
            InitializeComponent();
        }
        BDAlugar bancoDados = new BDAlugar();
        private void frmVeiculoAlocados_Load(object sender, EventArgs e)
        {
            try
            {
                //pesquisar todos
                List<Alugados> lista = bancoDados.ConsultaVeiculosAlocados();
                foreach (var obj in lista)
                {
                    string situacao = "INDISPONÍVEL";
                    string modelo = obj.ModeloVeiculo.ToUpper();

                    if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                    {
                        situacao = "DISPONÍVEL";
                    }
                    if (obj.ModeloVeiculo.Trim().Contains(" "))
                    {
                        modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
                    }

                    ListViewItem itens = new ListViewItem(new[] { situacao, obj.PlacaVeiculo.ToUpper(), modelo,
                        obj.NomeCliente.ToUpper(),obj.DocCliente, obj.Telefone,obj.DataFim.Date.ToString("dd/MM/yyyy")});

                    ltvVeiculo.Items.Add(itens);
                }
                /*
                List<int> listaEstoque = bancoDados.TotVeiculos();
                for (int i = 0; i < 2; i++)
                {
                    lblDiponivel.Text = "Veiculos Disponiveis: " + listaEstoque[0];
                    lblIndisponivel.Text = "Veiculos Alocados: " + listaEstoque[1];
                }
                //List<int> qtnVeiculo = bancoDados.TotVeiculos();
                //lblDiponivel.Text = "Veiculos Disponiveis: " + qtnVeiculo[0];
                //lblIndisponivel.Text = "Veiculos Alocados: " + qtnVeiculo[1];
                //*/
            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //pesquisar pelo campo
                //copiado
                string rdb = panel1.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;

                switch (rdb)
                {
                    case "Todos":
                        ltvVeiculo.Items.Clear();
                        try
                        {
                            //pesquisar todos
                            List<Alugados> lista = bancoDados.ConsultaVeiculosAlocados();
                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.ModeloVeiculo.ToUpper();
                                if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.ModeloVeiculo.Trim().Contains(" "))
                                {
                                    modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
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
                            //pesquisar somente os alocados
                            List<Alugados> lista = bancoDados.ConsultaVeiculosAlocados("I");
                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.ModeloVeiculo.ToUpper();
                                if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.ModeloVeiculo.Trim().Contains(" "))
                                {
                                    modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
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
                            //pesquisar veiculos ja entregues
                            List<Alugados> lista = bancoDados.ConsultaVeiculosAlocados("D");
                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.ModeloVeiculo.ToUpper();
                                if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.ModeloVeiculo.Trim().Contains(" "))
                                {
                                    modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
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
                            //pesquisar data de entrega vencida
                            List<Alugados> lista = bancoDados.ConsultaVeiculosAlocados(DateTime.Now.Date);
                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.ModeloVeiculo.ToUpper();
                                if (obj.SituacaoVeiculo.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.ModeloVeiculo.Trim().Contains(" "))
                                {
                                    modelo = obj.ModeloVeiculo.Substring(0, obj.ModeloVeiculo.IndexOf(" ")).ToUpper();
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
                    default:
                        MessageBox.Show("Erro ineperado" , "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
        }
    }
}
