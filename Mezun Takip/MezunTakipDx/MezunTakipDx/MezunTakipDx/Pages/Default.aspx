<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" enableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="MezunTakipDx._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="jumbotron">
        <div class="container">
            <h1>MEZUN TAKIP SISTEMI</h1>
            <p>Bu Site Mezun olup iþ hayatýna atýlmýþ eski öðrenciler ile hali hazýrda eðitimi devam eden öðrencilerin iletiþim kurabilmesi için tasarlanmýþtýr. </p>
            <p><a href="http://www.dpu.edu.tr/" class="btn btn-primary btn-lg">Dumlupýnar Üniversitesi &raquo;</a></p>
        </div>
    </div>

    <div class="container">
        <div class="row">
            
            <asp:Repeater ID="rpDuyurular" runat="server">
                <ItemTemplate>

                    <div class="col-md-4" >
                        <h2><%# DataBinder.Eval(Container.DataItem, "duyuru_Basligi") %></h2>
                        <p><%# DataBinder.Eval(Container.DataItem, "duyuru_sahibiAdSoyad") %></p>
                        <p>
                            <dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Width="250" Value='<%# DataBinder.Eval(Container.DataItem, "duyuru_Resim") %>'></dx:ASPxBinaryImage>
                        </p>
                        <p><%# Eval("duyuru_Metin").ToString().Length>350? Eval("duyuru_Metin").ToString().Substring(0,350):Eval("duyuru_Metin").ToString() %>
                        <p><%# DataBinder.Eval(Container.DataItem, "duyuru_yayinTarihi") %></p>
                        <p><%# DataBinder.Eval(Container.DataItem, "duyuru_bitisTarihi") %></p>
                        <p>                         
                             <dx:BootstrapButton ID="BootstrapButton1" CommandArgument='<%#DataBinder.Eval(Container.DataItem, "duyuru_id") %>'  runat="server" OnClick="BootstrapButton1_Click" Text="Ýlan Detayý &raquo;" AutoPostBack="false">
                            </dx:BootstrapButton>
                        </p>
                    </div>

                </ItemTemplate>

            </asp:Repeater>
        </div>

    </div>
</asp:Content>
