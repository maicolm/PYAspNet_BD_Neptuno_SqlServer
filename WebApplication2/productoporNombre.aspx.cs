using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class productoporNombre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "")
                {
                    grvProducto.DataSource = new NeptunoBL().ProductoxNombre(TextBox1.Text);
                    grvProducto.DataBind();
                }
                else
                {
                    grvProducto.DataSource = null;
                    grvProducto.DataBind();
                }
                
            }catch { 
            
            }
        }
    }
}