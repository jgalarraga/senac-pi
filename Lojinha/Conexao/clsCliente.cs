using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Conexao
{
    class clsCliente
    {
        public int idCliente { get; set; }
        public string nomeCompletoCliente { get; set; }
        public string emailCliente { get; set; }
        public string senhaCliente { get; set; }
        public string cpfCliente { get; set; }
        public string celularCliente { get; set; }
        public string telComercialCliente { get; set; }
        public string telResidencialCliente { get; set; }
        public DateTime dtNascCliente { get; set; }
        public bool recebeNewsLetter { get; set; }

        //Faz desse objeto um Singleton
        private static clsCliente referencia;

        public static clsCliente getInstance()
        {
            if (referencia == null)
                referencia = new clsCliente();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idCliente == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Cliente " +
                                "(nomeCompletoCliente, emailCliente, senhaCliente, CPFCliente, celularCliente, telComercialCliente, telResidencialCliente, dtNascCliente, recebeNewsLetter)" +
                                "VALUES " +
                                "(@nomeCompletoCliente, @emailCliente, @senhaCliente, @CPFCliente, @celularCliente, @telComercialCliente, @telResidencialCliente, @dtNascCliente, @recebeNewsLetter)";
            else
            {
                cmd.CommandText = "UPDATE Cliente " +
                                    "SET nomeCompletoCliente = @nomeCompletoCliente, " +
                                    "emailCliente = @emailCliente, " +
                                    "senhaCliente = @senhaCliente, " +
                                    "CPFCliente = @CPFCliente, " +
                                    "celularCliente = @celularCliente, " +
                                    "telComercialCliente = @telComercialCliente, " +
                                    "telResidencialCliente = @telResidencialCliente, " +
                                    "dtNascCliente = @dtNascCliente, " +
                                    "recebeNewsLetter = @recebeNewsLetter " +
                                    "WHERE idCliente = @idCliente";

                cmd.Parameters.Add("idCliente", SqlDbType.Int).Value = idCliente;
            }

            cmd.Parameters.Add("@nomeCompletoCliente", SqlDbType.VarChar, 50).Value = this.nomeCompletoCliente;
            cmd.Parameters.Add("@emailCliente", SqlDbType.VarChar, 50).Value = this.emailCliente;
            cmd.Parameters.Add("@senhaCliente", SqlDbType.VarChar, 50).Value = this.senhaCliente;
            cmd.Parameters.Add("@CPFCliente", SqlDbType.VarChar, 50).Value = this.cpfCliente;
            cmd.Parameters.Add("@celularCliente", SqlDbType.VarChar, 50).Value = this.celularCliente;
            cmd.Parameters.Add("@telComercialCliente", SqlDbType.VarChar, 50).Value = this.telComercialCliente;
            cmd.Parameters.Add("@telResidencialCliente", SqlDbType.VarChar, 50).Value = this.telResidencialCliente;
            cmd.Parameters.Add("@dtNascCliente", SqlDbType.DateTime).Value = this.dtNascCliente;
            cmd.Parameters.Add("@recebeNewsLetter", SqlDbType.Bit).Value = recebeNewsLetter;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsCliente> SelecionarClientes()
        {
            string sql = "SELECT idCliente, nomeCompletoCliente, emailCliente, senhaCliente, CPFCliente, celularCliente, telComercialCliente, telResidencialCliente, dtNascCliente, recebeNewsLetter FROM dbo.Cliente";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCliente> Clientes = new List<clsCliente>();
            while (dr.Read())
            {
                clsCliente C = new clsCliente();
                C.idCliente = dr.GetInt32(dr.GetOrdinal("idCliente"));
                C.nomeCompletoCliente = dr.GetString(dr.GetOrdinal("nomeCompletoCliente"));
                C.emailCliente = dr.GetString(dr.GetOrdinal("emailCliente"));
                C.senhaCliente = dr.GetString(dr.GetOrdinal("senhaCliente"));
                C.cpfCliente = dr.GetString(dr.GetOrdinal("CPFCliente"));
                C.celularCliente = dr.GetString(dr.GetOrdinal("celularCliente"));
                if (!dr.IsDBNull(dr.GetOrdinal("telComercialCliente")))
                {
                    C.telComercialCliente = dr.GetString(dr.GetOrdinal("telComercialCliente"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("telResidencialCliente")))
                {
                    C.telResidencialCliente = dr.GetString(dr.GetOrdinal("telResidencialCliente"));
                }
                C.dtNascCliente = dr.GetDateTime(dr.GetOrdinal("dtNascCliente"));
                C.recebeNewsLetter = dr.GetBoolean(dr.GetOrdinal("recebeNewsLetter"));
                Clientes.Add(C);
            }

            return Clientes;
        }

        public static List<clsCliente> SelecionarClientes(int idCliente)
        {
            string sql = "SELECT idCliente, nomeCompletoCliente, emailCliente, senhaCliente, CPFCliente, celularCliente, telComercialCliente, telResidencialCliente, dtNascCliente, recebeNewsLetter FROM dbo.Cliente " +
                "WHERE idCliente = @idCliente";

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCliente> Clientes = new List<clsCliente>();
            while (dr.Read())
            {
                clsCliente C = new clsCliente();
                C.idCliente = dr.GetInt32(dr.GetOrdinal("idCliente"));
                C.nomeCompletoCliente = dr.GetString(dr.GetOrdinal("nomeCompletoCliente"));
                C.emailCliente = dr.GetString(dr.GetOrdinal("emailCliente"));
                C.senhaCliente = dr.GetString(dr.GetOrdinal("senhaCliente"));
                C.cpfCliente = dr.GetString(dr.GetOrdinal("CPFCliente"));
                C.celularCliente = dr.GetString(dr.GetOrdinal("celularCliente"));
                if (!dr.IsDBNull(dr.GetOrdinal("telComercialCliente")))
                {
                    C.telComercialCliente = dr.GetString(dr.GetOrdinal("telComercialCliente"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("telResidencialCliente")))
                {
                    C.telResidencialCliente = dr.GetString(dr.GetOrdinal("telResidencialCliente"));
                }
                C.dtNascCliente = dr.GetDateTime(dr.GetOrdinal("dtNascCliente"));
                C.recebeNewsLetter = dr.GetBoolean(dr.GetOrdinal("recebeNewsLetter"));
                Clientes.Add(C);
            }

            return Clientes;
        }

    }
}
