
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmDevolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbJuros = new System.Windows.Forms.CheckBox();
            this.pnlValores = new System.Windows.Forms.Panel();
            this.lblKmAtualT = new System.Windows.Forms.Label();
            this.mskKm = new System.Windows.Forms.MaskedTextBox();
            this.lblDiasT = new System.Windows.Forms.Label();
            this.lblTotalT = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gpbCondicao = new System.Windows.Forms.GroupBox();
            this.rdbMuitoAvariado = new System.Windows.Forms.RadioButton();
            this.rdbGrandeAvaria = new System.Windows.Forms.RadioButton();
            this.rdbMediaAvaria = new System.Windows.Forms.RadioButton();
            this.rdbLeveAvaria = new System.Windows.Forms.RadioButton();
            this.rdbSemAvaria = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.mskDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.mskRetirada = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskDocAluguel = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlValores.SuspendLayout();
            this.gpbCondicao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPesquisarCliente);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtPesquisarCliente);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox4.Location = new System.Drawing.Point(387, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 57);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Do Cliente";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.Blue;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(293, 23);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(83, 28);
            this.btnPesquisarCliente.TabIndex = 1;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento:";
            // 
            // txtPesquisarCliente
            // 
            this.txtPesquisarCliente.BackColor = System.Drawing.Color.White;
            this.txtPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarCliente.Location = new System.Drawing.Point(118, 24);
            this.txtPesquisarCliente.MaxLength = 14;
            this.txtPesquisarCliente.Name = "txtPesquisarCliente";
            this.txtPesquisarCliente.Size = new System.Drawing.Size(166, 25);
            this.txtPesquisarCliente.TabIndex = 0;
            this.txtPesquisarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.txtPesquisarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_PesquisarCliente);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbJuros);
            this.groupBox3.Controls.Add(this.pnlValores);
            this.groupBox3.Controls.Add(this.gpbCondicao);
            this.groupBox3.Controls.Add(this.btnImprimir);
            this.groupBox3.Controls.Add(this.btnCalcular);
            this.groupBox3.Controls.Add(this.btnFinalizar);
            this.groupBox3.Controls.Add(this.lblNome);
            this.groupBox3.Controls.Add(this.lblPlaca);
            this.groupBox3.Controls.Add(this.lblDiaria);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.mskDevolucao);
            this.groupBox3.Controls.Add(this.mskRetirada);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.mskDocAluguel);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(9, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Aluguel";
            // 
            // ckbJuros
            // 
            this.ckbJuros.AutoSize = true;
            this.ckbJuros.Checked = true;
            this.ckbJuros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbJuros.Location = new System.Drawing.Point(19, 211);
            this.ckbJuros.Name = "ckbJuros";
            this.ckbJuros.Size = new System.Drawing.Size(219, 29);
            this.ckbJuros.TabIndex = 12;
            this.ckbJuros.Text = "Calcular Com Juros";
            this.ckbJuros.UseVisualStyleBackColor = true;
            // 
            // pnlValores
            // 
            this.pnlValores.Controls.Add(this.lblKmAtualT);
            this.pnlValores.Controls.Add(this.mskKm);
            this.pnlValores.Controls.Add(this.lblDiasT);
            this.pnlValores.Controls.Add(this.lblTotalT);
            this.pnlValores.Controls.Add(this.lblDias);
            this.pnlValores.Controls.Add(this.lblTotal);
            this.pnlValores.Location = new System.Drawing.Point(13, 120);
            this.pnlValores.Name = "pnlValores";
            this.pnlValores.Size = new System.Drawing.Size(656, 26);
            this.pnlValores.TabIndex = 4;
            // 
            // lblKmAtualT
            // 
            this.lblKmAtualT.AutoSize = true;
            this.lblKmAtualT.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmAtualT.Location = new System.Drawing.Point(218, 1);
            this.lblKmAtualT.Name = "lblKmAtualT";
            this.lblKmAtualT.Size = new System.Drawing.Size(84, 20);
            this.lblKmAtualT.TabIndex = 9;
            this.lblKmAtualT.Text = "km Atual:";
            // 
            // mskKm
            // 
            this.mskKm.Culture = new System.Globalization.CultureInfo("es-US");
            this.mskKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskKm.Location = new System.Drawing.Point(320, 2);
            this.mskKm.Mask = "999.999.99";
            this.mskKm.Name = "mskKm";
            this.mskKm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskKm.Size = new System.Drawing.Size(121, 25);
            this.mskKm.TabIndex = 1;
            this.mskKm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start0_MouseClick);
            this.mskKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.mskKm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclar_Calcular);
            // 
            // lblDiasT
            // 
            this.lblDiasT.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasT.Location = new System.Drawing.Point(2, 1);
            this.lblDiasT.Name = "lblDiasT";
            this.lblDiasT.Size = new System.Drawing.Size(60, 19);
            this.lblDiasT.TabIndex = 10;
            this.lblDiasT.Text = "Dias:";
            // 
            // lblTotalT
            // 
            this.lblTotalT.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalT.Location = new System.Drawing.Point(455, 1);
            this.lblTotalT.Name = "lblTotalT";
            this.lblTotalT.Size = new System.Drawing.Size(55, 25);
            this.lblTotalT.TabIndex = 9;
            this.lblTotalT.Text = "Total:";
            // 
            // lblDias
            // 
            this.lblDias.BackColor = System.Drawing.Color.White;
            this.lblDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDias.Enabled = false;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.Color.Black;
            this.lblDias.Location = new System.Drawing.Point(79, -4);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(121, 25);
            this.lblDias.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Enabled = false;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(523, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 25);
            this.lblTotal.TabIndex = 11;
            // 
            // gpbCondicao
            // 
            this.gpbCondicao.Controls.Add(this.rdbMuitoAvariado);
            this.gpbCondicao.Controls.Add(this.rdbGrandeAvaria);
            this.gpbCondicao.Controls.Add(this.rdbMediaAvaria);
            this.gpbCondicao.Controls.Add(this.rdbLeveAvaria);
            this.gpbCondicao.Controls.Add(this.rdbSemAvaria);
            this.gpbCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCondicao.ForeColor = System.Drawing.Color.Yellow;
            this.gpbCondicao.Location = new System.Drawing.Point(19, 152);
            this.gpbCondicao.Name = "gpbCondicao";
            this.gpbCondicao.Size = new System.Drawing.Size(638, 53);
            this.gpbCondicao.TabIndex = 3;
            this.gpbCondicao.TabStop = false;
            this.gpbCondicao.Text = "Condição do Veículo";
            // 
            // rdbMuitoAvariado
            // 
            this.rdbMuitoAvariado.AutoSize = true;
            this.rdbMuitoAvariado.Checked = true;
            this.rdbMuitoAvariado.Location = new System.Drawing.Point(508, 21);
            this.rdbMuitoAvariado.Name = "rdbMuitoAvariado";
            this.rdbMuitoAvariado.Size = new System.Drawing.Size(124, 22);
            this.rdbMuitoAvariado.TabIndex = 4;
            this.rdbMuitoAvariado.TabStop = true;
            this.rdbMuitoAvariado.Text = "Muito Avariado";
            this.rdbMuitoAvariado.UseVisualStyleBackColor = true;
            // 
            // rdbGrandeAvaria
            // 
            this.rdbGrandeAvaria.AutoSize = true;
            this.rdbGrandeAvaria.Location = new System.Drawing.Point(368, 21);
            this.rdbGrandeAvaria.Name = "rdbGrandeAvaria";
            this.rdbGrandeAvaria.Size = new System.Drawing.Size(119, 22);
            this.rdbGrandeAvaria.TabIndex = 3;
            this.rdbGrandeAvaria.Text = "Grande Avaria";
            this.rdbGrandeAvaria.UseVisualStyleBackColor = true;
            // 
            // rdbMediaAvaria
            // 
            this.rdbMediaAvaria.AutoSize = true;
            this.rdbMediaAvaria.Location = new System.Drawing.Point(238, 21);
            this.rdbMediaAvaria.Name = "rdbMediaAvaria";
            this.rdbMediaAvaria.Size = new System.Drawing.Size(110, 22);
            this.rdbMediaAvaria.TabIndex = 2;
            this.rdbMediaAvaria.Text = "Media Avaria";
            this.rdbMediaAvaria.UseVisualStyleBackColor = true;
            // 
            // rdbLeveAvaria
            // 
            this.rdbLeveAvaria.AutoSize = true;
            this.rdbLeveAvaria.Location = new System.Drawing.Point(121, 21);
            this.rdbLeveAvaria.Name = "rdbLeveAvaria";
            this.rdbLeveAvaria.Size = new System.Drawing.Size(101, 22);
            this.rdbLeveAvaria.TabIndex = 1;
            this.rdbLeveAvaria.Text = "Leve Avaria";
            this.rdbLeveAvaria.UseVisualStyleBackColor = true;
            // 
            // rdbSemAvaria
            // 
            this.rdbSemAvaria.AutoSize = true;
            this.rdbSemAvaria.Location = new System.Drawing.Point(6, 21);
            this.rdbSemAvaria.Name = "rdbSemAvaria";
            this.rdbSemAvaria.Size = new System.Drawing.Size(101, 22);
            this.rdbSemAvaria.TabIndex = 0;
            this.rdbSemAvaria.Text = "Sem Avaria";
            this.rdbSemAvaria.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Yellow;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(678, 177);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(78, 28);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Blue;
            this.btnCalcular.Location = new System.Drawing.Point(510, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizar.Location = new System.Drawing.Point(594, 211);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(78, 28);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(536, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(121, 25);
            this.lblNome.TabIndex = 11;
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.Color.White;
            this.lblPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlaca.Enabled = false;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblPlaca.Location = new System.Drawing.Point(92, 35);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(121, 25);
            this.lblPlaca.TabIndex = 11;
            // 
            // lblDiaria
            // 
            this.lblDiaria.BackColor = System.Drawing.Color.White;
            this.lblDiaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiaria.Enabled = false;
            this.lblDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaria.ForeColor = System.Drawing.Color.Black;
            this.lblDiaria.Location = new System.Drawing.Point(333, 35);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(121, 25);
            this.lblDiaria.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(1096, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(678, 211);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 28);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(231, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Devolução:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Retirada:";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(250, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 19);
            this.label18.TabIndex = 1;
            this.label18.Text = "Diária:";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Placa:";
            // 
            // mskDevolucao
            // 
            this.mskDevolucao.BackColor = System.Drawing.Color.Red;
            this.mskDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDevolucao.Culture = new System.Globalization.CultureInfo("es-US");
            this.mskDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDevolucao.ForeColor = System.Drawing.Color.White;
            this.mskDevolucao.Location = new System.Drawing.Point(333, 78);
            this.mskDevolucao.Mask = "99/99/9999";
            this.mskDevolucao.Name = "mskDevolucao";
            this.mskDevolucao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDevolucao.Size = new System.Drawing.Size(121, 25);
            this.mskDevolucao.TabIndex = 0;
            this.mskDevolucao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start0_MouseClick);
            this.mskDevolucao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.mskDevolucao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // mskRetirada
            // 
            this.mskRetirada.Culture = new System.Globalization.CultureInfo("es-US");
            this.mskRetirada.Enabled = false;
            this.mskRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRetirada.Location = new System.Drawing.Point(92, 77);
            this.mskRetirada.Mask = "99/99/9999";
            this.mskRetirada.Name = "mskRetirada";
            this.mskRetirada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskRetirada.Size = new System.Drawing.Size(121, 25);
            this.mskRetirada.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // mskDocAluguel
            // 
            this.mskDocAluguel.BackColor = System.Drawing.Color.White;
            this.mskDocAluguel.Culture = new System.Globalization.CultureInfo("es-US");
            this.mskDocAluguel.Enabled = false;
            this.mskDocAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDocAluguel.Location = new System.Drawing.Point(536, 36);
            this.mskDocAluguel.Mask = "999.999.999.99";
            this.mskDocAluguel.Name = "mskDocAluguel";
            this.mskDocAluguel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDocAluguel.Size = new System.Drawing.Size(121, 25);
            this.mskDocAluguel.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do veículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa do veículo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.White;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(194, 27);
            this.txtPlaca.MaxLength = 14;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(133, 25);
            this.txtPlaca.TabIndex = 0;
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 337);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmDevolucao";
            this.ShowIcon = false;
            this.Text = "Devolução";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlValores.ResumeLayout(false);
            this.pnlValores.PerformLayout();
            this.gpbCondicao.ResumeLayout(false);
            this.gpbCondicao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mskDocAluguel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTotalT;
        private System.Windows.Forms.Label lblDiasT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.MaskedTextBox mskDevolucao;
        private System.Windows.Forms.MaskedTextBox mskRetirada;
        private System.Windows.Forms.Label lblKmAtualT;
        private System.Windows.Forms.GroupBox gpbCondicao;
        private System.Windows.Forms.RadioButton rdbMediaAvaria;
        private System.Windows.Forms.RadioButton rdbLeveAvaria;
        private System.Windows.Forms.RadioButton rdbSemAvaria;
        private System.Windows.Forms.RadioButton rdbMuitoAvariado;
        private System.Windows.Forms.RadioButton rdbGrandeAvaria;
        private System.Windows.Forms.MaskedTextBox mskKm;
        private System.Windows.Forms.Panel pnlValores;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.CheckBox ckbJuros;
    }
}