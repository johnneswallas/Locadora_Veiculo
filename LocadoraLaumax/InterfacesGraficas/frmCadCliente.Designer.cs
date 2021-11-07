
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmCadCliente
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.mkbTel = new System.Windows.Forms.MaskedTextBox();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.mkbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mkbDoc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Location = new System.Drawing.Point(132, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 28);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(72, 23);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.mkbTel);
            this.groupBox1.Controls.Add(this.grpBox);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.mkbNascimento);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.mkbDoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do cliente";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.btnAtualizar.Location = new System.Drawing.Point(219, 180);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(85, 28);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualisar_Click);
            // 
            // mkbTel
            // 
            this.mkbTel.Culture = new System.Globalization.CultureInfo("es-US");
            this.mkbTel.Location = new System.Drawing.Point(278, 89);
            this.mkbTel.Mask = "(99) 99999-9999";
            this.mkbTel.Name = "mkbTel";
            this.mkbTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mkbTel.Size = new System.Drawing.Size(113, 24);
            this.mkbTel.TabIndex = 4;
            this.mkbTel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start0_MouseClick);
            this.mkbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.mkbTel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdbDivorciado);
            this.grpBox.Controls.Add(this.rdbCasado);
            this.grpBox.Controls.Add(this.rdbSolteiro);
            this.grpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox.ForeColor = System.Drawing.Color.Yellow;
            this.grpBox.Location = new System.Drawing.Point(14, 119);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(277, 49);
            this.grpBox.TabIndex = 5;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Situação Civil";
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(172, 21);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(97, 22);
            this.rdbDivorciado.TabIndex = 2;
            this.rdbDivorciado.Text = "Divorciado";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            this.rdbDivorciado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(89, 21);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(78, 22);
            this.rdbCasado.TabIndex = 1;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            this.rdbCasado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Checked = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(6, 21);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(77, 22);
            this.rdbSolteiro.TabIndex = 0;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            this.rdbSolteiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // mkbNascimento
            // 
            this.mkbNascimento.Culture = new System.Globalization.CultureInfo("es-US");
            this.mkbNascimento.Location = new System.Drawing.Point(310, 58);
            this.mkbNascimento.Mask = "99/99/9999";
            this.mkbNascimento.Name = "mkbNascimento";
            this.mkbNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mkbNascimento.Size = new System.Drawing.Size(81, 24);
            this.mkbNascimento.TabIndex = 3;
            this.mkbNascimento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start0_MouseClick);
            this.mkbNascimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.mkbNascimento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(310, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 28);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mkbDoc
            // 
            this.mkbDoc.Culture = new System.Globalization.CultureInfo("es-US");
            this.mkbDoc.Location = new System.Drawing.Point(61, 74);
            this.mkbDoc.Mask = "999.999.999.99";
            this.mkbDoc.Name = "mkbDoc";
            this.mkbDoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mkbDoc.Size = new System.Drawing.Size(118, 24);
            this.mkbDoc.TabIndex = 2;
            this.mkbDoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Start0_MouseClick);
            this.mkbDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apenas_Numeros);
            this.mkbDoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nascimento:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(421, 236);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "frmCadCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastrar Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkbNascimento;
        private System.Windows.Forms.MaskedTextBox mkbDoc;
        private System.Windows.Forms.MaskedTextBox mkbTel;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

