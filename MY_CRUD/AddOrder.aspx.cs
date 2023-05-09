using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MY_CRUD
{
    public partial class AddOrder : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.conn);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select Name from Customer where CustID='" + Convert.ToInt32(DropDownList1.Text) + "'", con);
                SqlDataReader ds;
                ds = cmd.ExecuteReader();
                while (ds.Read())
                {
                    Label1.Text = ds[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = $"insert into Orders values({DropDownList1.SelectedValue.ToString()},'{Convert.ToDateTime(txtOrderDate.Text)}','{Convert.ToDateTime(txtShipDate.Text)}',{txtAmount.Text},'{DropDownList2.SelectedValue.ToString()}','{txtRemarks.Text}',{txtMonth.Text},{txtYear.Text})";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ShowOrder.aspx");
        }
    }
}