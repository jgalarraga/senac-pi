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
        public int IdUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public string nomeCategoria { get; set; }

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
                                "(nomeProduto, descProduto, precProduto, descontoPromocao, IdCategoria, ativoProduto, IdUsuario, qtdMinEstoque)" +
                                "VALUES " +
                                "(@nomeProduto, @descProduto, @precProduto, @descontoPromocao, @IdCategoria, @ativoProduto, @IdUsuario, @qtdMinEstoque)";
            else
            {
                cmd.CommandText = "UPDATE Cliente " +
                                    "SET nomeProduto = @nomeProduto, " +
                                    "descProduto = @descProduto, " +
                                    "precProduto = @precProduto, " +
                                    "descontoPromocao = @descontoPromocao, " +
                                    "IdCategoria = @IdCategoria, " +
                                    "ativoProduto = @ativoProduto, " +
                                    "IdUsuario = @IdUsuario, " +
                                    "qtdMinEstoque = @qtdMinEstoque, " +
                                    "WHERE idCliente = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
            }

            cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar, 70).Value = this.nomeProduto;
            cmd.Parameters.Add("@descProduto", SqlDbType.VarChar, 500).Value = this.descProduto;
            cmd.Parameters.Add("@precProduto", SqlDbType.Money, 0).Value = this.precProduto;
            cmd.Parameters.Add("@descontoPromocao", SqlDbType.Decimal, 18).Value = this.descontoPromocao;
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int, 50).Value = this.IdCategoria;
            cmd.Parameters.Add("@ativoProduto", SqlDbType.Char, 1).Value = this.ativoProduto;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int, 50).Value = this.IdUsuario;
            cmd.Parameters.Add("@qtdMinEstoque", SqlDbType.Int,50).Value = this.qtdMinEstoque;
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
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, Produto.IdCategoria, ativoProduto, IdUsuario, qtdMinEstoque,nomeCategoria FROM dbo.Produto inner join dbo.Categoria on dbo.Produto.idCategoria = dbo.Categoria.idCategoria";
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
                if (!dr.IsDBNull(dr.GetOrdinal("descProduto")))
                {
                    P.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                }
                P.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                if (!dr.IsDBNull(dr.GetOrdinal("descontoPromocao")))
                {
                    P.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                }
                P.IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria"));
                P.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                if (!dr.IsDBNull(dr.GetOrdinal("IdUsuario")))
                {
                    P.IdUsuario = dr.GetInt32(dr.GetOrdinal("IdUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("qtdMinEstoque")))
                {
                    P.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                }
                P.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
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
                P.IdUsuario = dr.GetInt32(dr.GetOrdinal("IdUsuario"));
                P.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qntMinEstoque"));
                Produtos.Add(P);
            }

            return Produtos;
        }
        public void Excluir()
        {
            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            cmd.CommandText = "Delete from Produto " +
                                "WHERE idProduto = @idProduto";

            cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;

            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }
    }
}
