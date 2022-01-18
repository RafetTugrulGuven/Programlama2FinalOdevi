<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="MezunTakipDx.Pages.Kayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server" ActiveTabIndex="0">
        <TabPages>
            <dx:BootstrapTabPage Name="tabKisiselBilgiler" Text="Kişisel Bilgiler">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                    <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <h4>     Profil Fotoğrafı:</h4><br />
                        <dx:ASPxBinaryImage ID="imgProfil" runat="server" Width="500" Height="500">
                            <EmptyImage Url="~/Images/noimage.jpg">
                            </EmptyImage>
                            <EditingSettings Enabled="True">
                                <ButtonPanelSettings Visibility="OnMouseOver" />
                            </EditingSettings>
                        </dx:ASPxBinaryImage>
                        <br />  </div>


                                <div class="col-md-6">
                     <h4>     Tc Kimlik No:</h4>
                        <dx:BootstrapTextBox ID="txtTc" runat="server"></dx:BootstrapTextBox>
                     <h4>     Ad:</h4>
                        <dx:BootstrapTextBox ID="txtAd" runat="server"></dx:BootstrapTextBox>
                     <h4>     Soyad:</h4>
                        <dx:BootstrapTextBox ID="txtSoyad" runat="server"></dx:BootstrapTextBox>
                      <h4>    E-posta:
                        <dx:BootstrapTextBox ID="txtEposta" runat="server"></dx:BootstrapTextBox>
                     <h4>     Cinsiyet:</h4>
                        <dx:BootstrapComboBox ID="cbCinsiyet" runat="server" ValueType="System.Int32">
                            <Items>
                                <dx:BootstrapListEditItem Text="Kadın" Value="1" />
                                <dx:BootstrapListEditItem Text="Erkek" Value="2" />
                            </Items>
                        </dx:BootstrapComboBox>
                     <h4>     Askerlik Durumu:</h4>
                        <dx:BootstrapComboBox ID="cbAskerlikDurumu" runat="server" ValueType="System.Int32">
                            <Items>
                                <dx:BootstrapListEditItem Text="Yapmadı" Value="1" />
                                <dx:BootstrapListEditItem Text="Muaf" Value="2" />
                                <dx:BootstrapListEditItem Text="Yaptı" Value="3" />
                            </Items>
                        </dx:BootstrapComboBox>
                    <h4>      İl:</h4>
                        <dx:BootstrapComboBox ID="cbIl" AutoPostBack="True" runat="server" ValueType="System.Int32" OnValueChanged="cbIl_ValueChanged"></dx:BootstrapComboBox>
                     <h4>     İlçe:</h4>
                        <dx:BootstrapComboBox ID="cbIlce" runat="server" ValueType="System.Int32"></dx:BootstrapComboBox>
                    <h4>      Doğum Tarihi:
                        <dx:BootstrapDateEdit ID="dtDogumTarihi" runat="server"></dx:BootstrapDateEdit>
                    <h4>       Öğrenim Durumu:</h4>
                        <dx:BootstrapComboBox ID="cbOgrenimDurum" ValueType="System.Int32" runat="server"></dx:BootstrapComboBox>
                     <h4>     Şifre:</h4>
                        <dx:BootstrapTextBox ID="txtSifre" runat="server" Password="True"></dx:BootstrapTextBox>
                     <h4>     Şifre Tekrar:</h4>
                        <dx:BootstrapTextBox ID="txtSifreTekrar" runat="server" Password="True"></dx:BootstrapTextBox>
                       

                        <dx:BootstrapButton ID="btnUyeKayit" runat="server" Text="Kaydet" OnClick="btnUyeKayit_Click"></dx:BootstrapButton>
                            </div>
                            </div>
                        </div>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>

            <dx:BootstrapTabPage Name="tabIletisim" Text="İletişim Bilgileri">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                    <h4>      Telefon No:</h4>
                        <dx:BootstrapTextBox ID="txtTel" runat="server"></dx:BootstrapTextBox>
                     <h4>     Adres:</h4>
                        <dx:BootstrapMemo ID="txtAdres" runat="server"></dx:BootstrapMemo>

                        <dx:BootstrapButton ID="btnIekle" runat="server" AutoPostBack="true" Text="Ekle" OnClick="btnIekle_Click"></dx:BootstrapButton>
                        <dx:BootstrapButton ID="iileri" runat="server" AutoPostBack="True" Text="İleri" OnClick="iileri_Click" ></dx:BootstrapButton>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>


            <dx:BootstrapTabPage Name="tabOgrenim" Text="Öğrenim Bilgileri">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                      

                      <h4>    Fakülte:</h4><dx:BootstrapComboBox ID="cbFakulteUye" runat="server" AutoPostBack="True" OnValueChanged="cbFakulteUye_ValueChanged" ValueType="System.Int32"></dx:BootstrapComboBox>
                      <h4>    Bölüm:</h4><dx:BootstrapComboBox ID="cbBolumUye" AutoPostBack="True" runat="server" ValueType="System.Int32"></dx:BootstrapComboBox>

                        <dx:BootstrapButton ID="btnOEkle" runat="server" AutoPostBack="True" Text="Ekle" OnClick="btnOEkle_Click"></dx:BootstrapButton>
                        <dx:BootstrapButton ID="oileri" runat="server" AutoPostBack="True" Text="İleri" OnClick="oileri_Click" ></dx:BootstrapButton>

                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>


            <dx:BootstrapTabPage Name="tabCalismaAlanlari" Text="Çalışma Alanları">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                    <h4>      Fakülte:</h4>
                        <dx:BootstrapComboBox ID="cbFakulte" runat="server" AutoPostBack="True" OnValueChanged="cbFakulte_ValueChanged" ValueType="System.Int32"></dx:BootstrapComboBox>
                      <h4>    Bölüm:</h4>
                        <dx:BootstrapComboBox ID="cbBolum" runat="server" AutoPostBack="True" OnValueChanged="cbBolum_ValueChanged" ValueType="System.Int32"></dx:BootstrapComboBox>
                     <h4>     Çalışma Alanı:</h4>
                        <dx:BootstrapComboBox ID="cbCalismaAlani" AutoPostBack="True" runat="server" ValueType="System.Int32"></dx:BootstrapComboBox>

                        <dx:BootstrapButton ID="btnCaEkle" runat="server" AutoPostBack="True" Text="Ekle" OnClick="btnCaEkle_Click"></dx:BootstrapButton>
                          <dx:BootstrapButton ID="caileri" runat="server" AutoPostBack="True" Text="İleri" OnClick="caileri_Click" ></dx:BootstrapButton>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>


            <dx:BootstrapTabPage Name="tabSirketBilgileri" Text="Şirket Bilgileri">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                   <h4>       Şirket Adı:</h4><dx:BootstrapComboBox ID="cbSirketAdi" runat="server" DropDownStyle="DropDown" DataSecurityMode="Default" ValueType="System.Int32" AutoPostBack="True" OnValueChanged="cbSirketAdi_ValueChanged"></dx:BootstrapComboBox>  
                      <h4>      Telefon No:</h4>
                        <dx:BootstrapTextBox ID="txtSTel" runat="server"></dx:BootstrapTextBox>
                      <h4>    Adres:</h4>
                        <dx:BootstrapMemo ID="txtSAdres" runat="server"></dx:BootstrapMemo>
                    <h4>        Web Adresi: </h4>
                        <dx:BootstrapTextBox ID="txtSWeb" runat="server"></dx:BootstrapTextBox>
                       
                    <h4>      Çalışma Durumu: </h4>
                        <dx:BootstrapComboBox ID="cbCalismaDurumu" runat="server" ValueType="System.Int32" DropDownStyle="DropDown">
                            <Items>
                                <dx:BootstrapListEditItem Text="Halen Çalışmakta" Value="0" />
                                <dx:BootstrapListEditItem Text="Ayrıldı" Value="1" />
                            </Items>
                        </dx:BootstrapComboBox>


                        <dx:BootstrapButton ID="btnSirketEkle" runat="server" AutoPostBack="True" Text="Ekle" OnClick="btnSirketEkle_Click"></dx:BootstrapButton>
                         <dx:BootstrapButton ID="home" runat="server" AutoPostBack="True" Text="Ana Sayfa" OnClick="home_Click" ></dx:BootstrapButton>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>
        </TabPages>
    </dx:BootstrapPageControl>
</asp:Content>
