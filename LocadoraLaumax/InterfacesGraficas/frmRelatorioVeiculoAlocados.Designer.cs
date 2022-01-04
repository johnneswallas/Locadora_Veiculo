
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmRelatorioVeiculoAlocados
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
            this.ltvVeiculo = new System.Windows.Forms.ListView();
            this.clmSituacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDocCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataDevolucao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIndisponivel = new System.Windows.Forms.Label();
            this.lblDiponivel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvVeiculo
            // 
            this.ltvVeiculo.BackColor = System.Drawing.Color.Black;
            this.ltvVeiculo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSituacao,
            this.clmPlaca,
            this.clmModelo,
            this.clmNomeCliente,
            this.clmDocCliente,
            this.clmTelefone,
            this.clmDataDevolucao});
            this.ltvVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvVeiculo.FullRowSelect = true;
            this.ltvVeiculo.GridLines = true;
            this.ltvVeiculo.HideSelection = false;
            this.ltvVeiculo.Location = new System.Drawing.Point(12, 44);
            this.ltvVeiculo.MultiSelect = false;
            this.ltvVeiculo.Name = "ltvVeiculo";
            this.ltvVeiculo.Size = new System.Drawing.Size(760, 465);
            this.ltvVeiculo.TabIndex = 8;
            this.ltvVeiculo.UseCompatibleStateImageBehavior = false;
            this.ltvVeiculo.View = System.Windows.Forms.View.Details;
            // 
            // clmSituacao
            // 
            this.clmSituacao.Text = "Situação";
            this.clmSituacao.Width = 92;
            // 
            // clmPlaca
            // 
            this.clmPlaca.Text = "Placa";
            this.clmPlaca.Width = 89;
            // 
            // clmModelo
            // 
            this.clmModelo.Text = "Modelo";
            this.clmModelo.Width = 106;
            // 
            // clmNomeCliente
            // 
            this.clmNomeCliente.Text = "Nome Do Cliente ";
            this.clmNomeCliente.Width = 119;
            // 
            // clmDocCliente
            // 
            this.clmDocCliente.Text = "Doc. CLiente";
            this.clmDocCliente.Width = 108;
            // 
            // clmTelefone
            // 
            this.clmTelefone.Text = "Telefone";
            this.clmTelefone.Width = 116;
            // 
            // clmDataDevolucao
            // 
            this.clmDataDevolucao.Text = "Data Devolução";
            this.clmDataDevolucao.Width = 126;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(485, -1);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 26);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(2, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(63, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Somente Alocados";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(334, 5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(145, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Data de Entrega Vencida";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(191, 5);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(132, 17);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.Text = "Somente Já Entregues";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 25);
            this.panel1.TabIndex = 14;
            // 
            // lblIndisponivel
            // 
            this.lblIndisponivel.AutoSize = true;
            this.lblIndisponivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIndisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndisponivel.ForeColor = System.Drawing.Color.Red;
            this.lblIndisponivel.Location = new System.Drawing.Point(621, 23);
            this.lblIndisponivel.Name = "lblIndisponivel";
            this.lblIndisponivel.Size = new System.Drawing.Size(133, 19);
            this.lblIndisponivel.TabIndex = 18;
            this.lblIndisponivel.Text = "Veículos Alocados: ";
            // 
            // lblDiponivel
            // 
            this.lblDiponivel.AutoSize = true;
            this.lblDiponivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiponivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDiponivel.Location = new System.Drawing.Point(608, 5);
            this.lblDiponivel.Name = "lblDiponivel";
            this.lblDiponivel.Size = new System.Drawing.Size(147, 19);
            this.lblDiponivel.TabIndex = 18;
            this.lblDiponivel.Text = "Veículos Disponíveis: ";
            // 
            // frmRelatorioVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(781, 521);
            this.Controls.Add(this.lblDiponivel);
            this.Controls.Add(this.lblIndisponivel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ltvVeiculo);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioVeiculo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Veículo Alocados";
            this.Load += new System.EventHandler(this.frmVeiculoAlocados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltvVeiculo;
        private System.Windows.Forms.ColumnHeader clmSituacao;
        private System.Windows.Forms.ColumnHeader clmPlaca;
        private System.Windows.Forms.ColumnHeader clmModelo;
        private System.Windows.Forms.ColumnHeader clmNomeCliente;
        private System.Windows.Forms.ColumnHeader clmDocCliente;
        private System.Windows.Forms.ColumnHeader clmTelefone;
        private System.Windows.Forms.ColumnHeader clmDataDevolucao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIndisponivel;
        private System.Windows.Forms.Label lblDiponivel;
    }
}