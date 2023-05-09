<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="MY_CRUD.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ADD CUSTOMER</h2>

    <table class="table" >
        <tr>
            <td>Name</td>
            <td><asp:TextBox class="form-control"  ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td>Address</td>
            <td><asp:TextBox class="form-control" ID="txtAddress" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td>City</td>
            <td><asp:TextBox class="form-control" ID="txtCity" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td>State</td>
            <td><asp:TextBox class="form-control" ID="txtState" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Email</td>
            <td><asp:TextBox class="form-control" type="email" ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Contact No</td>
            <td><asp:TextBox class="form-control" ID="txtContact" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td>Profession</td>
            <td><asp:TextBox class="form-control" ID="txtProfession" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="submit" CssClass="btn btn-primary" OnClick="Button1_Click" />
            </td>
        </tr>

    </table>


</asp:Content>
