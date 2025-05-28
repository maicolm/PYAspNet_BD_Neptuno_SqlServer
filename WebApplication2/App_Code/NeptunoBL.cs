using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication2
{
    public class NeptunoBL
    {
        public NeptunoBL()
        {
        }
        //metodos
        public DataTable ProductoListar()
        {
            return new NeptunoDAO().ProductoListar();
        }
        public DataTable ProductoPorCategoria(int id)
        {
            return new NeptunoDAO().ProductoxCategoria(id);
        }
        public DataTable CategoriaListar()
        {
            return new NeptunoDAO().CategoriaListar();
        }
        public SqlDataReader ProductoxNombre(string nom)
        {
            return new NeptunoDAO().ProductoxNombre(nom);
        }

        public DataTable ListaClientes()
        {
            return new NeptunoDAO().ClienteListar();
        }

        public DataTable ListaPedidos(string cod)
        {
            return new NeptunoDAO().PedidoListar(cod);
        }
    }
}