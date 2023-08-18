<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="sonuc.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.sonuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>Sonuç Sayfası</h3>
        </legend>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Sonuc:</asp:Label>
            <asp:TextBox runat="server" ID="txbSonuc" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Sonuc_Str:</asp:Label>
            <asp:TextBox runat="server" ID="txbSonuc_Str" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_GUID:</asp:Label>
            <asp:TextBox runat="server" ID="txbGUID" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Islem_Tarih:</asp:Label>
            <asp:TextBox runat="server" ID="txbIslemTarih" Width="50%" />
        </div>
         <hr />
        <br />
         <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Dekont_ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbDekontID" Width="50%" />
        </div>
        <hr />
        <br />
         
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Tahsilat_Tutari:</asp:Label>
            <asp:TextBox runat="server" ID="txbTahsilat" Width="50%" />
        </div>
         <hr />
        <br />
         
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Odeme_Tutari:</asp:Label>
            <asp:TextBox runat="server" ID="txbOdeme" Width="50%" />
        </div>
         <hr />
        <br />
         
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Siparis_ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbSiparisID" Width="50%" />
        </div>
         <hr />
        <br />
         
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Islem_ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbIslemID" Width="50%" />
        </div>
         <hr />
        <br />
         
        <div class="center-align">
            <asp:Label runat="server">TURKPOS_RETVAL_Ext_Data:</asp:Label>
            <asp:TextBox runat="server" ID="txbData" Width="50%" />
        </div>
        
</asp:Content>
