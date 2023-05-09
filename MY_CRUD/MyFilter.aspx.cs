using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MY_CRUD
{
    public partial class MyFilter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(Connection.conn);


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "Select o.OrderID, o.CustID, c.Name,c.City,c.State,o.OrderAmount FROM Customer c, Orders o WHERE c.CustID=o.CustID";
            int index = DropDownList1.SelectedIndex;
            switch (index)
            {
                //1) Display all orders with orderid, custid, customer name, city, state, order amount.
                case 0:
                    query = "Select o.OrderID, o.CustID, c.Name,c.City,c.State,o.OrderAmount FROM Customer c, Orders o WHERE c.CustID=o.CustID";
                    break;

                //2) Display all orders with OrderID, CustID, customer name, city, state with order amount greater than 10000.
                case 1:
                    query = "select o.OrderID, o.CustID, c.Name,c.City,c.State, o.OrderAmount from Orders as o,Customer as c where o.CustID = c.CustID and o.OrderAmount>10000";
                    break;

                //3) Display customer details with total order amount
                case 2:
                    query = "select CustID,sum(OrderAmount) as Total_Order_Amount from Orders group by CustID";
                    break;

                //4) Display CustID, name, OrderAmount by Month and Year
                case 3:
                    query = "select o.OrderID, o.CustID, c.Name, o.OrderAmount,o.Month,o.Year from Orders as o,Customer as c where o.CustID = c.CustID order by format(OrderDate,'%M %Y') desc";
                    break;

                //5) Display PaymentMode, OrderAmount total
                case 4:
                    query = "select PaymentMode,sum(OrderAmount) from Orders group by PaymentMode";
                    break;

                //6) Display PaymentMode, OrderAmount total for current year
                case 5:
                    query = "select PaymentMode,sum(OrderAmount) from Orders WHERE format(OrderDate,'%y') = format(getdate(),'%y') group by PaymentMode";
                    break;

                //7) Display PaymentMode, OrderAmount total for last year
                case 6:
                    query = "select PaymentMode,sum(OrderAmount) from Orders WHERE format(OrderDate,'yyyy') = format(dateadd(year,-1,getdate()),'yyyy') group by PaymentMode";
                    break;

                //8) Display PaymentMode, OrderAmount total for range (from and to)
                case 7:
                    query = "SELECT CustID,PaymentMode,OrderAmount,datediff(day,OrderDate,ShipDate) as 'Range(days)' from Orders";
                    break;

                //9) Decide at your level // OrderAmount Between 30000 to 50000
                case 8:
                    query = "select * from Orders where OrderAmount between 30000 and 50000";
                    break;


                //10) Decide at your level// Payment Mode is UPI
                case 9:
                    query = "select * from Orders where PaymentMode ='UPI'";
                    break;

                default:
                    query = "select * from Orders";
                    break;
            }


            con.Open();
            try
            {
                SqlDataAdapter sa= new SqlDataAdapter(query, con);
                DataSet ds=new DataSet();
                sa.Fill(ds);
                GridView1.DataSource=ds;
                GridView1.DataBind();

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