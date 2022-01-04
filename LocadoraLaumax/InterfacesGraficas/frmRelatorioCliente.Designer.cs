
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmRelatorioCliente
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.ltvCliente = new System.Windows.Forms.ListView();
            this.clmDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDataNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSituacaoCivil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(564, 487);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 28);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ltvCliente
            // 
            this.ltvCliente.BackColor = System.Drawing.Color.Black;
            this.ltvCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDoc,
            this.clmNome,
            this.clmTelefone,
            this.clmDataNascimento,
            this.clmSituacaoCivil});
            this.ltvCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvCliente.FullRowSelect = true;
            this.ltvCliente.GridLines = true;
            this.ltvCliente.HideSelection = false;
            this.ltvCliente.Location = new System.Drawing.Point(12, 12);
            this.ltvCliente.MultiSelect = false;
            this.ltvCliente.Name = "ltvCliente";
            this.ltvCliente.Size = new System.Drawing.Size(634, 469);
            this.ltvCliente.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvCliente.TabIndex = 11;
            this.ltvCliente.UseCompatibleStateImageBehavior = false;
            this.ltvCliente.View = System.Windows.Forms.View.Details;
            // 
            // clmDoc
            // 
            this.clmDoc.Text = "CPF";
            this.clmDoc.Width = 99;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 194;
            // 
            // clmTelefone
            // 
            this.clmTelefone.Text = "Telefone";
            this.clmTelefone.Width = 126;
            // 
            // clmDataNascimento
            // 
            this.clmDataNascimento.Text = "Data Nascimento";
            this.clmDataNascimento.Width = 110;
            // 
            // clmSituacaoCivil
            // 
            this.clmSituacaoCivil.Text = "Situação Civil";
            this.clmSituacaoCivil.Width = 101;
            // 
            // frmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(660, 522);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.ltvCliente);
            this.MaximizeBox = false;
            this.Name = "frmRelatorioCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Relatório Cliente";
            this.Load += new System.EventHandler(this.frmRelatorioCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListView ltvCliente;
        private System.Windows.Forms.ColumnHeader clmDoc;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmTelefone;
        private System.Windows.Forms.ColumnHeader clmDataNascimento;
        private System.Windows.Forms.ColumnHeader clmSituacaoCivil;
    }
}