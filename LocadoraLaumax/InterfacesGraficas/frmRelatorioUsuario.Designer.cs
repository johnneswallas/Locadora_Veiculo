
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmRelatorioUsuario
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
            this.ltvUsuario = new System.Windows.Forms.ListView();
            this.clmDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFkUsuarioGerente_doc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmfkUsuario_doc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltvUsuario
            // 
            this.ltvUsuario.BackColor = System.Drawing.Color.Black;
            this.ltvUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDoc,
            this.clmNome,
            this.clmUsuario,
            this.clmCargo,
            this.clmFkUsuarioGerente_doc,
            this.clmfkUsuario_doc});
            this.ltvUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvUsuario.FullRowSelect = true;
            this.ltvUsuario.GridLines = true;
            this.ltvUsuario.HideSelection = false;
            this.ltvUsuario.Location = new System.Drawing.Point(12, 12);
            this.ltvUsuario.MultiSelect = false;
            this.ltvUsuario.Name = "ltvUsuario";
            this.ltvUsuario.Size = new System.Drawing.Size(557, 469);
            this.ltvUsuario.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvUsuario.TabIndex = 9;
            this.ltvUsuario.UseCompatibleStateImageBehavior = false;
            this.ltvUsuario.View = System.Windows.Forms.View.Details;
            // 
            // clmDoc
            // 
            this.clmDoc.Text = "CPF";
            this.clmDoc.Width = 92;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 89;
            // 
            // clmUsuario
            // 
            this.clmUsuario.Text = "Usuário";
            this.clmUsuario.Width = 88;
            // 
            // clmCargo
            // 
            this.clmCargo.Text = "Cargo";
            this.clmCargo.Width = 110;
            // 
            // clmFkUsuarioGerente_doc
            // 
            this.clmFkUsuarioGerente_doc.Text = "Doc.Gerente";
            this.clmFkUsuarioGerente_doc.Width = 86;
            // 
            // clmfkUsuario_doc
            // 
            this.clmfkUsuario_doc.Text = "Doc.Usuário";
            this.clmfkUsuario_doc.Width = 87;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(487, 487);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 28);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(580, 521);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.ltvUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioUsuario";
            this.ShowIcon = false;
            this.Text = "Relatório Usuário";
            this.Load += new System.EventHandler(this.frmRelatorioUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltvUsuario;
        private System.Windows.Forms.ColumnHeader clmDoc;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmUsuario;
        private System.Windows.Forms.ColumnHeader clmCargo;
        private System.Windows.Forms.ColumnHeader clmFkUsuarioGerente_doc;
        private System.Windows.Forms.ColumnHeader clmfkUsuario_doc;
        private System.Windows.Forms.Button btnExcluir;
    }
}