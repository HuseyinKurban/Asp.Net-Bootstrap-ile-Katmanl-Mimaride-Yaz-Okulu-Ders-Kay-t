<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BasvuruForm.aspx.cs" Inherits="BasvuruForm" %>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <table class="table table-bordered table-hover">

        <tr>
            <th>BASVURU ID</th>
            <th>Öğrenci Ad Soyad</th>
            <th>Ders Ad</th>
 
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("BASVURUID")%></td>
                        <td><%#Eval("OGRAD")%></td>
                        <td><%#Eval("DERSAD")%></td>
                     

                    </tr>

                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>


</asp:Content>

