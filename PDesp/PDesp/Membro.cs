using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class Membro
    {
        /* Propriedades */
        private int idMembro;
        private string nomeMembro;
        private string papelMembro;

        /* Getters e Setters */
        public int IdMembro
        {
            get { return idMembro; }
            set { idMembro = value; }
        }

        public string NomeMembro
        {
            get { return nomeMembro; }
            set { nomeMembro = value; }
        }

        public string PapelMembro
        {
            get { return papelMembro; }
            set { papelMembro = value; }
        }

        /* Métodos */
        public DataTable Listar()
        {
            SqlDataAdapter daMembro;
            DataTable dtMembro = new DataTable();

            try
            {
                daMembro = new SqlDataAdapter("SELECT * FROM MEMBRO", frmPrincipal.conexao);
                daMembro.Fill(dtMembro);
                daMembro.FillSchema(dtMembro, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtMembro;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO MEMBRO VALUES (@NOME_MEMBRO, @PAPEL_MEMBRO)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@NOME_MEMBRO", SqlDbType.VarChar));
                mycommand.Parameters["@NOME_MEMBRO"].Value = nomeMembro;
                mycommand.Parameters.Add(new SqlParameter("@PAPEL_MEMBRO", SqlDbType.VarChar));
                mycommand.Parameters["@PAPEL_MEMBRO"].Value = papelMembro;
                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE MEMBRO SET NOME_MEMBRO = @NOME_MEMBRO, PAPEL_MEMBRO = @PAPEL_MEMBRO WHERE ID_MEMBRO = @ID_MEMBRO", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@NOME_MEMBRO", SqlDbType.VarChar));
                mycommand.Parameters["@NOME_MEMBRO"].Value = nomeMembro;
                mycommand.Parameters.Add(new SqlParameter("@PAPEL_MEMBRO", SqlDbType.VarChar));
                mycommand.Parameters["@PAPEL_MEMBRO"].Value = papelMembro;
                mycommand.Parameters.Add(new SqlParameter("@ID_MEMBRO", SqlDbType.Int));
                mycommand.Parameters["@ID_MEMBRO"].Value = idMembro;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }


        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM MEMBRO WHERE ID_MEMBRO = @ID_MEMBRO", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ID_MEMBRO", SqlDbType.Int));
                mycommand.Parameters["@ID_MEMBRO"].Value = Convert.ToInt16(idMembro);

                nReg = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }
    }
}
