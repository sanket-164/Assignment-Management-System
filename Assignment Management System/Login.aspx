<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Assignment_Management_System.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
        .auto-style2 {
            height: 24px;
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" style="margin-top:20%;border:10px solid #86C232;">
            <tr>
                <th colspan="2"><h2>Login Page</h2></th>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Username" CssClass="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password" CssClass="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center" class="auto-style1">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="88px"></asp:Button>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Sign Up" OnClick="Button2_Click" Width="88px" />
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="right" class="auto-style2">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forgot Password?</asp:LinkButton>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
