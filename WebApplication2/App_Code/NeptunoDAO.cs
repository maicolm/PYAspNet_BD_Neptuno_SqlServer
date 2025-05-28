using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;//para leer la cadena de conexion desde web.config

namespace WebApplication2
{
    public class NeptunoDAO
    {
        public NeptunoDAO()
        {
        }
        private SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ConnectionString);

      
        public DataTable ProductoListar()
        {
            DataTable tb;
            using (var dap = new SqlDataAdapter("sp_Producto_Listar", cn))
            {
                tb = new DataTable();
                dap.Fill(tb);
            }
            return tb;
        }

        public DataTable CategoriaListar()
        {
            DataTable tb;
            using (var dap = new SqlDataAdapter("sp_Categoria_Listar", cn))
            {
                tb = new DataTable();
                dap.Fill(tb);
            }
            return tb;
        }
        public DataTable ProductoxCategoria(int idcat)
        {
            DataTable tb;
            using (var dap = new SqlDataAdapter("sp_producto_x_categoria", cn))
            {
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dap.SelectCommand.Parameters.AddWithValue("@IdCategoria", idcat);
                tb = new DataTable();
                dap.Fill(tb);
            }
            return tb;
        }

        public SqlDataReader ProductoxNombre(String nom)
        {
            SqlDataReader dr = null;
            using (var cmd = new SqlCommand("usp_Productos_Nombre", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nom);
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }

            return dr;
        }

        public DataTable ClienteListar()
        {
            DataTable tb;
            using (var dap = new SqlDataAdapter("sp_Cliente_Listar", cn))
            {
                tb = new DataTable();
                dap.Fill(tb);
            }
            return tb;
        }
        public DataTable PedidoListar(String cod)
        {
            DataTable tb;
            using (var dap = new SqlDataAdapter("sp_Pedido_Listar", cn))
            {
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dap.SelectCommand.Parameters.AddWithValue("@IdCliente", cod);
                tb = new DataTable();
                dap.Fill(tb);
            }
            return tb;//nos devuelve todos los pedidos que tiene dicho cliente
        }

    }
}