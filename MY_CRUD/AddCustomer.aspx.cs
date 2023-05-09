using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MY_CRUD
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection(Connection.conn);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = $"insert into Customer values('{txtName.Text}','{txtAddress.Text}','{txtCity.Text}','{txtState.Text}','{txtEmail.Text}','{txtContact.Text}','{txtProfession.Text}')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ShowCustomer.aspx");
        }
    }
}