using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication2
{
    public partial class productoporCategoria : System.Web.UI.Page
    {
        #region Metodo
        private void CargaCategoria()
        {
            ddl_Categoria.DataSource = new NeptunoBL().CategoriaListar();
            ddl_Categoria.DataTextField = "nombrecategoria";
            ddl_Categoria.DataValueField = "idcategoria";
            ddl_Categoria.DataBind();
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargaCategoria();
            }
            grvProducto.DataSource = new NeptunoBL().ProductoPorCategoria(Int32.Parse(ddl_Categoria.SelectedValue));
            grvProducto.DataBind();

        }
    }

  
}