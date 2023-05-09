<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyFilter.aspx.cs" Inherits="MY_CRUD.MyFilter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Data Report Generate By Filter .</h3>
    <table class="table">
        <tr>
            <td>
                <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server">
                    <asp:ListItem>1) Display all orders with orderid, custid, customer name, city, state, order amount</asp:ListItem>
                    <asp:ListItem>2) Display all orders with OrderID, CustID, customer name, city, state with order amount greater than 10000.</asp:ListItem>
                    <asp:ListItem>3) Display customer details with total order amount</asp:ListItem>
                    <asp:ListItem>4) Display CustID, name, OrderAmount by Month and Year</asp:ListItem>
                    <asp:ListItem>5) Display PaymentMode, OrderAmount total</asp:ListItem>
                    <asp:ListItem>6) Display PaymentMode, OrderAmount total for current year</asp:ListItem>
                    <asp:ListItem>7) Display PaymentMode, OrderAmount total for last year</asp:ListItem>
                    <asp:ListItem>8) Display PaymentMode, OrderAmount total for range (from and to)</asp:ListItem>
                    <asp:ListItem>  
                    9) Decide at your level // OrderAmount Between 30000 to 50000

                    </asp:ListItem>
                    <asp:ListItem>10)  Decide at your level// Payment Mode is UPI</asp:ListItem>

                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Search" OnClick="Button1_Click" />
            </td>
        </tr>
        <td colspan="2" CssClass="form-control">
            <asp:GridView CssClass="table" ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>

        </td>
    </table>

</asp:Content>
