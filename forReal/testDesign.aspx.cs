using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace forReal
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["firstDb"].ConnectionString;
            var insertStatement = "INSERT INTO Messages (Name,Message) VALUES (@Name,@Message)";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (var sqlCommand = new SqlCommand(insertStatement, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("Name", fakeFormId.buttonMessage);
                    sqlCommand.Parameters.AddWithValue("Message", fakeFormId.Message);
                    sqlCommand.ExecuteNonQuery();
                } 
            }
           // Response.Write(fakeFormId.Message);
        }
        protected void Page_PreRender(object sender , EventArgs e)
        {
            lvMessages.DataBind();
        }
    }
}