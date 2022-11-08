<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="Assignment_Management_System.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="50%" height="100%" style="margin-top:2%;margin-bottom:2%; font-size:large; font-weight:bold; border-collapse:collapse; border:5px solid #86C232;">
        <tr>
            <td colspan="2" class="Head" align="center">Change Profile</td>
        </tr>
        <tr>
            <td>First Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email Id</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="TextBox"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ControlToValidate="TextBox3"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Phone No.</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="TextBox"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Number" ForeColor="Red" ValidationExpression="^\d{10}$" ControlToValidate="TextBox4"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Birth Day</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" TextMode="Date" CssClass="TextBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Favourite Food</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" CssClass="TextBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Favourite Color</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" CssClass="TextBox"></asp:TextBox>
            </td>
        </tr>
        <tr align="center">
            <td>
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Change" />
            </td>
            <td>
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="See Last Data" />
            </td>
        </tr>
    </table>
</asp:Content>
