using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forReal
{
    public partial class _Default : Page
    {
        int ClickCouont = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button2.Text = "k";
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                int v = (int)ViewState["Clicks"];
                ClickCouont = v + 1;
            }
            Button2.Style.Value = ClickCouont.ToString();
            Button2.Text = ClickCouont.ToString();
            TextArea1.InnerText=ClickCouont.ToString();
            //Console.WriteLine("this is the code");
            System.Diagnostics.Debug.WriteLine("this is the code");
            System.Diagnostics.Debug.WriteLine("event object :");
            System.Diagnostics.Debug.WriteLine(ClickCouont);
            //Console.WriteLine(ClickCouont);

            ViewState["Clicks"] = ClickCouont;
        }
        protected void clearField(object sender, EventArgs e)
        {
            TextArea1.InnerText = " ";
        }
    }
}