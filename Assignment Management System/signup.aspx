<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Assignment_Management_System.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 152px;
        }
        .auto-style6 {
            width: 200px;
        }
        Textbox{
            width: 100%;
        }
        .auto-style7 {
            height: 30px;
        }
    </style>
     <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin-top:1%; border:10px solid #86C232;">
             <tr>
                <td colspan="2" class="Head">Sign Up</td>
             </tr>
        <tr>
            <td class="Label">First Name</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Last Name</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Email</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox3" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Email Invalid" ForeColor="Red" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Phone No.</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox4" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Number Invalid" ForeColor="Red" ValidationExpression="^\d{10}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Birth Date</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Date" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Username</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox6" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Password</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox7" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Favourite Food</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox8" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox8" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="Label">Favourite Color</td>
            <td colspan="2">
                <br />
                <asp:TextBox ID="TextBox9" runat="server" CssClass="TextBox"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox9" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr align="center">
            <td>
                <input type="reset" value="Clear" class="Button" /></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Sing Up" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label  ID="Label1" runat="server"></asp:Label>
                
            </td>
            <td align="right">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
            </td>
        </tr>
    </table>
        </div>
    </form>
</body>
</html>
