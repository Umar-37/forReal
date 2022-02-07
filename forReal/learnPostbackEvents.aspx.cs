using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forReal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("<h1>textBox Changed</h1>"+ "<br/>");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<h1>Button click</h1>" );

        }
    }
}