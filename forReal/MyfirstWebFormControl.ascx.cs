using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forReal
{
    public partial class MyfirstWebFormControl : System.Web.UI.UserControl
    {
        public String Message 
        {
            get { return firstTextArea.InnerText; }
            set { firstTextArea.InnerText =value ; }
        }
         public String buttonMessage 
        {
            get { return ButtonTextArea.Text; }
            set { ButtonTextArea.Text =value ; }
        }    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //ButtonTextArea.Text = firstTextArea.InnerText;
            }

        }

        protected void ButtonTextArea_Click(object sender, EventArgs e)
        {
            //Response.Write(firstTextArea.)        
        }
    }
}