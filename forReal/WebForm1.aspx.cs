using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forReal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("number of applications :" + Application["TotalApplications"]);
            Response.Write("<br/>");
            Response.Write("number of Users online :" + Application["TotalUserSessions"]);
            //Application.Add("omar", 0);
            //Response.Write(Application["omar"]);

        }
    }
}