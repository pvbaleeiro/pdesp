namespace PDesp
{
    partial class frmSobre
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.txtbxDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.llblGithub = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblProjeto, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblVersao, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtbxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.btnOK, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.llblGithub, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(756, 570);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjeto.Location = new System.Drawing.Point(254, 0);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblProjeto.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(475, 33);
            this.lblProjeto.TabIndex = 19;
            this.lblProjeto.Text = "Product Name";
            this.lblProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProjeto.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersao.Location = new System.Drawing.Point(254, 53);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblVersao.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(475, 33);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Version";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(254, 106);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(12, 0, 6, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 33);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(475, 33);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxDescription
            // 
            this.txtbxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxDescription.Enabled = false;
            this.txtbxDescription.Location = new System.Drawing.Point(254, 218);
            this.txtbxDescription.Margin = new System.Windows.Forms.Padding(12, 6, 6, 6);
            this.txtbxDescription.Multiline = true;
            this.txtbxDescription.Name = "txtbxDescription";
            this.txtbxDescription.ReadOnly = true;
            this.txtbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxDescription.Size = new System.Drawing.Size(475, 253);
            this.txtbxDescription.TabIndex = 23;
            this.txtbxDescription.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(579, 484);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 40);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::PDesp.Properties.Resources.sobre_victor;
            this.logoPictureBox.Location = new System.Drawing.Point(6, 6);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(230, 518);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // llblGithub
            // 
            this.llblGithub.AutoSize = true;
            this.llblGithub.Location = new System.Drawing.Point(245, 159);
            this.llblGithub.Name = "llblGithub";
            this.llblGithub.Size = new System.Drawing.Size(110, 25);
            this.llblGithub.TabIndex = 25;
            this.llblGithub.TabStop = true;
            this.llblGithub.Text = "linkLabel1";
            this.llblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGithub_LinkClicked);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 570);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSobre";
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtbxDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.LinkLabel llblGithub;
    }
}