<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="KKSakliListe.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.KKSakliListe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>KS_Kart_Liste Metodu</h3>
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
            <asp:Button Text="Listele" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>

         <section>
        <asp:GridView runat="server" ID="grdSonuc" AutoGenerateColumns="True" DataKeyNames="">
            
        </asp:GridView>
    </section>

         
   
</asp:Content>