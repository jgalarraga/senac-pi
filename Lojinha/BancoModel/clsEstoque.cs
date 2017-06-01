<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BancoModel
{
    public class clsEstoque
    {
        public int idProduto { get; set; }
        public int qtdProdutoDisponivel { get; set; }

        public string nomeProduto { get; set; }
        public string nomeCategoria { get; set; }

        //Faz desse objeto um Singleton
        private static clsEstoque referencia;

        public static clsEstoque getInstance()
        {
            if (referencia == null)
                referencia = new clsEstoque();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idProduto == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Estoque " +
                                "(qtdEstoqueDisponivel)" +
                                "VALUES " +
                                "(@qtdProdutoDisponivel)";
            else
            {
                cmd.CommandText = "UPDATE Estoque " +
                                    "SET qtdProdutoDisponivel = @qtdProdutoDisponivel " +
                                    " where idProduto = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
            }

            cmd.Parameters.Add("@qtdProdutoDisponivel", SqlDbType.Int, 50).Value = this.qtdProdutoDisponivel;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idProduto = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsEstoque> SelecionarEstoque()
        {
            string sql = "SELECT dbo.Estoque.idProduto, dbo.Produto.nomeProduto, qtdProdutoDisponivel, nomeCategoria FROM dbo.Estoque " +
                " inner join dbo.Produto on dbo.Estoque.idProduto = dbo.Produto.idProduto " +
                " inner join dbo.Categoria on dbo.Produto.idCategoria = dbo.Categoria.idCategoria";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                E.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                Estoque.Add(E);
            }

            return Estoque;
        }

        public static List<clsEstoque> SelecionarEstoque(int idProduto)
        {
            string sql = "SELECT dbo.Estoque.idProduto, dbo.Produto.nomeProduto, qtdProdutoDisponivel, nomeCategoria FROM dbo.Estoque " +
                " inner join dbo.Produto on dbo.Estoque.idProduto = dbo.Produto.idProduto " +
                " inner join dbo.Categoria on dbo.Produto.idCategoria = dbo.Categoria.idCategoria" +
                "WHERE idProduto = @idProduto";

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                Estoque.Add(E);
            }

            return Estoque;
        }

        // filtar categoria por nome E/OU categoria
        // este método deve ser chamado no evento do botão pesquisar
        public static List<clsEstoque> SelecionarEstoque(string nomeProd, string nomeCat)
        {
            List<clsEstoque> Estoque = new List<clsEstoque>();
            string sql = "SELECT Produto.idProduto, dbo.Produto.nomeProduto, dbo.Estoque.qtdProdutoDisponivel, dbo.Categoria.nomeCategoria " +
                    "FROM dbo.Produto INNER JOIN dbo.Estoque " +
                     "ON dbo.Produto.idProduto = dbo.Estoque.idProduto " +
                    "INNER JOIN dbo.Categoria " +
                    "ON dbo.Categoria.idCategoria = dbo.Produto.idCategoria ";


            if (!nomeProd.Equals("") && nomeCat.Equals(""))
            {
                sql += "WHERE dbo.Produto.nomeProduto LIKE @nomeProd";
            }
            else if (nomeProd.Equals("") && !nomeCat.Equals(""))
            {
                sql += "WHERE dbo.Categoria.nomeCategoria LIKE @nomeCat";
            }
            else if (!nomeProd.Equals("") && !nomeCat.Equals(""))
            {
                sql += "WHERE dbo.Produto.nomeProduto LIKE @nomeProd AND dbo.Categoria.nomeCategoria LIKE @nomeCat";
            }
            else
            {
                sql += "WHERE dbo.Produto.nomeProduto LIKE @nomeProd AND dbo.Categoria.nomeCategoria LIKE @nomeCat";
            }

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@field", SqlDbType.VarChar, 50).Value = "%" + nomeProd + "%";
            cmd.Parameters.AddWithValue("@nomeProd", "%" + nomeProd + "%");
            cmd.Parameters.AddWithValue("@nomeCat", "%" + nomeCat + "%");

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                E.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                Estoque.Add(E);
            }

            return Estoque;

        }

        public static List<clsEstoque> SelecionarEstoque(string pesquisarTxt)
        {
            List<clsEstoque> Estoque = new List<clsEstoque>();
            string sql = "SELECT Produto.idProduto, dbo.Produto.nomeProduto, dbo.Estoque.qtdProdutoDisponivel, dbo.Categoria.nomeCategoria " +
                   "FROM dbo.Produto INNER JOIN dbo.Estoque " +
                   "ON dbo.Produto.idProduto = dbo.Estoque.idProduto " +
                   "INNER JOIN dbo.Categoria " +
                   "ON dbo.Categoria.idCategoria = dbo.Produto.idCategoria " +
                   "WHERE dbo.Produto.nomeProduto LIKE @field";

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            //cmd.Parameters.Add("@field", SqlDbType.VarChar,50).Value = "%" + nomeProd + "%";
            cmd.Parameters.AddWithValue("@field", "%" + pesquisarTxt + "%");

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                E.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                Estoque.Add(E);
            }

            return Estoque;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BancoModel
{
    public class clsEstoque
    {
        public int idProduto { get; set; }
        public int qtdProdutoDisponivel { get; set; }

        public string nomeProduto { get; set; }
        public string nomeCategoria { get; set; }

        //Faz desse objeto um Singleton
        private static clsEstoque referencia;

        public static clsEstoque getInstance()
        {
            if (referencia == null)
                referencia = new clsEstoque();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idProduto == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Estoque " +
                                "(qtdEstoqueDisponivel)" +
                                "VALUES " +
                                "(@qtdProdutoDisponivel)";
            else
            {
                cmd.CommandText = "UPDATE Estoque " +
                                    "SET qtdProdutoDisponivel = @qtdProdutoDisponivel " +
                                    " where idProduto = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
            }

            cmd.Parameters.Add("@qtdProdutoDisponivel", SqlDbType.Int,50).Value = this.qtdProdutoDisponivel;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idProduto = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsEstoque> SelecionarEstoque()
        {
            string sql = "SELECT dbo.Estoque.idProduto, dbo.Produto.nomeProduto, qtdProdutoDisponivel, nomeCategoria FROM dbo.Estoque " + 
                " inner join dbo.Produto on dbo.Estoque.idProduto = dbo.Produto.idProduto " +
                " inner join dbo.Categoria on dbo.Produto.idCategoria = dbo.Categoria.idCategoria";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                E.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                Estoque.Add(E);
            }

            return Estoque;
        }

        public static List<clsEstoque> SelecionarEstoque(int idProduto)
        {
            string sql = "SELECT dbo.Estoque.idProduto, dbo.Produto.nomeProduto, qtdProdutoDisponivel, nomeCategoria FROM dbo.Estoque " +
                " inner join dbo.Produto on dbo.Estoque.idProduto = dbo.Produto.idProduto " +
                " inner join dbo.Categoria on dbo.Produto.idCategoria = dbo.Categoria.idCategoria" +
                "WHERE idProduto = @idProduto";
            
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                Estoque.Add(E);
            }

            return Estoque;
        }

        // filtar categoria por nome E/OU categoria
        // este método deve ser chamado no evento do botão pesquisar
        public static List<clsEstoque> SelecionarEstoque(string nomeProd, string categoria)
        {
            List<clsEstoque> Estoque = new List<clsEstoque>();
            string sql = "SELECT Produto.idProduto, dbo.Produto.nomeProduto, dbo.Estoque.qtdProdutoDisponivel, dbo.Categoria.nomeCategoria " +
                   "FROM dbo.Produto INNER JOIN dbo.Estoque " +
                   "ON dbo.Produto.idProduto = dbo.Estoque.idProduto " +
                   "INNER JOIN dbo.Categoria " +
                   "ON dbo.Categoria.idCategoria = dbo.Produto.idCategoria " +
                   "WHERE dbo.Produto.nomeProduto LIKE @field" ;
            //LIKE '%" + "@field" + "%'";

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            //cmd.Parameters.Add("@field", SqlDbType.VarChar,50).Value = "%" + nomeProd + "%";
            cmd.Parameters.AddWithValue("@field","%" + nomeProd + "%");

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                E.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                Estoque.Add(E);
            }

            //if (!nomeProdTextBox.Text.Equals("") && categoriaComboBox.Text.Equals(""))
            //{

            //} else if (!categoriaComboBox.Text.Equals("") && nomeProdTextBox.Text.Equals("")) {
            //    // somente a textbox da categoria está preenchida  

            //} else if (!categoriaComboBox.Text.Equals("") && !nomeProdTextBox.Text.Equals("")) {
            //     // somente a textBox do nome está preenchida
              
            //    // ambas estão preenchidas
            //} else {
            //    // nenhuma está preenchida
            //}

            return Estoque;

        }

    }
}
>>>>>>> 3b95b64970949f7a702db7382e92321347b5e16e
