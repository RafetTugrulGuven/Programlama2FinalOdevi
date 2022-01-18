<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="DuyuruKapsamlari.aspx.cs" Inherits="MezunTakipDx.Pages.DuyuruKapsamlari" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
 <h4>     Fakülte:</h4><dx:BootstrapComboBox ID="cbFakulte" runat="server" AutoPostBack="True" OnValueChanged="cbFakulte_ValueChanged" TextField="fakulte_adi" ValueField="fakulte_id" ValueType="System.Int32" ></dx:BootstrapComboBox>
   
   <h4>   Bölüm:</h4><dx:BootstrapComboBox ID="cbBolum" runat="server" AutoPostBack="True" OnValueChanged="cbBolum_ValueChanged" ValueType="System.Int32" ></dx:BootstrapComboBox>
  <h4>    Çalışma Alanı:</h4><dx:BootstrapComboBox ID="cbCalismaAlani" runat="server"></dx:BootstrapComboBox>
    <dx:BootstrapButton ID="btnCaEkle" runat="server" AutoPostBack="false" Text="Ekle" OnClick="btnCaEkle_Click"></dx:BootstrapButton>
     <dx:BootstrapButton ID="btnHome" runat="server" AutoPostBack="false" Text="Ana Sayfa" OnClick="btnHome_Click" ></dx:BootstrapButton>
</asp:Content>
