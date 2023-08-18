<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="KKSakliOdeme.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.KKSakliOdeme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>KS_Tahsilat Metodu</h3>
        </legend>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">KS_GUID:</asp:Label>
            <asp:TextBox runat="server" ID="txbKS_GUID" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">KK_Islem_ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbKK_Islem_ID" Width="50%" />
        </div>
        <hr />
        <br />
         <div class="center-align">
            <asp:Label runat="server">KART CVV KODU:</asp:Label>
            <asp:TextBox runat="server" ID="txbCVV" Width="50%" />
        </div>
        <hr />
        <br />
         
        <div class="center-align">
            <asp:Button Text="OdemeYap" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>

         
   
</asp:Content>