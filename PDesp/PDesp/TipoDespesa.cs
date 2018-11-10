using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class TipoDespesa
    {
        /* Propriedades */
        private int idTipoDespesa;
        private string nomeDespesa;

        /* Getters e Setters */
        public int IdTipoDespesa
        {
            get { return idTipoDespesa; }
            set { idTipoDespesa = value; }
        }

        public string NomeDespesa
        {
            get { return nomeDespesa; }
            set { nomeDespesa = value; }
        }

        /* Métodos */
        public DataTable Listar()
        {
            SqlDataAdapter daTipoDespesa;

            DataTable dtTipoDespesa = new DataTable();

            try
            {
                daTipoDespesa = new SqlDataAdapter("SELECT * FROM TIPODESPESA", frmPrincipal.conexao);
                daTipoDespesa.Fill(dtTipoDespesa);
                daTipoDespesa.FillSchema(dtTipoDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtTipoDespesa;
        }



        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TIPODESPESA VALUES (@NOME_TIPODESPESA)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@NOME_TIPODESPESA", SqlDbType.VarChar));
                mycommand.Parameters["@NOME_TIPODESPESA"].Value = nomeDespesa;

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
                mycommand = new SqlCommand("UPDATE TIPODESPESA SET NOME_TIPODESPESA = @NOME_TIPODESPESA WHERE ID_TIPODESPESA = @ID_TIPODESPESA", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@NOME_TIPODESPESA", SqlDbType.VarChar));
                mycommand.Parameters["@NOME_TIPODESPESA"].Value = nomeDespesa;
                mycommand.Parameters.Add(new SqlParameter("@ID_TIPODESPESA", SqlDbType.Int));
                mycommand.Parameters["@ID_TIPODESPESA"].Value = idTipoDespesa;

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

                mycommand = new SqlCommand("DELETE FROM TIPODESPESA WHERE ID_TIPODESPESA = @ID_TIPODESPESA", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ID_TIPODESPESA", SqlDbType.Int));
                mycommand.Parameters["@ID_TIPODESPESA"].Value = Convert.ToInt16(idTipoDespesa);

                nReg = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }

        public int NextIdentifier()
        {
            int nextIdentifier = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("SELECT IDENT_CURRENT('TIPODESPESA') + IDENT_INCR('TIPODESPESA') AS NEXT_IDENTIFIER", frmPrincipal.conexao);

                // Executando o commando e obtendo o resultado
                nextIdentifier = Convert.ToInt32(mycommand.ExecuteScalar());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return nextIdentifier;
        }
    }
}
