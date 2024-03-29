﻿
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
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosAlocadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.BackColor = System.Drawing.Color.Black;
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosMenu,
            this.locaçãoToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
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
            this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.trocarUsuárioToolStripMenuItem.Text = "Trocar Usuário";
            this.trocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alterarSenhaToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
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
            this.clienteToolStripMenuItem,
            this.veículosToolStripMenuItem});
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatoriosToolStripMenuItem.Text = "Consulta";
            // 
            // veiculosAlocadosToolStripMenuItem
            // 
            this.veiculosAlocadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.veiculosAlocadosToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.veiculosAlocadosToolStripMenuItem.Name = "veiculosAlocadosToolStripMenuItem";
            this.veiculosAlocadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculosAlocadosToolStripMenuItem.Text = "Veiculos Alocados";
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
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.veículosToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veículosToolStripMenuItem.Text = "veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
    }
}