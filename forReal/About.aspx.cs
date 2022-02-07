using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forReal
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ViewState["omar"] == null)
            {
            ViewState["omar"] = 0;

            }
            
             Title = "to the code behind";
        }

        protected void btnSendInfo_Click(object sender, EventArgs e)
        {
            int theVar;
            if( ViewState["omar"] != null )
            {
                ViewState["omar"] = (int)ViewState["omar"] + 1;
                 theVar = (int)ViewState["omar"];
            }
            btnSendInfo.Text = "clicked : " + ViewState["omar"];
            
        }

        protected void btnSendInfo_Command(object sender, CommandEventArgs e)
        {

        }
    }
}