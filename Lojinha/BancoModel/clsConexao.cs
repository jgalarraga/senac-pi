using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BancoModel
{
    public class clsConexao
    {
        public static SqlConnection Conectar()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.UserID = "TSI";
            sb.Password = "SistemasInternet123";
            sb.DataSource = "foxtrot-pi.database.windows.net";
            sb.InitialCatalog = "foxtrot";

            SqlConnection cn = new SqlConnection(sb.ConnectionString);
            try
            {
                cn.Open();
            } catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Falha na conexão com o banco! Tente novamente.");
            }
            return cn;
        }
    }
}
