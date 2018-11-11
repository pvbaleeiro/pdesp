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
                conexao = new SqlConnection("Data Source=DESKTOP-PKET4KJ;Initial Catalog=master;Integrated Security=True");
                //conexao = new SqlConnection("Data Source=PROFDENILCE"+"'\'"+"SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                //conexao = new SqlConnection("Data Source=apolo;Initial Catalog=LP2;User ID=bd1813003;Password=060588Vi"); 
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
            frmTipoDespesa frmTD = new frmTipoDespesa();
            frmTD.MdiParent = this;
            frmTD.WindowState = FormWindowState.Maximized;
            frmTD.Show();
        }

        private void membrosDaFamíliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembro frmM = new frmMembro();
            frmM.MdiParent = this;
            frmM.WindowState = FormWindowState.Maximized;
            frmM.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesa frmD = new frmDespesa();
            frmD.MdiParent = this;
            frmD.WindowState = FormWindowState.Maximized;
            frmD.Show();
        }
    }
}
