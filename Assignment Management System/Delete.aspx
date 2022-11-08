<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Assignment_Management_System.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        <asp:GridView ID="GridView1" width="50%" align="center" CssClass="Grid" style="margin-top:2%" runat="server">
            <Columns>  
                 <asp:TemplateField>
                     <HeaderTemplate>
                         <asp:CheckBox ID="Chkselectall" AutoPostBack="true" runat="server" OnCheckedChanged="Chkselectall_CheckedChanged" />
                     </HeaderTemplate>
                     <ItemTemplate>
                          <asp:CheckBox ID ="chkselect" runat="server"></asp:CheckBox>
                     </ItemTemplate>
                    
                 </asp:TemplateField>
                  
                  </Columns>  
            
        </asp:GridView>
        <br />
        <table align="center">
            <tr>
                <td align="center"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="Button" Text="Delete" CssClass="Button"/></td>
            </tr>
        </table>

    </div>
</asp:Content>
