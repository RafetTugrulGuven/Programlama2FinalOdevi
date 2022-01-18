<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="MezunTakipDx.Pages.Giris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
                            <div class="row">
                                <div class="col-md-4">
                                    <h4>   E-posta:</h4>
    <dx:BootstrapTextBox ID="ePosta" runat="server"></dx:BootstrapTextBox>
  <h4>    Şifre:</h4>
    <dx:BootstrapTextBox ID="sifre" runat="server" Password="True"></dx:BootstrapTextBox>
    <dx:BootstrapButton ID="btnGiris" runat="server" AutoPostBack="false" Text="Giriş" OnClick="btnGiris_Click"></dx:BootstrapButton>
    <dx:BootstrapButton ID="btnKayitOl" runat="server" AutoPostBack="false" Text="Kayıt Ol" OnClick="btnGiris_Click" PostBackUrl="~/Pages/Kayit.aspx"></dx:BootstrapButton>
    <dx:BootstrapButton ID="btnSifreUnut" runat="server" AutoPostBack="false" Text="Şifremi Unuttum"></dx:BootstrapButton></div></div></div>
</asp:Content>
