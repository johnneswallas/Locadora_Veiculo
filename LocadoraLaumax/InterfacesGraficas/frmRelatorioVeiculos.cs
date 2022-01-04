using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDados;
using Entidades;

namespace LocadoraLaumax.InterfacesGraficas
{
    public partial class frmRelatorioVeiculos : Form
    {
        public frmRelatorioVeiculos()
        {
            InitializeComponent();
        }
        BDVeiculos bancoDados = new BDVeiculos();

        private void frmRelatorioVeiculos_Load(object sender, EventArgs e)
        {
            try
            {
                if (!frmAcesssoRestrito.faltenticado)
                {
                    btnExcluir.Visible = false;
                }
                //pesquisar todos
                List<Veiculos> lista = bancoDados.ListaVeiculo();
                if (lista.Count == 0)
                {
                    return;
                }

                foreach (var obj in lista)
                {
                    string situacao = "INDISPONÍVEL";
                    string modelo = obj.Modelo.ToUpper();

                    if (obj.Situacao.ToString().ToUpper() == "D")
                    {
                        situacao = "DISPONÍVEL";
                    }
                    if (obj.Modelo.Trim().Contains(" "))
                    {
                        modelo = obj.Modelo.Substring(0, obj.Modelo.IndexOf(" ")).ToUpper();
                    }

                    ListViewItem itens = new ListViewItem(new[] {obj.Placa.ToUpper(),obj.Fabricante.ToUpper(), modelo,obj.Ano.ToString("yyyy"),
                        obj.ValorDiaria.ToString("c"),situacao,obj.KmAtual.ToString(), obj.DocUsuario.ToUpper()});

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
                            List<Veiculos> lista = bancoDados.ListaVeiculo();
                            if (lista.Count == 0)
                            {
                                return;
                            }

                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.Modelo.ToUpper();

                                if (obj.Situacao.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.Modelo.Trim().Contains(" "))
                                {
                                    modelo = obj.Modelo.Substring(0, obj.Modelo.IndexOf(" ")).ToUpper();
                                }

                                ListViewItem itens = new ListViewItem(new[] {obj.Placa.ToUpper(),obj.Fabricante.ToUpper(), modelo,obj.Ano.ToString("yyyy"),
                        obj.ValorDiaria.ToString("c"),situacao,obj.KmAtual.ToString(), obj.DocUsuario.ToUpper()});

                                ltvVeiculo.Items.Add(itens);
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(" " + erro);
                        }
                        break;
                    case "Somente Disponível":
                        ltvVeiculo.Items.Clear();
                        try
                        {
                            //pesquisar somente os alocados
                            List<Veiculos> lista = bancoDados.ListaVeiculoPorSituacao("D");
                            if (lista.Count == 0)
                            {
                                return;
                            }

                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.Modelo.ToUpper();

                                if (obj.Situacao.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.Modelo.Trim().Contains(" "))
                                {
                                    modelo = obj.Modelo.Substring(0, obj.Modelo.IndexOf(" ")).ToUpper();
                                }

                                ListViewItem itens = new ListViewItem(new[] {obj.Placa.ToUpper(),obj.Fabricante.ToUpper(), modelo,obj.Ano.ToString("yyyy"),
                        obj.ValorDiaria.ToString("c"),situacao,obj.KmAtual.ToString(), obj.DocUsuario.ToUpper()});

                                ltvVeiculo.Items.Add(itens);
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(" " + erro);
                        }
                        break;
                    case "Somente Indisponível":
                        ltvVeiculo.Items.Clear();
                        try
                        {
                            //pesquisar veiculos ja entregues
                            List<Veiculos> lista = bancoDados.ListaVeiculoPorSituacao("I");
                            if (lista.Count == 0)
                            {
                                return;
                            }

                            foreach (var obj in lista)
                            {
                                string situacao = "INDISPONÍVEL";
                                string modelo = obj.Modelo.ToUpper();

                                if (obj.Situacao.ToString().ToUpper() == "D")
                                {
                                    situacao = "DISPONÍVEL";
                                }
                                if (obj.Modelo.Trim().Contains(" "))
                                {
                                    modelo = obj.Modelo.Substring(0, obj.Modelo.IndexOf(" ")).ToUpper();
                                }

                                ListViewItem itens = new ListViewItem(new[] {obj.Placa.ToUpper(),obj.Fabricante.ToUpper(), modelo,obj.Ano.ToString("yyyy"),
                        obj.ValorDiaria.ToString("c"),situacao,obj.KmAtual.ToString(), obj.DocUsuario.ToUpper()});

                                ltvVeiculo.Items.Add(itens);
                            }
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(" " + erro);
                        }
                        break;
                    default:
                        MessageBox.Show("Erro ineperado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(" " + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //se tiver 1 item selecionado 
                if (ltvVeiculo.SelectedItems.Count == 1 )
                {
                    //pego a possiçao que estar selecionado 
                    int possicao = ltvVeiculo.SelectedIndices[0];

                    //pego o primeiro item da linha selecionada que no caso e a placa 
                    string primaryKey = ltvVeiculo.Items[possicao].Text.ToString();

                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir veículo da placa " + primaryKey + " ?", null, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes && bancoDados.ExcluirVeiculo(primaryKey))
                    {
                        ltvVeiculo.Items.RemoveAt(ltvVeiculo.SelectedIndices[0]);
                        MessageBox.Show("Exclussão feita com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(""+erro, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
