using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BancoModel
{
    public class clsItemPedido
    {
        public int idProduto { get; set; }
        public int idPedido { get; set; }
        public int qtdProduto { get; set; }
        public decimal precoVendaItem { get; set; }

        //Faz desse objeto um Singleton
        private static clsCategoria referencia;

        public static clsCategoria getInstance()
        {
            if (referencia == null)
                referencia = new clsCategoria();

            return referencia;
        }

        public static List<clsItemPedido> SelecionarItens(int idProduto)
        {
            string sql = "select * from itemPedido where idProduto = @idProduto";

            SqlConnection cn = clsConexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsItemPedido> Itens = new List<clsItemPedido>();
            while (dr.Read())
            {
                clsItemPedido I = new clsItemPedido();
                I.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                I.idPedido = dr.GetInt32(dr.GetOrdinal("idPedido"));
                I.qtdProduto = dr.GetInt16(dr.GetOrdinal("qtdProduto"));
                I.precoVendaItem = dr.GetDecimal(dr.GetOrdinal("precoVendaItem"));
                Itens.Add(I);
            }

            return Itens;
        }
    }
}
