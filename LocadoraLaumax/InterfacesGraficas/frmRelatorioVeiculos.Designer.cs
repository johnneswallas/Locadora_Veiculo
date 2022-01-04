
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmRelatorioVeiculos
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
            this.clmPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValorDiaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSituacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clomKm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDocUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbIndisponivel = new System.Windows.Forms.RadioButton();
            this.rdbdisponivel = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltvVeiculo
            // 
            this.ltvVeiculo.BackColor = System.Drawing.Color.Black;
            this.ltvVeiculo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPlaca,
            this.clmFabricante,
            this.clmModelo,
            this.clmAno,
            this.clmValorDiaria,
            this.clmSituacao,
            this.clomKm,
            this.clmDocUsuario});
            this.ltvVeiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvVeiculo.FullRowSelect = true;
            this.ltvVeiculo.GridLines = true;
            this.ltvVeiculo.HideSelection = false;
            this.ltvVeiculo.Location = new System.Drawing.Point(12, 49);
            this.ltvVeiculo.MultiSelect = false;
            this.ltvVeiculo.Name = "ltvVeiculo";
            this.ltvVeiculo.Size = new System.Drawing.Size(799, 478);
            this.ltvVeiculo.TabIndex = 9;
            this.ltvVeiculo.UseCompatibleStateImageBehavior = false;
            this.ltvVeiculo.View = System.Windows.Forms.View.Details;
            // 
            // clmPlaca
            // 
            this.clmPlaca.Text = "Placa";
            this.clmPlaca.Width = 96;
            // 
            // clmFabricante
            // 
            this.clmFabricante.Text = "Fabricante";
            this.clmFabricante.Width = 104;
            // 
            // clmModelo
            // 
            this.clmModelo.Text = "Modelo";
            this.clmModelo.Width = 111;
            // 
            // clmAno
            // 
            this.clmAno.Text = "Ano Fabricação";
            this.clmAno.Width = 99;
            // 
            // clmValorDiaria
            // 
            this.clmValorDiaria.Text = "Valor Diária";
            this.clmValorDiaria.Width = 88;
            // 
            // clmSituacao
            // 
            this.clmSituacao.Text = "Situação";
            this.clmSituacao.Width = 88;
            // 
            // clomKm
            // 
            this.clomKm.Text = "Kilometragem";
            this.clomKm.Width = 121;
            // 
            // clmDocUsuario
            // 
            this.clmDocUsuario.Text = "Doc.Usuario";
            this.clmDocUsuario.Width = 105;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbTodos);
            this.panel1.Controls.Add(this.rdbIndisponivel);
            this.panel1.Controls.Add(this.rdbdisponivel);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 25);
            this.panel1.TabIndex = 15;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.ForeColor = System.Drawing.Color.Black;
            this.rdbTodos.Location = new System.Drawing.Point(2, 5);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 13;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbIndisponivel
            // 
            this.rdbIndisponivel.AutoSize = true;
            this.rdbIndisponivel.ForeColor = System.Drawing.Color.Black;
            this.rdbIndisponivel.Location = new System.Drawing.Point(191, 5);
            this.rdbIndisponivel.Name = "rdbIndisponivel";
            this.rdbIndisponivel.Size = new System.Drawing.Size(128, 17);
            this.rdbIndisponivel.TabIndex = 13;
            this.rdbIndisponivel.Text = "Somente Indisponível";
            this.rdbIndisponivel.UseVisualStyleBackColor = true;
            // 
            // rdbdisponivel
            // 
            this.rdbdisponivel.AutoSize = true;
            this.rdbdisponivel.ForeColor = System.Drawing.Color.Black;
            this.rdbdisponivel.Location = new System.Drawing.Point(63, 5);
            this.rdbdisponivel.Name = "rdbdisponivel";
            this.rdbdisponivel.Size = new System.Drawing.Size(121, 17);
            this.rdbdisponivel.TabIndex = 13;
            this.rdbdisponivel.Text = "Somente Disponível";
            this.rdbdisponivel.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(344, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 26);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(445, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 26);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmRelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(823, 539);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ltvVeiculo);
            this.MaximizeBox = false;
            this.Name = "frmRelatorioVeiculos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório Veículos";
            this.Load += new System.EventHandler(this.frmRelatorioVeiculos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvVeiculo;
        private System.Windows.Forms.ColumnHeader clmSituacao;
        private System.Windows.Forms.ColumnHeader clmPlaca;
        private System.Windows.Forms.ColumnHeader clmModelo;
        private System.Windows.Forms.ColumnHeader clmFabricante;
        private System.Windows.Forms.ColumnHeader clmAno;
        private System.Windows.Forms.ColumnHeader clmValorDiaria;
        private System.Windows.Forms.ColumnHeader clomKm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbIndisponivel;
        private System.Windows.Forms.RadioButton rdbdisponivel;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ColumnHeader clmDocUsuario;
    }
}