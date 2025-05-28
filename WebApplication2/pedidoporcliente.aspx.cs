using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class pedidoporcliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = new NeptunoBL().ListaClientes();
            GridView1.DataBind();//ENLAZAR LA TABLA Y POBLAR EL CONTROL ES DATABIND
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int fila = GridView1.SelectedIndex;
                string cod = GridView1.Rows[fila].Cells[0].Text;
                GridView2.DataSource = new NeptunoBL().ListaPedidos(cod);
                GridView2.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;//guarda un numero dependiendo el nu
                                                 //numero de pagina 
            GridView1.DataBind();
        }

    }
}