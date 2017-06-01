using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BancoModel
{
    public class clsUsuario
    {
        public int idUsuario{ get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string tipoPerfil { get; set; }
        // verificar o tipo do campo no sql management studio
        public string usuarioAtivo { get; set; }

        //Faz desse objeto um Singleton
        private static clsUsuario referencia;

        public static clsUsuario getInstance()
        {
            if (referencia == null)
                referencia = new clsUsuario();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idUsuario == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Usuario " +
                                "(loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo)" +
                                "VALUES " +
                                "(@loginUsuario, @senhaUsuario, @nomeUsuario, @tipoPerfil, @usuarioAtivo)";
            else
            {
                cmd.CommandText = "UPDATE Usuario " +
                                    "SET loginUsuario = @loginUsuario, " +
                                    "senhaUsuario = @senhaUsuario, " +
                                    "nomeUsuario = @nomeUsuario, " +
                                    "tipoPerfil = @tipoPerfil, " +
                                    "usuarioAtivo = @usuarioAtivo";

                cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value = idUsuario;
            }

            cmd.Parameters.Add("@loginUsuario", SqlDbType.VarChar, 50).Value = this.loginUsuario;
            cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar, 50).Value = this.senhaUsuario;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar, 50).Value = this.nomeUsuario;
            cmd.Parameters.Add("@tipoPerfil", SqlDbType.VarChar, 50).Value = this.tipoPerfil;
            // verificar o tipo do campo no sql management studio
            cmd.Parameters.Add("@usuarioAtivo", SqlDbType.VarChar, 50).Value = this.usuarioAtivo;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsUsuario> SelecionarUsuarios()
        {
            string sql = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuarios = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                U.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                if (!dr.IsDBNull(dr.GetOrdinal("loginUsuario")))
                {
                    U.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    U.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                }
                U.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                // verificar o tipo do campo tipoPerfil
                U.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                // verificar o tipo do campo usuarioAtivo
                U.usuarioAtivo = dr.GetString(dr.GetOrdinal("usuarioAtivo"));

                Usuarios.Add(U);
            }

            return Usuarios;
        }

        public static List<clsUsuario> SelecionarUsuarios(int idUsuario)
        {
            string sql = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario" + 
                "WHERE idUsuario = @idUsuario";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuarios = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                U.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                if (!dr.IsDBNull(dr.GetOrdinal("loginUsuario")))
                {
                    U.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    U.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                }
                U.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                // verificar o tipo do campo tipoPerfil
                U.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));

                Usuarios.Add(U);
            }

            return Usuarios;
        }

<<<<<<< HEAD
        // RECADO PARA A JU: TRANSFORMAR MÉTODOS EM UMA COISA SÓ! MUITO REPETIVO
        public int validarLogin(string usuario, string senha)
        {
            string sql = "SELECT COUNT(*) FROM Usuario " +
                "WHERE loginUsuario LIKE @usuario AND senhaUsuario LIKE @senha";
=======
        public int validarLogin(string usuario, string senha)
        {
            // aqui eu poderia usar IF EXISTS..(?)
            //int userCount = 0;
            string sql = "SELECT COUNT(*) FROM Usuario WHERE loginUsuario LIKE '"+ usuario +
                "' AND senhaUsuario LIKE '" + senha + "'";
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

<<<<<<< HEAD
            cmd.Parameters.AddWithValue("@usuario", "%" + usuario + "%");
            cmd.Parameters.AddWithValue("@senha", "%" + senha + "%");
=======
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e

            int userCount = (int)cmd.ExecuteScalar();

            // se o usuário for encontrado, o retorno é 1
            // senão, o retorno é 0
            return userCount;
<<<<<<< HEAD
        }

        public string selecionarTipoPerfil(string usuario, string senha)
        {
            string sql = "SELECT tipoPerfil FROM Usuario " +
               "WHERE loginUsuario LIKE @usuario AND senhaUsuario LIKE @senha";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.AddWithValue("@usuario", "%" + usuario + "%");
            cmd.Parameters.AddWithValue("@senha", "%" + senha + "%");

            string perfilUsuario = (string)cmd.ExecuteScalar();

            // retorna "A" para administrador
            // ou diferente da "A" para outro
            // só o adm pode mexer no estoque
            return perfilUsuario;
=======
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
        }
    }
}
