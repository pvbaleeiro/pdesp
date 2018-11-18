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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesa));
            this.Dados = new System.Windows.Forms.TabPage();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.Detalhes = new System.Windows.Forms.TabPage();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblValorDespesa = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.cbxMembro = new System.Windows.Forms.ComboBox();
            this.lblMembro = new System.Windows.Forms.Label();
            this.cbxTipoDespesa = new System.Windows.Forms.ComboBox();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.bnvDespesa = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbDespesa = new System.Windows.Forms.TabControl();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.Dados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.Detalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesa)).BeginInit();
            this.bnvDespesa.SuspendLayout();
            this.tbDespesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.dgvDespesa);
            this.Dados.Location = new System.Drawing.Point(8, 39);
            this.Dados.Margin = new System.Windows.Forms.Padding(6);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(6);
            this.Dados.Size = new System.Drawing.Size(1118, 574);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AllowUserToAddRows = false;
            this.dgvDespesa.AllowUserToDeleteRows = false;
            this.dgvDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Location = new System.Drawing.Point(-3, 6);
            this.dgvDespesa.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDespesa.MaximumSize = new System.Drawing.Size(1400, 481);
            this.dgvDespesa.MinimumSize = new System.Drawing.Size(692, 350);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.ReadOnly = true;
            this.dgvDespesa.Size = new System.Drawing.Size(1123, 481);
            this.dgvDespesa.TabIndex = 0;
            this.dgvDespesa.BindingContextChanged += new System.EventHandler(this.dgvDespesa_BindingContextChanged);
            // 
            // Detalhes
            // 
            this.Detalhes.Controls.Add(this.txtValorDespesa);
            this.Detalhes.Controls.Add(this.mskData);
            this.Detalhes.Controls.Add(this.txtId);
            this.Detalhes.Controls.Add(this.lblId);
            this.Detalhes.Controls.Add(this.label1);
            this.Detalhes.Controls.Add(this.txtObservacao);
            this.Detalhes.Controls.Add(this.lblValorDespesa);
            this.Detalhes.Controls.Add(this.lblData);
            this.Detalhes.Controls.Add(this.cbxMembro);
            this.Detalhes.Controls.Add(this.lblMembro);
            this.Detalhes.Controls.Add(this.cbxTipoDespesa);
            this.Detalhes.Controls.Add(this.lblTipoDespesa);
            this.Detalhes.Location = new System.Drawing.Point(8, 39);
            this.Detalhes.Margin = new System.Windows.Forms.Padding(6);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Padding = new System.Windows.Forms.Padding(6);
            this.Detalhes.Size = new System.Drawing.Size(1118, 574);
            this.Detalhes.TabIndex = 1;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.Detalhes_Click);
            // 
            // mskData
            // 
            this.mskData.Enabled = false;
            this.mskData.Location = new System.Drawing.Point(732, 37);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(200, 31);
            this.mskData.TabIndex = 6;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(180, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 31);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 40);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 30;
            this.lblId.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Observações";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(180, 327);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(390, 217);
            this.txtObservacao.TabIndex = 5;
            // 
            // lblValorDespesa
            // 
            this.lblValorDespesa.AutoSize = true;
            this.lblValorDespesa.Location = new System.Drawing.Point(28, 242);
            this.lblValorDespesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDespesa.Name = "lblValorDespesa";
            this.lblValorDespesa.Size = new System.Drawing.Size(62, 25);
            this.lblValorDespesa.TabIndex = 26;
            this.lblValorDespesa.Text = "Valor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(648, 42);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 24;
            this.lblData.Text = "Data";
            // 
            // cbxMembro
            // 
            this.cbxMembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMembro.Enabled = false;
            this.cbxMembro.FormattingEnabled = true;
            this.cbxMembro.Location = new System.Drawing.Point(180, 165);
            this.cbxMembro.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMembro.Name = "cbxMembro";
            this.cbxMembro.Size = new System.Drawing.Size(390, 33);
            this.cbxMembro.TabIndex = 3;
            // 
            // lblMembro
            // 
            this.lblMembro.AutoSize = true;
            this.lblMembro.Location = new System.Drawing.Point(28, 169);
            this.lblMembro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembro.Name = "lblMembro";
            this.lblMembro.Size = new System.Drawing.Size(90, 25);
            this.lblMembro.TabIndex = 22;
            this.lblMembro.Text = "Membro";
            // 
            // cbxTipoDespesa
            // 
            this.cbxTipoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDespesa.Enabled = false;
            this.cbxTipoDespesa.FormattingEnabled = true;
            this.cbxTipoDespesa.Location = new System.Drawing.Point(180, 98);
            this.cbxTipoDespesa.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoDespesa.Name = "cbxTipoDespesa";
            this.cbxTipoDespesa.Size = new System.Drawing.Size(390, 33);
            this.cbxTipoDespesa.TabIndex = 2;
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(28, 100);
            this.lblTipoDespesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(145, 25);
            this.lblTipoDespesa.TabIndex = 20;
            this.lblTipoDespesa.Text = "Tipo Despesa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(28, 36);
            this.btnCancelar.Text = "Cancelar Alteração";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bnvDespesa
            // 
            this.bnvDespesa.AddNewItem = null;
            this.bnvDespesa.CountItem = this.BindingNavigatorCountItem;
            this.bnvDespesa.CountItemFormat = "de {0}";
            this.bnvDespesa.DeleteItem = null;
            this.bnvDespesa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bnvDespesa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.btnExcluir,
            this.btnSalvar,
            this.btnAlterar,
            this.btnCancelar,
            this.btnSair});
            this.bnvDespesa.Location = new System.Drawing.Point(0, 0);
            this.bnvDespesa.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.bnvDespesa.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.bnvDespesa.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.bnvDespesa.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.bnvDespesa.Name = "bnvDespesa";
            this.bnvDespesa.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnvDespesa.PositionItem = this.BindingNavigatorPositionItem;
            this.bnvDespesa.Size = new System.Drawing.Size(1128, 39);
            this.bnvDespesa.TabIndex = 5;
            this.bnvDespesa.Text = "bnvDespesa";
            this.bnvDespesa.RefreshItems += new System.EventHandler(this.bnvDespesa_RefreshItems);
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(76, 36);
            this.BindingNavigatorCountItem.Text = "de {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 36);
            this.BindingNavigatorMoveFirstItem.Text = "Primeiro registro";
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 36);
            this.BindingNavigatorMovePreviousItem.Text = "Registro anterior";
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 39);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 36);
            this.BindingNavigatorMoveNextItem.Text = "Próximo registro";
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 36);
            this.BindingNavigatorMoveLastItem.Text = "Último Registro";
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.RightToLeftAutoMirrorImage = true;
            this.btnNovoRegistro.Size = new System.Drawing.Size(28, 36);
            this.btnNovoRegistro.Text = "Adicionar Novo Registro";
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(28, 36);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(28, 36);
            this.btnSalvar.Text = "Salvar Registros";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(28, 36);
            this.btnAlterar.Text = "Alterar Registro";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(28, 36);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbDespesa
            // 
            this.tbDespesa.Controls.Add(this.Dados);
            this.tbDespesa.Controls.Add(this.Detalhes);
            this.tbDespesa.Location = new System.Drawing.Point(0, 83);
            this.tbDespesa.Margin = new System.Windows.Forms.Padding(6);
            this.tbDespesa.Name = "tbDespesa";
            this.tbDespesa.SelectedIndex = 0;
            this.tbDespesa.Size = new System.Drawing.Size(1134, 621);
            this.tbDespesa.TabIndex = 4;
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Enabled = false;
            this.txtValorDespesa.Location = new System.Drawing.Point(180, 242);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(200, 31);
            this.txtValorDespesa.TabIndex = 4;
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 727);
            this.Controls.Add(this.bnvDespesa);
            this.Controls.Add(this.tbDespesa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDespesa";
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            this.Dados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.Detalhes.ResumeLayout(false);
            this.Detalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesa)).EndInit();
            this.bnvDespesa.ResumeLayout(false);
            this.bnvDespesa.PerformLayout();
            this.tbDespesa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabPage Dados;
        internal System.Windows.Forms.DataGridView dgvDespesa;
        internal System.Windows.Forms.TabPage Detalhes;
        internal System.Windows.Forms.ToolStripButton btnCancelar;
        internal System.Windows.Forms.BindingNavigator bnvDespesa;
        internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
        internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
        internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton btnNovoRegistro;
        internal System.Windows.Forms.ToolStripButton btnExcluir;
        internal System.Windows.Forms.ToolStripButton btnSalvar;
        internal System.Windows.Forms.ToolStripButton btnAlterar;
        internal System.Windows.Forms.ToolStripButton btnSair;
        internal System.Windows.Forms.TabControl tbDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblValorDespesa;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbxMembro;
        private System.Windows.Forms.Label lblMembro;
        private System.Windows.Forms.ComboBox cbxTipoDespesa;
        private System.Windows.Forms.Label lblTipoDespesa;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.TextBox txtValorDespesa;

    }
}