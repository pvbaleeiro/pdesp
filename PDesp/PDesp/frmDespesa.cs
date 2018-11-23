using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            AplicarEventos(txtValorDespesa);
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

                if (dgvDespesa.Columns.Count > 0) {
                    dgvDespesa.Columns[0].HeaderText = "ID";
                    dgvDespesa.Columns[1].HeaderText = "ID Tipo Despesa";
                    dgvDespesa.Columns[2].HeaderText = "ID Membro";
                    dgvDespesa.Columns[3].HeaderText = "Data";
                    dgvDespesa.Columns[4].HeaderText = "Valor";
                    dgvDespesa.Columns[5].HeaderText = "Observações";
                }

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

                txtId.DataBindings.Add("TEXT", bnDespesa, "ID_DESPESA");
                txtValorDespesa.DataBindings.Add("TEXT", bnDespesa, "VALOR_DESPESA");
                txtObservacao.DataBindings.Add("TEXT", bnDespesa, "OBS_DESPESA");
                mskData.DataBindings.Add("TEXT", bnDespesa, "DATA_DESPESA");
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
            cbxMembro.Enabled = true;
            cbxTipoDespesa.Enabled = true;
            txtValorDespesa.Enabled = true;
            txtValorDespesa.Focus();
            aplicaMascara(txtValorDespesa);
            txtValorDespesa.DataBindings.Clear();
            mskData.Enabled = true;
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
                Despesa regD = new Despesa();
                regD.IdDespesa = Convert.ToInt16(txtId.Text);
               
                if (regD.Excluir() > 0)
                {
                    MessageBox.Show("Despesa excluída com sucesso!");
                    dsDespesa.Tables.Clear();
                    dsDespesa.Tables.Add(regD.Listar());
                    bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];

                    TipoDespesa tipoDespesa = new TipoDespesa();
                    dsTipoDespesa.Tables.Clear();
                    dsTipoDespesa.Tables.Add(tipoDespesa.Listar());
                    cbxTipoDespesa.DisplayMember = "NOME_TIPODESPESA";
                    cbxTipoDespesa.ValueMember = "NOME_TIPODESPESA";
                    cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];

                    Membro membro = new Membro();
                    dsMembro.Tables.Clear();
                    dsMembro.Tables.Add(membro.Listar());
                    cbxMembro.DisplayMember = "NOME_MEMBRO";
                    cbxMembro.ValueMember = "NOME_MEMBRO";
                    cbxMembro.DataSource = dsMembro.Tables["MEMBRO"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir despesa!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtValorDespesa.Text == "" || txtObservacao.Text == "" || mskData.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else
            {
                Despesa regD = new Despesa();
                regD.IdDespesa = Convert.ToInt16(txtId.Text);
                string tipoDespesaNome = (string)cbxTipoDespesa.Text;
                foreach (DataTable table in dsTipoDespesa.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        string tipoDespesaNomeComboBox = (string)dr["NOME_TIPODESPESA"];
                        if (tipoDespesaNome.Equals(tipoDespesaNomeComboBox))
                        {
                            int idTipoDespesa = (int)dr["ID_TIPODESPESA"];
                            regD.TipoDespesa.IdTipoDespesa = idTipoDespesa;
                            break;
                        }
                    }
                }

                string membroNome = (string)cbxMembro.Text;
                foreach (DataTable table in dsMembro.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        string membroNomeComboBox = (string)dr["NOME_MEMBRO"];
                        if (membroNome.Equals(membroNomeComboBox))
                        {
                            int idMembro = (int)dr["ID_MEMBRO"];
                            regD.Membro.IdMembro = idMembro;
                            break;
                        }
                    }
                }

                Double dValor = Double.Parse(txtValorDespesa.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, new CultureInfo("pt-BR"));
                regD.ValorDespesa = dValor;
                regD.DataDespesa = Convert.ToDateTime(mskData.Text);
                regD.Observacoes = txtObservacao.Text;

                if (bInclusao)
                {
                    if (regD.Salvar() > 0)
                    {
                        MessageBox.Show("Despesa adicionada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        cbxMembro.Enabled = false;
                        cbxTipoDespesa.Enabled = false;
                        txtObservacao.Enabled = false;
                        txtValorDespesa.Enabled = false;
                        mskData.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(regD.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];

                        TipoDespesa tipoDespesa = new TipoDespesa();
                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(tipoDespesa.Listar());
                        cbxTipoDespesa.DisplayMember = "NOME_TIPODESPESA";
                        cbxTipoDespesa.ValueMember = "NOME_TIPODESPESA";
                        cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];

                        Membro membro = new Membro();
                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(membro.Listar());
                        cbxMembro.DisplayMember = "NOME_MEMBRO";
                        cbxMembro.ValueMember = "NOME_MEMBRO";
                        cbxMembro.DataSource = dsMembro.Tables["MEMBRO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar despesa!");
                    }
                }
                else
                {
                    if (regD.Alterar() > 0)
                    {
                        MessageBox.Show("Despesa alterada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        cbxMembro.Enabled = false;
                        cbxTipoDespesa.Enabled = false;
                        mskData.Enabled = false;
                        txtValorDespesa.Enabled = false;
                        txtObservacao.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsDespesa.Tables.Clear();
                        dsDespesa.Tables.Add(regD.Listar());
                        bnDespesa.DataSource = dsDespesa.Tables["DESPESA"];

                        TipoDespesa tipoDespesa = new TipoDespesa();
                        dsTipoDespesa.Tables.Clear();
                        dsTipoDespesa.Tables.Add(tipoDespesa.Listar());
                        cbxTipoDespesa.DisplayMember = "NOME_TIPODESPESA";
                        cbxTipoDespesa.ValueMember = "NOME_TIPODESPESA";
                        cbxTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];

                        Membro membro = new Membro();
                        dsMembro.Tables.Clear();
                        dsMembro.Tables.Add(membro.Listar());
                        cbxMembro.DisplayMember = "NOME_MEMBRO";
                        cbxMembro.ValueMember = "NOME_MEMBRO";
                        cbxMembro.DataSource = dsMembro.Tables["MEMBRO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar despesa!");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbDespesa.SelectedIndex == 0)
            {
                tbDespesa.SelectTab(1);
            }

            cbxMembro.Enabled = true;
            cbxTipoDespesa.Enabled = true;
            mskData.Enabled = true;
            txtValorDespesa.Enabled = true;
            txtValorDespesa.Focus();
            txtObservacao.Enabled = true;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnDespesa.CancelEdit();

            btnSalvar.Enabled = false;
            cbxTipoDespesa.Enabled = false;
            cbxMembro.Enabled = false;
            txtObservacao.Enabled = false;
            mskData.Enabled = false;
            txtValorDespesa.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnvDespesa_RefreshItems(object sender, EventArgs e)
        {
            resolveMudancasComboBox();
        }

        private void dgvDespesa_BindingContextChanged(object sender, EventArgs e)
        {
        }

        private void resolveMudancasComboBox()
        {
            if (dgvDespesa.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvDespesa.Rows[dgvDespesa.SelectedCells[0].RowIndex].Cells[0].OwningRow;
                if (row.Cells["TIPODESPESA_ID_TIPODESPESA"].Value != null)
                {
                    int idTipoDespesa = (int)row.Cells["TIPODESPESA_ID_TIPODESPESA"].Value;
                    int idMembro = (int)row.Cells["MEMBRO_ID_MEMBRO"].Value;

                    foreach (DataTable table in dsTipoDespesa.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            int idTipoDespesaComboBox = (int)dr["ID_TIPODESPESA"];
                            if (idTipoDespesa == idTipoDespesaComboBox)
                            {
                                string nomeTipoDespesa = (string)dr["NOME_TIPODESPESA"];
                                cbxTipoDespesa.SelectedIndex = cbxTipoDespesa.FindStringExact(nomeTipoDespesa);
                                break;
                            }
                        }
                    }

                    foreach (DataTable table in dsMembro.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            int idMembroComboBox = (int)dr["ID_MEMBRO"];
                            if (idMembro == idMembroComboBox)
                            {
                                string nomeMembro = (string)dr["NOME_MEMBRO"];
                                cbxMembro.SelectedIndex = cbxMembro.FindStringExact(nomeMembro);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void KeyUpValor(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            aplicaMascara(txt);
        }

        private void LeaveValor(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            aplicaMascara(txt);
        }

        private void KeyPressValor(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }      
        }

        private void aplicaMascara(TextBox txt)
        {
            string valor = txt.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
            if (valor.Length == 0)
            {
                txt.Text = "0,00" + valor;
            }
            if (valor.Length == 1)
            {
                txt.Text = "0,0" + valor;
            }
            if (valor.Length == 2)
            {
                txt.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt.Text.StartsWith("0,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt.Text.Contains("00,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",");
                }
            }

            valor = txt.Text;
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt.Select(txt.Text.Length, 0);
        }

        private void AplicarEventos(TextBox txt)
        {
            txt.KeyUp += KeyUpValor;
            //txt.Leave += LeaveValor;
            txt.KeyPress += KeyPressValor;
        }
    }
}
