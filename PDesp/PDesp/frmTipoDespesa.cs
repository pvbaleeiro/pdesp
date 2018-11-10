using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PDesp
{
    public partial class frmTipoDespesa : Form
    {
        private BindingSource bnTipoDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsTipoDesesa = new DataSet();


        public frmTipoDespesa()
        {
            InitializeComponent();
        }

        private void frmTipoDespesa_Load(object sender, EventArgs e)
        {
            try
            {
                TipoDespesa tipoDespesa = new TipoDespesa();
                dsTipoDesesa.Tables.Add(tipoDespesa.Listar());
                bnTipoDespesa.DataSource = dsTipoDesesa.Tables["TIPODESPESA"];
                dgvTipoDespesa.DataSource = bnTipoDespesa;
                bnvTipoDespesa.BindingSource = bnTipoDespesa;

                txtId.DataBindings.Add("TEXT", bnTipoDespesa, "ID_TIPODESPESA");
                txtNomeTipoDespesa.DataBindings.Add("TEXT", bnTipoDespesa, "NOME_TIPODESPESA");
                dgvTipoDespesa.Columns[0].HeaderText = "ID";
                dgvTipoDespesa.Columns[1].HeaderText = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbTipoDespesa.SelectedIndex == 0)
            {
                tbTipoDespesa.SelectTab(1);
            }

            bnTipoDespesa.AddNew();
            txtNomeTipoDespesa.Enabled = true;
            txtNomeTipoDespesa.Focus();
            TipoDespesa tipoDespesa = new TipoDespesa();
            txtId.Text = tipoDespesa.NextIdentifier().ToString();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbTipoDespesa.SelectedIndex == 0)
            {
                tbTipoDespesa.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TipoDespesa regTD = new TipoDespesa();

                regTD.IdTipoDespesa = Convert.ToInt16(txtId.Text);
                regTD.NomeDespesa = txtNomeTipoDespesa.Text;

                if (regTD.Excluir() > 0)
                {
                    MessageBox.Show("Tipo de despesa excluída com sucesso!");
                    dsTipoDesesa.Tables.Clear();
                    dsTipoDesesa.Tables.Add(regTD.Listar());
                    bnTipoDespesa.DataSource = dsTipoDesesa.Tables["TIPODESPESA"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir tipo da despesa!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeTipoDespesa.Text == "")
            {
                MessageBox.Show("O campo nome da despesa não pode estar vazio!");
            }
           else
            {
                TipoDespesa regTD = new TipoDespesa();

                regTD.IdTipoDespesa = Convert.ToInt16(txtId.Text);
                regTD.NomeDespesa = txtNomeTipoDespesa.Text;

                if (bInclusao)
                {
                    if (regTD.Salvar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa adicionada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNomeTipoDespesa.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsTipoDesesa.Tables.Clear();
                        dsTipoDesesa.Tables.Add(regTD.Listar());
                        bnTipoDespesa.DataSource = dsTipoDesesa.Tables["TIPODESPESA"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    if (regTD.Alterar() > 0)
                    {
                        MessageBox.Show("Tipo de despesa alterada com sucesso!");

                        dsTipoDesesa.Tables.Clear();
                        dsTipoDesesa.Tables.Add(regTD.Listar());
                        txtId.Enabled = false;
                        txtNomeTipoDespesa.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar tipo de despesa!");
                    }
                }
            }
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbTipoDespesa.SelectedIndex == 0)
            {
                tbTipoDespesa.SelectTab(1);
            }

            txtNomeTipoDespesa.Enabled = true;
            txtNomeTipoDespesa.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnTipoDespesa.CancelEdit();

            btnSalvar.Enabled = false;
            txtNomeTipoDespesa.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
