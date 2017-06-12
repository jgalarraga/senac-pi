using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace BancoModel
{
    public class clsCategoria
    {
        public int idCategoria { get; set; }
        public string nomeCategoria { get; set; }
        public string descCategoria { get; set; }

        //Faz desse objeto um Singleton
        private static clsCategoria referencia;

        public static clsCategoria getInstance()
        {
            if (referencia == null)
                referencia = new clsCategoria();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idCategoria == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Categoria " +
                                "(nomeCategoria, descCategoria)" +
                                "VALUES " +
                                "(@nomeCategoria, @descCategoria)";
            else
            {
                cmd.CommandText = "UPDATE Categoria " +
                                    "SET nomeCategoria = @nomeCategoria, " +
                                    "descCategoria = @descCategoria " +
                                    "WHERE idCategoria = @idCategoria";

                cmd.Parameters.Add("idCategoria", SqlDbType.Int).Value = idCategoria;
            }

            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = this.nomeCategoria;
            cmd.Parameters.Add("@descCategoria", SqlDbType.VarChar, 50).Value = this.descCategoria;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idCategoria = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsCategoria> SelecionarCategorias()
        {
            string sql = "SELECT idCategoria, nomeCategoria, descCategoria FROM dbo.Categoria ";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCategoria> Categorias = new List<clsCategoria>();
            while (dr.Read())
            {
                clsCategoria C = new clsCategoria();
                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }
                Categorias.Add(C);
            }

            return Categorias;
        }


        public static List<clsCategoria> SelecionarCategorias(int idCategoria)
        {
            string sql = "SELECT idCategoria, nomeCategoria, descCategoria FROM dbo.Categoria " + 
                "WHERE idCategoria = @idCategoria";
            
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCategoria> Categorias = new List<clsCategoria>();
            while (dr.Read())
            {
                clsCategoria C = new clsCategoria();
                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }
                Categorias.Add(C);
            }

            return Categorias;
        }

        public void Excluir()
        {
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "Delete from Categoria " +
                                    "WHERE idCategoria = @idCategoria";

            cmd.Parameters.Add("idCategoria", SqlDbType.Int).Value = idCategoria;

            cmd.ExecuteNonQuery();
          
            cn.Close();
            cn.Dispose();
        }

        public static List<clsCategoria> SelecionarCategorias(string filtro, string pesquisarTxt)
        {
            List<clsCategoria> Categorias = new List<clsCategoria>();
            string sql = "SELECT idCategoria, nomeCategoria, descCategoria FROM dbo.Categoria ";

            if(filtro.Equals("Nome"))
            {
                sql += "WHERE Categoria.nomeCategoria LIKE @field";
            } else
            {
                sql += "WHERE Categoria.descCategoria LIKE @field";
            }

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@field", "%" + pesquisarTxt + "%");

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsCategoria C = new clsCategoria();
                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }
                Categorias.Add(C);
            }

            return Categorias;
        }

    }
}
