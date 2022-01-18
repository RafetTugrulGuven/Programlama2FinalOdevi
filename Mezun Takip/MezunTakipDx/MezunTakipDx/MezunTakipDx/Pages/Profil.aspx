<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="MezunTakipDx.Pages.Profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <dx:BootstrapPageControl ID="BootstrapPageControl1" runat="server" ActiveTabIndex="0">
        <TabPages>
            <dx:BootstrapTabPage Name="tabKisiselBilgiler" Text="Kişisel Bilgiler">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <h4>Profil Fotoğrafı:</h4>
                                    <br />
                                    <dx:ASPxBinaryImage ID="imgProfil" runat="server" Width="500" Height="500">
                                        <EmptyImage Url="~/Images/noimage.jpg">
                                        </EmptyImage>
                                    </dx:ASPxBinaryImage>
                                    <br />
                                </div>


                                <div class="col-md-6">
                                    <h4>Ad:</h4>
                                    <dx:BootstrapTextBox ID="txtAd" runat="server"></dx:BootstrapTextBox>
                                    <h4>Soyad:</h4>
                                    <dx:BootstrapTextBox ID="txtSoyad" runat="server"></dx:BootstrapTextBox>
                                    <h4>E-posta:</h4>
                                    <dx:BootstrapTextBox ID="txtEposta" runat="server"></dx:BootstrapTextBox>
                                    <h4>Cinsiyet:</h4>
                                    <dx:BootstrapComboBox ID="cbCinsiyet" runat="server" ValueType="System.Int32">
                                        <Items>
                                            <dx:BootstrapListEditItem Text="Kadın" Value="1" />
                                            <dx:BootstrapListEditItem Text="Erkek" Value="2" />
                                        </Items>
                                    </dx:BootstrapComboBox>
                                    <h4>Askerlik Durumu:</h4>
                                    <dx:BootstrapComboBox ID="cbAskerlikDurumu" runat="server" ValueType="System.Int32">
                                        <Items>
                                            <dx:BootstrapListEditItem Text="Yapmadı" Value="1" />
                                            <dx:BootstrapListEditItem Text="Muaf" Value="2" />
                                            <dx:BootstrapListEditItem Text="Yaptı" Value="3" />
                                        </Items>
                                    </dx:BootstrapComboBox>
                                    <h4>İl:</h4>
                                    <dx:BootstrapComboBox ID="cbIl" AutoPostBack="True" runat="server" ValueType="System.Int32"></dx:BootstrapComboBox>
                                    <h4>İlçe:</h4>
                                    <dx:BootstrapComboBox ID="cbIlce" runat="server" ValueType="System.Int32"></dx:BootstrapComboBox>
                                    <h4>Doğum Tarihi:</h4>
                                    <dx:BootstrapDateEdit ID="dtDogumTarihi" runat="server"></dx:BootstrapDateEdit>
                                    <h4>Öğrenim Durumu:</h4>
                                    <dx:BootstrapComboBox ID="cbOgrenimDurum" ValueType="System.Int32" runat="server"></dx:BootstrapComboBox>
                                </div>
                            </div>
                        </div>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>

            <dx:BootstrapTabPage Name="tabIletisim" Text="İletişim Bilgileri">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <h4>Telefon No:</h4>

                        <dx:BootstrapListBox ID="lsTel" runat="server"></dx:BootstrapListBox>
                        <h4>Adres:</h4>

                        <dx:BootstrapListBox ID="lsAdres" runat="server"></dx:BootstrapListBox>


                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>


            <dx:BootstrapTabPage Name="tabOgrenim" Text="Öğrenim Bilgileri">
                <ContentCollection>
                    <dx:ContentControl runat="server">

                        <dx:BootstrapGridView ID="grdUyeBolumler" runat="server" AutoGenerateColumns="False" KeyFieldName="uyeBolum_id">
                            <Columns>
                                <dx:BootstrapGridViewTextColumn FieldName="uyeBolum_id" Visible="false" ReadOnly="True"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="bolum_adi" Caption="Bölüm" VisibleIndex="1"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="fakulte_adi" Caption="Fakülte" VisibleIndex="2"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="uye_tc" Visible="false"></dx:BootstrapGridViewTextColumn>
                            </Columns>
                        </dx:BootstrapGridView>



                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>


            <dx:BootstrapTabPage Name="tabCalismaAlanlari" Text="Çalışma Alanları">
                <ContentCollection>
                    <dx:ContentControl runat="server">

                        <dx:BootstrapGridView ID="grdUyeCalismaAlani" runat="server" AutoGenerateColumns="False">

                            <Columns>
                                <dx:BootstrapGridViewTextColumn FieldName="calismaAlani_adi" Caption="Çalışma Alanı" ReadOnly="True" VisibleIndex="0"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="bolum_adi" Caption="Bölüm" ReadOnly="True" VisibleIndex="1"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="fakulte_adi" Caption="Fakülte" ReadOnly="True" VisibleIndex="2"></dx:BootstrapGridViewTextColumn>
                            </Columns>
                        </dx:BootstrapGridView>



                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>


            <dx:BootstrapTabPage Name="tabSirketBilgileri" Text="Şirket Bilgileri">
                <ContentCollection>
                    <dx:ContentControl runat="server">

                        <dx:BootstrapGridView ID="grdUyeSirket" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <dx:BootstrapGridViewTextColumn FieldName="uyeSirket_durum" Caption="Durum" ReadOnly="True" VisibleIndex="0"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="sirket_adi" Caption="Şirket Adı" ReadOnly="True" VisibleIndex="1"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="sirket_adres" Caption="Adres" ReadOnly="True" VisibleIndex="2"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="sirket_tel" Caption="Tel" ReadOnly="True" VisibleIndex="3"></dx:BootstrapGridViewTextColumn>
                                <dx:BootstrapGridViewTextColumn FieldName="sirket_web" Caption="Web" ReadOnly="True" VisibleIndex="4"></dx:BootstrapGridViewTextColumn>
                            </Columns>
                        </dx:BootstrapGridView>


                    </dx:ContentControl>
                </ContentCollection>
            </dx:BootstrapTabPage>
        </TabPages>
    </dx:BootstrapPageControl>
</asp:Content>
