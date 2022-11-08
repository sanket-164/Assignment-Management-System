<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="Assignment_Management_System.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table align="center" style="margin-top:5%; border:5px solid #86C232">
            <tr>
                <td align="center">
                    <asp:FileUpload ID="FileUpload1" runat="server" />  
                </td>
            </tr>
            <tr>
                <td align="center">
                    <br />
                    <asp:Button ID="btnUpload" runat="server" Text="Add" OnClick="Upload" CssClass="btn-primary" Width="75px" height="50px"/>
                    <br />
                    <br />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="Grid" Width="50%">  
            <Columns>  
                <asp:BoundField DataField="Name" HeaderText="File Name" /> 
            </Columns>  
        </asp:GridView>
        <br />
    </div>
</asp:Content>
