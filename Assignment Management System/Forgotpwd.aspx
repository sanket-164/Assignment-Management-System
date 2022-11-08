<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forgotpwd.aspx.cs" Inherits="Assignment_Management_System.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 30px;
        }
    </style>
     <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" style="margin-top:20%;border:10px solid #86C232;">
            <tr>
                <td>
                <asp:Panel ID="Panel1" runat="server">
                    <table>
                        <tr>
                            <th colspan="2" class="Head">Change Password</th>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">Enter following Details</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Favourite Food"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Favourite Color"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="TextBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="center">
                                <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
                            <br />
                                <asp:Button ID="Button3" runat="server" Text="Verify" OnClick="Button1_Click" Width="88px"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel2" runat="server">
                        <table>
                            <tr>
                                <th colspan="2" class="Head">Change Password<br /> </th>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="New Password"/>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Type Again"/>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" class="auto-style2">
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Not Matched" ForeColor="Red"></asp:CompareValidator>
                                    <br />
                                    <asp:Button ID="Button2" runat="server" Text="Change" On_Click="Button2_Click" Width="88px" OnClick="Button2_Click"/>
                                    <br />
                                    <asp:Label ID="Label7" runat="server"></asp:Label>
                                    &nbsp;
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
