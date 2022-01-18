<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="DuyuruEkle.aspx.cs" Inherits="MezunTakipDx.Pages.DuyuruEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h4>Duyuru Resim:</h4>
                <br />
                <dx:ASPxBinaryImage ID="imgProfil" runat="server"  Width="500" Height="500">
                    <EmptyImage Url="~/Images/noimage.jpg">
                    </EmptyImage>
                    <EditingSettings Enabled="True">
                        <ButtonPanelSettings Visibility="OnMouseOver" />
                    </EditingSettings>
                </dx:ASPxBinaryImage>
                <br />
            </div>


            <div class="col-md-6">
                <h4>Duyuru Başlığı:</h4>
                <dx:BootstrapTextBox ID="txtBaslik" runat="server"></dx:BootstrapTextBox>
                <h4>Duyuru Metini:</h4>
                <dx:BootstrapMemo ID="txtMetin" runat="server"></dx:BootstrapMemo>
                <h4>Duyuru Bitiş Tarihi:     </h4>
                <dx:BootstrapDateEdit ID="dtBitisTarihi" runat="server"></dx:BootstrapDateEdit>
                <dx:BootstrapButton ID="btnDuyuruKayit" runat="server" AutoPostBack="false" Text="Kaydet" OnClick="btnDuyuruKayit_Click"></dx:BootstrapButton>
            </div>
        </div>
    </div>
</asp:Content>
