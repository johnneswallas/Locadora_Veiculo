
namespace LocadoraLaumax.InterfacesGraficas
{
    partial class frmPrincipal
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosAlocadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usúarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.BackColor = System.Drawing.Color.Black;
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosMenu,
            this.consultasToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnsPrincipal.TabIndex = 2;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarUsuárioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // trocarUsuárioToolStripMenuItem
            // 
            this.trocarUsuárioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trocarUsuárioToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarUsuárioToolStripMenuItem.Text = "Trocar Usuário";
            this.trocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alterarSenhaToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrosMenu
            // 
            this.cadastrosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioMenu,
            this.veiculoMenu,
            this.clienteMenu});
            this.cadastrosMenu.ForeColor = System.Drawing.Color.Yellow;
            this.cadastrosMenu.Name = "cadastrosMenu";
            this.cadastrosMenu.Size = new System.Drawing.Size(71, 20);
            this.cadastrosMenu.Text = "Cadastros";
            // 
            // usuarioMenu
            // 
            this.usuarioMenu.BackColor = System.Drawing.Color.Black;
            this.usuarioMenu.ForeColor = System.Drawing.Color.Yellow;
            this.usuarioMenu.Name = "usuarioMenu";
            this.usuarioMenu.Size = new System.Drawing.Size(119, 22);
            this.usuarioMenu.Text = "Usuarios";
            this.usuarioMenu.Click += new System.EventHandler(this.usuarioMenu_Click);
            // 
            // veiculoMenu
            // 
            this.veiculoMenu.BackColor = System.Drawing.Color.Black;
            this.veiculoMenu.ForeColor = System.Drawing.Color.Yellow;
            this.veiculoMenu.Name = "veiculoMenu";
            this.veiculoMenu.Size = new System.Drawing.Size(119, 22);
            this.veiculoMenu.Text = "Veiculos";
            this.veiculoMenu.Click += new System.EventHandler(this.veiculoMenu_Click);
            // 
            // clienteMenu
            // 
            this.clienteMenu.BackColor = System.Drawing.Color.Black;
            this.clienteMenu.ForeColor = System.Drawing.Color.Yellow;
            this.clienteMenu.Name = "clienteMenu";
            this.clienteMenu.Size = new System.Drawing.Size(119, 22);
            this.clienteMenu.Text = "Cliente";
            this.clienteMenu.Click += new System.EventHandler(this.clienteMenu_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculoToolStripMenuItem,
            this.clienteToolStripMenuItem1});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.veiculoToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.clienteToolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow;
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retiradaToolStripMenuItem,
            this.entregaToolStripMenuItem});
            this.locaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.locaçãoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // retiradaToolStripMenuItem
            // 
            this.retiradaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.retiradaToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.retiradaToolStripMenuItem.Name = "retiradaToolStripMenuItem";
            this.retiradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retiradaToolStripMenuItem.Text = "Retirada";
            this.retiradaToolStripMenuItem.Click += new System.EventHandler(this.retiradaToolStripMenuItem_Click);
            // 
            // entregaToolStripMenuItem
            // 
            this.entregaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.entregaToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.entregaToolStripMenuItem.Name = "entregaToolStripMenuItem";
            this.entregaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entregaToolStripMenuItem.Text = "Devolução";
            this.entregaToolStripMenuItem.Click += new System.EventHandler(this.entregaToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiculosAlocadosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // veiculosAlocadosToolStripMenuItem
            // 
            this.veiculosAlocadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.veiculosAlocadosToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.veiculosAlocadosToolStripMenuItem.Name = "veiculosAlocadosToolStripMenuItem";
            this.veiculosAlocadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculosAlocadosToolStripMenuItem.Text = "Veiculos";
            this.veiculosAlocadosToolStripMenuItem.Click += new System.EventHandler(this.veiculosAlocadosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usúarioToolStripMenuItem,
            this.clienteToolStripMenuItem2,
            this.veículoToolStripMenuItem});
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // usúarioToolStripMenuItem
            // 
            this.usúarioToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.usúarioToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.usúarioToolStripMenuItem.Name = "usúarioToolStripMenuItem";
            this.usúarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usúarioToolStripMenuItem.Text = "Usúario";
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.clienteToolStripMenuItem2.ForeColor = System.Drawing.Color.Yellow;
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.veículoToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículoToolStripMenuItem.Text = "Veículo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mnsPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Locadora LauMax";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem veiculoMenu;
        private System.Windows.Forms.ToolStripMenuItem clienteMenu;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retiradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosAlocadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usúarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
    }
}