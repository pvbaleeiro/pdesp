namespace PDesp
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
            this.mstrPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDespesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosDaFamíliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrPrincipal
            // 
            this.mstrPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mstrPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mstrPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstrPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstrPrincipal.Name = "mstrPrincipal";
            this.mstrPrincipal.Size = new System.Drawing.Size(653, 24);
            this.mstrPrincipal.TabIndex = 0;
            this.mstrPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeDespesaToolStripMenuItem,
            this.membrosDaFamíliaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tiposDeDespesaToolStripMenuItem
            // 
            this.tiposDeDespesaToolStripMenuItem.Name = "tiposDeDespesaToolStripMenuItem";
            this.tiposDeDespesaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tiposDeDespesaToolStripMenuItem.Text = "Tipos de Despesa";
            this.tiposDeDespesaToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDespesaToolStripMenuItem_Click);
            // 
            // membrosDaFamíliaToolStripMenuItem
            // 
            this.membrosDaFamíliaToolStripMenuItem.Name = "membrosDaFamíliaToolStripMenuItem";
            this.membrosDaFamíliaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.membrosDaFamíliaToolStripMenuItem.Text = "Membros da Família";
            this.membrosDaFamíliaToolStripMenuItem.Click += new System.EventHandler(this.membrosDaFamíliaToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.despesasToolStripMenuItem.Text = "Despesas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.despesasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 392);
            this.Controls.Add(this.mstrPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstrPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Controle das Despesas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mstrPrincipal.ResumeLayout(false);
            this.mstrPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDespesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membrosDaFamíliaToolStripMenuItem;
    }
}

