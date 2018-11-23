using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class SQLUtil
    {
        #region Propriedades
        private static SQLUtil instance;
        #endregion

        #region Construtor
        private SQLUtil() { }
        #endregion

        #region Acesso singleton
        public static SQLUtil Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLUtil();
                }

                return instance;
            }
        }
        #endregion

        #region Métodos
        public int NextIdentifier(String table)
        {
            int nextIdentifier = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("SELECT IDENT_CURRENT('" + table + "') + IDENT_INCR('" + table + "') AS NEXT_IDENTIFIER", frmPrincipal.conexao);

                // Executando o commando e obtendo o resultado
                nextIdentifier = Convert.ToInt32(mycommand.ExecuteScalar());
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return nextIdentifier;
        }
        #endregion
    }
}
