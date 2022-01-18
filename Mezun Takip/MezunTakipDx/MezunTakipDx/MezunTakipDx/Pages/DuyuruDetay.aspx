<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="DuyuruDetay.aspx.cs" Inherits="MezunTakipDx.Pages.DuyuruDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
             <h4>     Duyuru Resim:</h4><br />
                <dx:ASPxBinaryImage ID="imgProfil" runat="server" Width="500" Height="500">
                    <EmptyImage Url="~/Images/noimage.jpg">
                    </EmptyImage>
                    <EditingSettings Enabled="True">
                        <ButtonPanelSettings Visibility="None" />
                    </EditingSettings>
                </dx:ASPxBinaryImage>
                <br />
            </div>
       
 
            <div class="col-md-6">
             <h4>     Duyuru Başlığı:</h4>
                        <dx:BootstrapTextBox ID="txtBaslik" runat="server" ReadOnly="True"></dx:BootstrapTextBox>
             <h4>     Duyuru Metini:</h4>
                        <dx:BootstrapMemo ID="txtMetin" runat="server" ReadOnly="True"></dx:BootstrapMemo>
             <h4>     Duyuru Bitiş Tarihi:   </h4>                    
                        <dx:BootstrapDateEdit ID="dtBitisTarihi" runat="server" ReadOnly="True"></dx:BootstrapDateEdit>
             <h4>     Duyuru Ekleme Tarihi:  </h4>                     
                        <dx:BootstrapDateEdit ID="dtYayinTarihi" runat="server" ReadOnly="True"></dx:BootstrapDateEdit>
             <h4>     Çalışma Alanları:     </h4>
    <dx:BootstrapGridView ID="grdCA" runat="server" AutoGenerateColumns="False">
        <Columns>
            <dx:BootstrapGridViewTextColumn FieldName="calismaAlani_adi" ReadOnly="True" VisibleIndex="0" Caption="Çalışma Alanı"></dx:BootstrapGridViewTextColumn>
            <dx:BootstrapGridViewTextColumn FieldName="bolum_adi" ReadOnly="True" VisibleIndex="1" Caption="Bölüm"></dx:BootstrapGridViewTextColumn>
            <dx:BootstrapGridViewTextColumn FieldName="fakulte_adi" ReadOnly="True" VisibleIndex="2" Caption="Fakülte"></dx:BootstrapGridViewTextColumn>
        </Columns>


    </dx:BootstrapGridView>
            <h4>      Başvuran Kişiler:      </h4>                 
            <dx:BootstrapGridView ID="grdUye" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <dx:BootstrapGridViewTextColumn FieldName="uye_AdSoyad" ReadOnly="True" VisibleIndex="0" Caption="Ad Soyad"></dx:BootstrapGridViewTextColumn>
                </Columns>
            </dx:BootstrapGridView>

                <dx:BootstrapButton ID="btnBasvur" runat="server" AutoPostBack="True" Text="Kayıt Ol" OnClick="btnBasvur_Click"></dx:BootstrapButton>
            </div>
        </div>
    </div>
</asp:Content>
