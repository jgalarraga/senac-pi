using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BancoModel
{
    public class clsEndereco
    {
        public int idEndereco { get; set; }
        public int idCliente { get; set; }
        public string nomeEndereco { get; set; }
        public string logradouroEndereco { get; set; }
        public string numeroEndereco { get; set; }
        public string CEPEndereco { get; set; }
        public string complementoEndereco { get; set; }
        public string cidadeEndereco { get; set; }
        public string paisEndereco { get; set; }
        public string UFEndereco { get; set; }
        //Faz desse objeto um Singleton
        private static clsEndereco referencia;

        public static clsEndereco getInstance()
        {
            if (referencia == null)
                referencia = new clsEndereco();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idEndereco == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Endereco " +
                                "(nomeEndereco, logradouroEndereco, numeroEndereco, CEPEndereco, complementoEndereco, cidadeEndereco, paisEndereco, UFEndereco)" +
                                "VALUES " +
                                "(@nomeEndereco, @logradouroEndereco, @numeroEndereco, @CEPEndereco, @complementoEndereco, @cidadeEndereco, @paisEndereco, @UFEndereco)";
            else
            {
                cmd.CommandText = "UPDATE Usuario " +
                                    "SET nomeEndereco = @nomeEndereco, " +
                                    "logradouroEndereco = @logradouroEndereco, " +
                                    "numeroEndereco = @numeroEndereco, " +
                                    "CEPEndereco = @CEPEndereco, " +
                                    "complementoEndereco = @complementoEndereco" +
                                    "cidadeEndereco = @cidadeEndereco" +
                                    "paisEndereco = @paisEndereco" +
                                    "UFEndereco = @UFEndereco";

                cmd.Parameters.Add("idEndereco", SqlDbType.Int).Value = idEndereco;
            }

            cmd.Parameters.Add("@nomeEndereco", SqlDbType.VarChar, 50).Value = this.nomeEndereco;
            cmd.Parameters.Add("@logradouroEndereco", SqlDbType.VarChar, 100).Value = this.logradouroEndereco;
            cmd.Parameters.Add("@numeroEndereco", SqlDbType.VarChar, 10).Value = this.numeroEndereco;
            cmd.Parameters.Add("@CEPEndereco", SqlDbType.Char, 9).Value = this.CEPEndereco;
            cmd.Parameters.Add("@complementoEndereco", SqlDbType.VarChar, 10).Value = this.complementoEndereco;
            cmd.Parameters.Add("@cidadeEndereco", SqlDbType.VarChar, 50).Value = this.cidadeEndereco;
            cmd.Parameters.Add("@paisEndereco", SqlDbType.VarChar, 50).Value = this.paisEndereco;
            cmd.Parameters.Add("@UFEndereco", SqlDbType.Char, 2).Value = this.UFEndereco;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idEndereco = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }
        public static List<clsEndereco> SelecionarEnderecos()
        {
            string sql = "SELECT idEndereco,idCliente, nomeEndereco, logradouroEndereco, numeroEndereco, CEPEndereco, complementoEndereco, cidadeEndereco, paisEndereco, UFEndereco FROM dbo.Endereco";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEndereco> Enderecos = new List<clsEndereco>();
            while (dr.Read())
            {
                clsEndereco E = new clsEndereco();
                E.idEndereco = dr.GetInt32(dr.GetOrdinal("idEndereco"));
                E.idCliente = dr.GetInt32(dr.GetOrdinal("idCliente"));
                E.nomeEndereco = dr.GetString(dr.GetOrdinal("nomeEndereco"));
                E.logradouroEndereco = dr.GetString(dr.GetOrdinal("logradouroEndereco"));
                E.numeroEndereco = dr.GetString(dr.GetOrdinal("numeroEndereco"));
                E.CEPEndereco = dr.GetString(dr.GetOrdinal("CEPEndereco"));
                E.cidadeEndereco = dr.GetString(dr.GetOrdinal("cidadeEndereco"));;
                if (!dr.IsDBNull(dr.GetOrdinal("complementoEndereco")))
                {
                    E.complementoEndereco = dr.GetString(dr.GetOrdinal("complementoEndereco"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("paisEndereco")))
                {
                    E.paisEndereco = dr.GetString(dr.GetOrdinal("paisEndereco"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("UFEndereco")))
                {
                    E.UFEndereco = dr.GetString(dr.GetOrdinal("UFEndereco"));
                }
                Enderecos.Add(E);
            }

            return Enderecos;
        }
        public static List<clsEndereco> SelecionarEnderecos(int id)
        {
            //string sql = "SELECT idEndereco, nomeEndereco, logradouroEndereco, numeroEndereco, CEPEndereco, complementoEndereco, cidadeEndereco, paisEndereco, UFEndereco FROM dbo.Endereco WHERE idCliente = @id";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT idEndereco, nomeEndereco, logradouroEndereco, numeroEndereco, CEPEndereco, complementoEndereco, cidadeEndereco, paisEndereco, UFEndereco FROM dbo.Endereco WHERE idCliente = @id";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEndereco> Enderecos = new List<clsEndereco>();
            while (dr.Read())
            {
                clsEndereco E = new clsEndereco();
                E.idEndereco = dr.GetInt32(dr.GetOrdinal("idEndereco"));
                E.idCliente = dr.GetInt32(dr.GetOrdinal("idCliente"));
                E.nomeEndereco = dr.GetString(dr.GetOrdinal("nomeEndereco"));
                E.logradouroEndereco = dr.GetString(dr.GetOrdinal("logradouroEndereco"));
                E.numeroEndereco = dr.GetString(dr.GetOrdinal("numeroEndereco"));
                E.CEPEndereco = dr.GetString(dr.GetOrdinal("CEPEndereco"));
                E.cidadeEndereco = dr.GetString(dr.GetOrdinal("cidadeEndereco")); ;
                if (!dr.IsDBNull(dr.GetOrdinal("complementoEndereco")))
                {
                    E.complementoEndereco = dr.GetString(dr.GetOrdinal("complementoEndereco"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("paisEndereco")))
                {
                    E.paisEndereco = dr.GetString(dr.GetOrdinal("paisEndereco"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("UFEndereco")))
                {
                    E.UFEndereco = dr.GetString(dr.GetOrdinal("UFEndereco"));
                }
                Enderecos.Add(E);
            }

            return Enderecos;
        }

    }
}
