<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="KartSakla.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.KartSakla" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>KS_Kart_Ekle Metodu</h3>
        </legend>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">İşyerine ait tekil anahtar:</asp:Label>
            <asp:TextBox runat="server" ID="txbGUID" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">Kart Sahibi:</asp:Label>
            <asp:TextBox runat="server" ID="txbKartSahibi" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">Kart No:</asp:Label>
            <asp:TextBox runat="server" ID="txbKartNo" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">KK AY:</asp:Label>
            <asp:TextBox runat="server" ID="txbKKAY" Width="50%" />
        </div>
         <hr />
        <br />
         <div class="center-align">
            <asp:Label runat="server">KK YIL:</asp:Label>
            <asp:TextBox runat="server" ID="txbKKYIL" Width="50%" />
        </div>
         <hr />
        <br />
         
        <div class="center-align">
            <asp:Button Text="Kart Sakla" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>

         <hr />
        <br />

         <div class="center-align">
            <asp:Label ID="lblKSGUID" runat="server" Visible="false" >KS GUID:</asp:Label>
            <asp:TextBox runat="server" Visible="false" ID="txbKSGUID" Width="50%" />
        </div>
   
</asp:Content>