namespace PDesp
{
    partial class frmDespesa
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
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.cbxTipoDespesa = new System.Windows.Forms.ComboBox();
            this.cbxMembro = new System.Windows.Forms.ComboBox();
            this.lblMembro = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.mcalDespesa = new System.Windows.Forms.MonthCalendar();
            this.lblValorDespesa = new System.Windows.Forms.Label();
            this.mtxtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(32, 29);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(145, 25);
            this.lblTipoDespesa.TabIndex = 0;
            this.lblTipoDespesa.Text = "Tipo Despesa";
            // 
            // cbxTipoDespesa
            // 
            this.cbxTipoDespesa.FormattingEnabled = true;
            this.cbxTipoDespesa.Location = new System.Drawing.Point(183, 26);
            this.cbxTipoDespesa.Name = "cbxTipoDespesa";
            this.cbxTipoDespesa.Size = new System.Drawing.Size(390, 33);
            this.cbxTipoDespesa.TabIndex = 1;
            // 
            // cbxMembro
            // 
            this.cbxMembro.FormattingEnabled = true;
            this.cbxMembro.Location = new System.Drawing.Point(183, 95);
            this.cbxMembro.Name = "cbxMembro";
            this.cbxMembro.Size = new System.Drawing.Size(390, 33);
            this.cbxMembro.TabIndex = 3;
            // 
            // lblMembro
            // 
            this.lblMembro.AutoSize = true;
            this.lblMembro.Location = new System.Drawing.Point(32, 98);
            this.lblMembro.Name = "lblMembro";
            this.lblMembro.Size = new System.Drawing.Size(90, 25);
            this.lblMembro.TabIndex = 2;
            this.lblMembro.Text = "Membro";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(651, 29);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // mcalDespesa
            // 
            this.mcalDespesa.Location = new System.Drawing.Point(741, 26);
            this.mcalDespesa.Name = "mcalDespesa";
            this.mcalDespesa.TabIndex = 5;
            // 
            // lblValorDespesa
            // 
            this.lblValorDespesa.AutoSize = true;
            this.lblValorDespesa.Location = new System.Drawing.Point(32, 171);
            this.lblValorDespesa.Name = "lblValorDespesa";
            this.lblValorDespesa.Size = new System.Drawing.Size(62, 25);
            this.lblValorDespesa.TabIndex = 6;
            this.lblValorDespesa.Text = "Valor";
            // 
            // mtxtValor
            // 
            this.mtxtValor.Location = new System.Drawing.Point(183, 168);
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.Size = new System.Drawing.Size(211, 31);
            this.mtxtValor.TabIndex = 7;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(183, 256);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(390, 217);
            this.txtObservacao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Observações";
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.mtxtValor);
            this.Controls.Add(this.lblValorDespesa);
            this.Controls.Add(this.mcalDespesa);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbxMembro);
            this.Controls.Add(this.lblMembro);
            this.Controls.Add(this.cbxTipoDespesa);
            this.Controls.Add(this.lblTipoDespesa);
            this.Name = "frmDespesa";
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.ComboBox cbxTipoDespesa;
        private System.Windows.Forms.ComboBox cbxMembro;
        private System.Windows.Forms.Label lblMembro;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MonthCalendar mcalDespesa;
        private System.Windows.Forms.Label lblValorDespesa;
        private System.Windows.Forms.MaskedTextBox mtxtValor;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label1;
    }
}