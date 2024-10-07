<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="form1" runat="server">

        <div class="form-group">

            <div>
                <strong>
                    <asp:Label for="Txtıd" runat="server" Text="Öğrenci ID"></asp:Label>
                </strong>
                <asp:TextBox ID="Txtıd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtFotograf" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <strong>
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" Style="font-weight: bold" OnClick="Button1_Click" />

        </strong>

    </form>
</asp:Content>

