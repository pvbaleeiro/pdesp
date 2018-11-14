using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDesp
{
    public partial class frmDespesa : Form
    {
        private BindingSource bnDespesa = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsDespesa = new DataSet();
        private DataSet dsTipoDespesa = new DataSet();
        private DataSet dsMembro = new DataSet();

        public frmDespesa()
        {
            InitializeComponent();
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            try
            {
                Despesa despesa = new Despesa();
                dsDespesa.Tables.Add(despesa.Listar());
                bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];
                dgvDespesa.DataSource = bnDespesa;
                bnvDespesa.BindingSource = bnDespesa;


                //txtId.DataBindings.Add("TEXT", bnTipoDespesa, "ID_TIPODESPESA");
                //txtNomeTipoDespesa.DataBindings.Add("TEXT", bnTipoDespesa, "NOME_TIPODESPESA");
                dgvDespesa.Columns[0].HeaderText = "ID";
                dgvDespesa.Columns[1].HeaderText = "Nome";
                dgvDespesa.Columns[2].HeaderText = "ID Membro";
                dgvDespesa.Columns[3].HeaderText = "Data";
                dgvDespesa.Columns[4].HeaderText = "Valor";
                dgvDespesa.Columns[5].HeaderText = "Observações";

                // Carregando drop down list de tipos despesa e membros
                TipoDespesa tipoDespesa = new TipoDespesa();
                dsTipoDespesa.Tables.Add(tipoDespesa.Listar());
                cbxTipoDespesa.DisplayMember = "NOME_TIPODESPESA";
                cbxTipoDespesa.ValueMember = "NOME_TIPODESPESA";
                cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];

                Membro membro = new Membro();
                dsMembro.Tables.Add(membro.Listar());
                cbxMembro.DisplayMember = "NOME_MEMBRO";
                cbxMembro.ValueMember = "NOME_MEMBRO";
                cbxMembro.DataSource = dsMembro.Tables["MEMBRO"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Detalhes_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbDespesa.SelectedIndex == 0)
            {
                tbDespesa.SelectTab(1);
            }

            bnDespesa.AddNew();
            mtxtValor.Enabled = true;
            mtxtValor.Focus();
            txtObservacao.Enabled = true;
            Despesa despesa = new Despesa();
            txtId.Text = despesa.NextIdentifier().ToString();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbDespesa.SelectedIndex == 0)
            {
                tbDespesa.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Despesa regD = new Despesa();
                //regD.IdMembro = Convert.ToInt16(txtId.Text);
                //regD.NomeMembro = txtNome.Text;
                //regD.PapelMembro = txtPapel.Text;

                //if (regM.Excluir() > 0)
                //{
                //    MessageBox.Show("Membro excluído com sucesso!");
                //    dsMembro.Tables.Clear();
                //    dsMembro.Tables.Add(regM.Listar());
                //    bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
                //}
                //else
                //{
                //    MessageBox.Show("Erro ao excluir membro!");
                //}
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            //if (txtNome.Text == "" || txtPapel.Text == "")
            //{
            //    MessageBox.Show("Os campos nome e papel não podem estar vazios!");
            //}
            //else
            //{
            //    Membro regM = new Membro();
            //    regM.IdMembro = Convert.ToInt16(txtId.Text);
            //    regM.NomeMembro = txtNome.Text;
            //    regM.PapelMembro = txtPapel.Text;

            //    if (bInclusao)
            //    {
            //        if (regM.Salvar() > 0)
            //        {
            //            MessageBox.Show("Membro adicionado com sucesso!");

            //            btnSalvar.Enabled = false;
            //            txtId.Enabled = false;
            //            txtNome.Enabled = false;
            //            txtPapel.Enabled = false;
            //            btnSalvar.Enabled = false;
            //            btnAlterar.Enabled = true;
            //            btnNovoRegistro.Enabled = true;
            //            btnExcluir.Enabled = true;
            //            btnCancelar.Enabled = false;

            //            bInclusao = false;

            //            // recarrega o grid
            //            dsMembro.Tables.Clear();
            //            dsMembro.Tables.Add(regM.Listar());
            //            bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
            //        }
            //        else
            //        {
            //            MessageBox.Show("Erro ao gravar membro!");
            //        }
            //    }
            //    else
            //    {
            //        if (regM.Alterar() > 0)
            //        {
            //            MessageBox.Show("Membro alterado com sucesso!");

            //            dsMembro.Tables.Clear();
            //            dsMembro.Tables.Add(regM.Listar());
            //            txtId.Enabled = false;
            //            txtNome.Enabled = false;
            //            txtPapel.Enabled = false;
            //            btnSalvar.Enabled = false;
            //            btnAlterar.Enabled = true;
            //            btnNovoRegistro.Enabled = true;
            //            btnExcluir.Enabled = true;
            //            btnCancelar.Enabled = false;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Erro ao gravar membro!");
            //        }
            //    }
            //}
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //if (tbMembro.SelectedIndex == 0)
            //{
            //    tbMembro.SelectTab(1);
            //}

            //txtNome.Enabled = true;
            //txtNome.Focus();
            //txtPapel.Enabled = true;
            //btnSalvar.Enabled = true;
            //btnAlterar.Enabled = false;
            //btnNovoRegistro.Enabled = false;
            //btnExcluir.Enabled = false;
            //btnCancelar.Enabled = true;
            //bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //bnMembro.CancelEdit();

            //btnSalvar.Enabled = false;
            //txtNome.Enabled = false;
            //txtPapel.Enabled = false;
            //btnAlterar.Enabled = true;
            //btnNovoRegistro.Enabled = true;
            //btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnvDespesa_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
