using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BancoModel
{
    public class clsProduto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public decimal precProduto { get; set; }
        public decimal descontoPromocao { get; set; }
        public int IdCategoria { get; set; }
        public string ativoProduto { get; set; }
        public string nomeUsuario { get; set; }
        //public int IdUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public string nomeCategoria { get; set; }
        public byte[] imagem { get; set; }

        //Faz desse objeto um Singleton
        private static clsProduto referencia;

        //Impedir que duas classe iguais sejam abertas simultaneamente
        public static clsProduto getInstance()
        {
            if (referencia == null)
                referencia = new clsProduto();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idProduto == 0);

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Produto " +
                                "(nomeProduto, descProduto, precProduto, descontoPromocao, IdCategoria, ativoProduto, nomeUsuario, qtdMinEstoque, imagem)" +
                                "VALUES " +
                                "(@nomeProduto, @descProduto, @precProduto, @descontoPromocao, @IdCategoria, @ativoProduto, @nomeUsuario, @qtdMinEstoque, @imagem)";
            else
            {
                cmd.CommandText = "UPDATE Produto " +
                                    "SET nomeProduto = @nomeProduto, " +
                                    "descProduto = @descProduto, " +
                                    "precProduto = @precProduto, " +
                                    "descontoPromocao = @descontoPromocao, " +
                                    "IdCategoria = @IdCategoria, " +
                                    "ativoProduto = @ativoProduto, " +
                                    "nomeUsuario = @nomeUsuario, " +
                                    "qtdMinEstoque = @qtdMinEstoque, " +
                                    "imagem = @imagem " + 
                                    "WHERE idProduto = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
            }

            cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar, 70).Value = this.nomeProduto;
            cmd.Parameters.Add("@descProduto", SqlDbType.VarChar, 500).Value = this.descProduto;
            cmd.Parameters.Add("@precProduto", SqlDbType.Money).Value = this.precProduto;
            cmd.Parameters.Add("@descontoPromocao", SqlDbType.Decimal,18).Value = this.descontoPromocao;
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = this.IdCategoria;
            cmd.Parameters.Add("@ativoProduto", SqlDbType.Char, 1).Value = this.ativoProduto;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar,500).Value = this.nomeUsuario;
            cmd.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = this.qtdMinEstoque;
            cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = this.imagem;
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
        public static List<clsProduto> SelecionarProdutos()
        {
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, ativoProduto, Usuario.nomeUsuario, qtdMinEstoque, nomeCategoria, imagem " +
                         "FROM dbo.Produto INNER JOIN dbo.Categoria on dbo.Produto.idCategoria = dbo.Categoria.idCategoria " + 
                         "INNER JOIN dbo.Usuario on dbo.Produto.IdUsuario = Usuario.idUsuario";
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produtos = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto P = new clsProduto();
                P.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                P.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                P.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                P.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                P.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));             
                P.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                if (!dr.IsDBNull(dr.GetOrdinal("nomeUsuario")))
                {
                    P.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                }
                P.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                P.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (dr["Imagem"] != DBNull.Value)
                    P.imagem = (byte[])dr["Imagem"];
                else
                    P.imagem = new byte[0];
                Produtos.Add(P);
            }

            return Produtos;
        }

        public static List<clsProduto> SelecionarProdutos(int idProduto)
        {
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, IdCategoria, ativoProduto, IdUsuario, qntMinEstoque FROM dbo.Produto";

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produtos = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto P = new clsProduto();
                P.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                P.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                P.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                P.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                P.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                P.IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria"));
                P.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                P.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                P.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qntMinEstoque"));
                if (dr["Imagem"] != DBNull.Value)
                    P.imagem = (byte[])dr["Imagem"];
                else
                    P.imagem = new byte[0];
                Produtos.Add(P);
            }

            return Produtos;
        }

        public void Excluir()
        {
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            List<clsItemPedido> produtos = clsItemPedido.SelecionarItens(idProduto);
            if(!(produtos.Count > 0))
            {
                cmd.CommandText = "Delete from Produto " +
                    "WHERE idProduto = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;

                cmd.ExecuteNonQuery();

                cn.Close();
                cn.Dispose();
            }
        }

        public static List<clsProduto> SelecionarProdutos(string tipoFiltro, string filtro)
        {
            List<clsEstoque> Estoque = new List<clsEstoque>();
            string sql = "SELECT Produto.idProduto, Produto.nomeProduto, Produto.descProduto, Produto.precProduto, Produto.descontoPromocao, Categoria.nomeCategoria, " +
                "Produto.ativoProduto, Estoque.qtdProdutoDisponivel, imagem, qtdMinEstoque  " +
                "FROM dbo.Produto INNER JOIN dbo.Estoque ON dbo.Produto.idProduto = dbo.Estoque.idProduto " +
                "INNER JOIN dbo.Categoria ON dbo.Categoria.idCategoria = dbo.Produto.idCategoria ";

            switch (tipoFiltro)
            {
                case "Categoria":
                    sql += "WHERE Categoria.nomeCategoria LIKE @filtro";
                    break;
                case "ID":
                    sql += "WHERE Produto.idProduto = @filtro";
                    break;
                case "Preço":
                    sql += "WHERE Produto.precProduto = @filtro";
                    break;
                case "Desconto":
                    sql += "WHERE Produto.descProduto = @filtro";
                    break;
                case "Quantidade":
                    sql += "WHERE Estoque.qtdProdutoDisponivel = @filtro";
                    break;
                case "Nome":
                    sql += "WHERE Produto.nomeProduto LIKE @filtro";
                    break;
            }

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            if (tipoFiltro.Equals("Categoria") || tipoFiltro.Equals("Nome"))
            {
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%"); ;
            } else
            {
                cmd.Parameters.AddWithValue("@filtro", filtro);
            }

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produtos = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto P = new clsProduto();
                P.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                P.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                P.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                P.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                P.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                P.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                P.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                P.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                if (dr["Imagem"] != DBNull.Value)
                    P.imagem = (byte[])dr["Imagem"];
                else
                    P.imagem = new byte[0];
                Produtos.Add(P);
            }

            return Produtos;
        }
    }
}
