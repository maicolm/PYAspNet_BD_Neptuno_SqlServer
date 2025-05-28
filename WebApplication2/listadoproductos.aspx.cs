using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication2
{
    public partial class listadoproductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grvProducto.DataSource = new NeptunoBL().ProductoListar();
            grvProducto.DataBind();//enlazar la tabla y poblar el control(es con databind)

        }

        protected void grvProducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvProducto.PageIndex = e.NewPageIndex;//guarda un numero dependiendo el nu
            grvProducto.DataBind();
        }

        protected void grvProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}