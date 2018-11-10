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
    public partial class frmMembro : Form
    {
        private BindingSource bnMembro = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsMembro = new DataSet();


        public frmMembro()
        {
            InitializeComponent();
        }

        private void frmMembro_Load(object sender, EventArgs e)
        {
            try
            {
                Membro membro = new Membro();
                dsMembro.Tables.Add(membro.Listar());
                bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
                dgvMembro.DataSource = bnMembro;
                bnvMembro.BindingSource = bnMembro;

                txtId.DataBindings.Add("TEXT", bnMembro, "ID_MEMBRO");
                txtNome.DataBindings.Add("TEXT", bnMembro, "NOME_MEMBRO");
                txtPapel.DataBindings.Add("TEXT", bnMembro, "PAPEL_MEMBRO");
                dgvMembro.Columns[0].HeaderText = "ID";
                dgvMembro.Columns[1].HeaderText = "Nome";
                dgvMembro.Columns[2].HeaderText = "Papel";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbMembro.SelectedIndex == 0)
            {
                tbMembro.SelectTab(1);
            }

            bnMembro.AddNew();
            txtNome.Enabled = true;
            txtNome.Focus();
            txtPapel.Enabled = true;
            Membro membro = new Membro();
            txtId.Text = membro.NextIdentifier().ToString();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbMembro.SelectedIndex == 0)
            {
                tbMembro.SelectTab(1);
            }

            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Membro regM = new Membro();

                regM.IdMembro = Convert.ToInt16(txtId.Text);
                regM.NomeMembro = txtNome.Text;
                regM.PapelMembro = txtPapel.Text;

                if (regM.Excluir() > 0)
                {
                    MessageBox.Show("Membro excluído com sucesso!");
                    dsMembro.Tables.Clear();
                    dsMembro.Tables.Add(regM.Listar());
                    bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir membro!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNome.Text == "" || txtPapel.Text == "")
            {
                MessageBox.Show("Os campos nome e papel não podem estar vazios!");
            }
            else
            {
                Membro regM = new Membro();
                regM.IdMembro = Convert.ToInt16(txtId.Text);
                regM.NomeMembro = txtNome.Text;
                regM.PapelMembro = txtPapel.Text;

                if (bInclusao)
                {
                    if (regM.Salvar() > 0)
                    {
                        MessageBox.Show("Membro adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        txtPapel.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(regM.Listar());
                        bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }
                }
                else
                {
                    if (regM.Alterar() > 0)
                    {
                        MessageBox.Show("Membro alterado com sucesso!");

                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(regM.Listar());
                        txtId.Enabled = false;
                        txtNome.Enabled = false;
                        txtPapel.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar membro!");
                    }
                }
            }
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbMembro.SelectedIndex == 0)
            {
                tbMembro.SelectTab(1);
            }

            txtNome.Enabled = true;
            txtNome.Focus();
            txtPapel.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnMembro.CancelEdit();

            btnSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtPapel.Enabled = false;
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
