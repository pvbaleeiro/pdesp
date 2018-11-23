using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDesp
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //conexao = new SqlConnection("Data Source=DESKTOP-PKET4KJ;Initial Catalog=master;Integrated Security=True");
                //conexao = new SqlConnection("Data Source=PROFDENILCE"+"'\'"+"SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao = new SqlConnection("Data Source=apolo;Initial Catalog=LP2;User ID=bd1813003;Password=060588Vi"); 
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void tiposDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmTipoDespesa>().Count() == 0)
            {
                frmTipoDespesa frmTD = new frmTipoDespesa();
                frmTD.MdiParent = this;
                frmTD.WindowState = FormWindowState.Maximized;
                frmTD.Show();
            }
            else 
            {
                frmTipoDespesa frmTD = Application.OpenForms.OfType<frmTipoDespesa>().ElementAt(0);
                frmTD.BringToFront();
            }
        }

        private void membrosDaFamíliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMembro>().Count() == 0)
            {
                frmMembro frmM = new frmMembro();
                frmM.MdiParent = this;
                frmM.WindowState = FormWindowState.Maximized;
                frmM.Show();
            }
            else
            {
                frmMembro frmM = Application.OpenForms.OfType<frmMembro>().ElementAt(0);
                frmM.BringToFront();
            }
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SQLUtil.Instance.haMembrosETiposDespesas())
            {
                if (Application.OpenForms.OfType<frmDespesa>().Count() == 0)
                {
                    frmDespesa frmD = new frmDespesa();
                    frmD.MdiParent = this;
                    frmD.WindowState = FormWindowState.Maximized;
                    frmD.Show();
                }
                else
                {
                    frmDespesa frmD = Application.OpenForms.OfType<frmDespesa>().ElementAt(0);
                    frmD.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Para cadastrar uma despesa, você precisa ter pelo menos um Tipo de Despesa e um Membro adicionados!");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() == 0)
            {
                frmSobre frmS = new frmSobre();
                frmS.MdiParent = this;
                frmS.WindowState = FormWindowState.Maximized;
                frmS.Show();
            }
            else
            {
                frmSobre frmS = Application.OpenForms.OfType<frmSobre>().ElementAt(0);
                frmS.BringToFront();
            }
        }

        private void mstrPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
