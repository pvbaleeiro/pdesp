using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class Despesa
    {
        /* Propriedades */
        private int idDespesa;
        private TipoDespesa tipoDespesa;
        private Membro membro;
        private DateTime dataDespesa;
        private String observacoes;
        private Double valorDespesa;

        /* Construtor */
        public Despesa()
        {
            tipoDespesa = new TipoDespesa();
            membro = new Membro();
        }

        /* Getters e Setters */
        public int IdDespesa
        {
            get { return idDespesa; }
            set { idDespesa = value; }
        }

        public TipoDespesa TipoDespesa
        {
            get { return tipoDespesa; }
            set { tipoDespesa = value; }
        }

        public Membro Membro
        {
            get { return membro; }
            set { membro = value; }
        }

        public DateTime DataDespesa
        {
            get { return dataDespesa; }
            set { dataDespesa = value; }
        }

        public Double ValorDespesa
        {
            get { return valorDespesa; }
            set { valorDespesa = value; }
        }

        public String Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        /* Métodos */
        public DataTable Listar()
        {
            SqlDataAdapter daDespesa;
            DataTable dtDespesa = new DataTable();

            try
            {
                daDespesa = new SqlDataAdapter("SELECT * FROM DESPESA", frmPrincipal.conexao);
                daDespesa.Fill(dtDespesa);
                daDespesa.FillSchema(dtDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtDespesa;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO DESPESA VALUES (@TIPODESPESA_ID_TIPODESPESA, @MEMBRO_ID_MEMBRO, @DATA_DESPESA, @VALOR_DESPESA, @OBS_DESPESA)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@TIPODESPESA_ID_TIPODESPESA", SqlDbType.Int));
                mycommand.Parameters["@TIPODESPESA_ID_TIPODESPESA"].Value = tipoDespesa.IdTipoDespesa;
                mycommand.Parameters.Add(new SqlParameter("@MEMBRO_ID_MEMBRO", SqlDbType.Int));
                mycommand.Parameters["@MEMBRO_ID_MEMBRO"].Value = membro.IdMembro;
                mycommand.Parameters.Add(new SqlParameter("@DATA_DESPESA", SqlDbType.DateTime));
                mycommand.Parameters["@DATA_DESPESA"].Value = dataDespesa;
                mycommand.Parameters.Add(new SqlParameter("@VALOR_DESPESA", SqlDbType.Decimal));
                mycommand.Parameters["@VALOR_DESPESA"].Value = valorDespesa;
                mycommand.Parameters.Add(new SqlParameter("@OBS_DESPESA", SqlDbType.VarChar));
                mycommand.Parameters["@OBS_DESPESA"].Value = observacoes;
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
                mycommand = new SqlCommand("UPDATE DESPESA SET TIPODESPESA_ID_TIPODESPESA = @TIPODESPESA_ID_TIPODESPESA, MEMBRO_ID_MEMBRO = @MEMBRO_ID_MEMBRO, DATA_DESPESA = @DATA_DESPESA, VALOR_DESPESA = @VALOR_DESPESA, OBS_DESPESA = @OBS_DESPESA WHERE ID_DESPESA = @ID_DESPESA", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@TIPODESPESA_ID_TIPODESPESA", SqlDbType.Int));
                mycommand.Parameters["@TIPODESPESA_ID_TIPODESPESA"].Value = tipoDespesa.IdTipoDespesa;
                mycommand.Parameters.Add(new SqlParameter("@MEMBRO_ID_MEMBRO", SqlDbType.Int));
                mycommand.Parameters["@MEMBRO_ID_MEMBRO"].Value = membro.IdMembro;
                mycommand.Parameters.Add(new SqlParameter("@DATA_DESPESA", SqlDbType.DateTime));
                mycommand.Parameters["@DATA_DESPESA"].Value = dataDespesa;
                mycommand.Parameters.Add(new SqlParameter("@VALOR_DESPESA", SqlDbType.Decimal));
                mycommand.Parameters["@VALOR_DESPESA"].Value = valorDespesa;
                mycommand.Parameters.Add(new SqlParameter("@OBS_DESPESA", SqlDbType.VarChar));
                mycommand.Parameters["@OBS_DESPESA"].Value = observacoes;
                mycommand.Parameters.Add(new SqlParameter("@ID_DESPESA", SqlDbType.Int));
                mycommand.Parameters["@ID_DESPESA"].Value = idDespesa;

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

                mycommand = new SqlCommand("DELETE FROM DESPESA WHERE ID_DESPESA = @ID_DESPESA", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ID_DESPESA", SqlDbType.Int));
                mycommand.Parameters["@ID_DESPESA"].Value = Convert.ToInt16(idDespesa);

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
                mycommand = new SqlCommand("SELECT IDENT_CURRENT('DESPESA') + IDENT_INCR('DESPESA') AS NEXT_IDENTIFIER", frmPrincipal.conexao);

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
