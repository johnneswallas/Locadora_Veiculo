
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmCadVeiculo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkbKm = new System.Windows.Forms.MaskedTextBox();
            this.cmbAnoFabricacao = new System.Windows.Forms.ComboBox();
            this.txtDiaria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.mkbKm);
            this.groupBox1.Controls.Add(this.cmbAnoFabricacao);
            this.groupBox1.Controls.Add(this.txtDiaria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFabricante);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Veículo";
            // 
            // mkbKm
            // 
            this.mkbKm.Culture = new System.Globalization.CultureInfo("es-US");
            this.mkbKm.Location = new System.Drawing.Point(135, 124);
            this.mkbKm.Mask = "999.999.99";
            this.mkbKm.Name = "mkbKm";
            this.mkbKm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mkbKm.Size = new System.Drawing.Size(102, 24);
            this.mkbKm.TabIndex = 6;
            this.mkbKm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mkbKm_MouseClick);
            this.mkbKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.mkbKm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // cmbAnoFabricacao
            // 
            this.cmbAnoFabricacao.FormattingEnabled = true;
            this.cmbAnoFabricacao.ItemHeight = 18;
            this.cmbAnoFabricacao.Location = new System.Drawing.Point(317, 94);
            this.cmbAnoFabricacao.Name = "cmbAnoFabricacao";
            this.cmbAnoFabricacao.Size = new System.Drawing.Size(105, 26);
            this.cmbAnoFabricacao.TabIndex = 5;
            this.cmbAnoFabricacao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(72, 94);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(104, 24);
            this.txtDiaria.TabIndex = 4;
            this.txtDiaria.Text = "R$ ";
            this.txtDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.txtDiaria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Diária:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ano Fabricação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kilometragem:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(347, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.btnAtualizar.Location = new System.Drawing.Point(254, 159);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 30);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Location = new System.Drawing.Point(161, 159);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 30);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(270, 23);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(152, 24);
            this.txtFabricante.TabIndex = 2;
            this.txtFabricante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(98, 58);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(324, 24);
            this.txtModelo.TabIndex = 3;
            this.txtModelo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(68, 23);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(94, 24);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 211);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // frmCadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(466, 233);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "frmCadVeiculo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículo";
            this.Load += new System.EventHandler(this.frmCadVeiculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaria;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAnoFabricacao;
        private System.Windows.Forms.MaskedTextBox mkbKm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}