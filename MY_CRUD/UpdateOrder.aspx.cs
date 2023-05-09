using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MY_CRUD
{
    public partial class UpdateOrder : System.Web.UI.Page
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
            string q = $"update Orders set CustID={DropDownList1.Text},OrderDate='{txtOrderDate.Text}',ShipDate='{txtShipDate.Text}',OrderAmount={txtAmount.Text},PaymentMode='{DropDownList2.Text}',Remarks='{txtRemarks.Text}',Month={txtMonth.Text},Year={txtYear.Text} where OrderID={DropDownList3.Text} ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ShowOrder.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = $"delete from Orders where OrderID = {DropDownList3.Text}";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ShowOrder.aspx");
        }

        protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Orders where OrderID='" + Convert.ToInt32(DropDownList3.Text) + "'", con);
                SqlDataReader ds;
                ds = cmd.ExecuteReader();
                while (ds.Read())
                {
                    DropDownList1.Text = ds["CustID"].ToString();
                    txtOrderDate.Text = ds["OrderDate"].ToString();
                    txtShipDate.Text = ds["ShipDate"].ToString();
                    txtAmount.Text = ds["OrderAmount"].ToString();
                    DropDownList2.Text = ds["PaymentMode"].ToString();
                    txtRemarks.Text = ds["Remarks"].ToString();
                    txtMonth.Text = ds["Month"].ToString();
                    txtYear.Text = ds["Year"].ToString();
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
    }
}