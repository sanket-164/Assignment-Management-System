<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Assignment_Management_System.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        table,th,td{
            border: 1px solid #86C232;
            border-collapse: collapse;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="50%" height="100%" style="margin-top:2%; font-size:large; font-weight:bold; border:5px solid #86C232;">
        <tr>
            <td colspan="2" align="center" class="Head">Profile</td>
        </tr>
        <tr>
            <td>First Name</td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Email Id</td>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Phone No.</td>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Username</td>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Birth Day</td>
            <td>
                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Favourite Food</td>
            <td>
                <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Favourite Color</td>
            <td>
                <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Edit Profile" />
            </td>
        </tr>
    </table>
</asp:Content>
