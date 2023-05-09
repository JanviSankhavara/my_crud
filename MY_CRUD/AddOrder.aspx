<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddOrder.aspx.cs" Inherits="MY_CRUD.AddOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <h2>Add Orders</h2>

    <table class="table">
        

         <tr>
            <td>Customer ID</td>
             <td>
                 <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" CssClass="form-control" DataTextField="CustID" DataValueField="CustID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ></asp:DropDownList>
                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT CustID,Name FROM [Customer]"></asp:SqlDataSource>
             </td>
        </tr>
        <tr>
            <td>Customer Name</td>
            <th>
                <asp:Label ID="Label1"  runat="server" Text="select CustId"></asp:Label></th>
        </tr> 
        <tr>
            <td>Order Date</td>
            <td><asp:TextBox type="date" class="form-control" ID="txtOrderDate" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ship Date</td>
            <td><asp:TextBox type="date" class="form-control" ID="txtShipDate" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Order Amount</td>
            <td><asp:TextBox class="form-control" type="number" ID="txtAmount" runat="server"></asp:TextBox></td>
        </tr> 
        <tr>
            <td>Remarks</td>
            <td><asp:TextBox class="form-control" type="text" ID="txtRemarks" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Payment Mode</td>
            <td>
                <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
                    <asp:ListItem>COD</asp:ListItem>
                    <asp:ListItem>Online</asp:ListItem>
                    <asp:ListItem>CARD</asp:ListItem>
                    <asp:ListItem>UPI</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
       

          <tr>
            <td>Month</td><td>
<asp:TextBox class="form-control" ID="txtMonth" type="number" min="1" max="12" step="1" value="2" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
          <tr>
            <td>Year</td>
            <td>
<asp:TextBox class="form-control" ID="txtYear" type="number" min="1900" max="2099" step="1" value="2016" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Submit" OnClick="Button1_Click" /></td>
        </tr>

    </table>


</asp:Content>
