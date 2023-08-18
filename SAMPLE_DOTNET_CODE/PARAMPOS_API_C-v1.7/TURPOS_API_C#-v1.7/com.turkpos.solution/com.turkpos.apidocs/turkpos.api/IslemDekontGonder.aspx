<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="IslemDekontGonder.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.IslemDekontGonder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>TP_Islem_Dekont_Gonder Metodu</h3>
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
            <asp:Label runat="server">Dekont ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbDekontID" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">E-Posta:</asp:Label>
            <asp:TextBox runat="server" AutoCompleteType="Email" ID="txbEmail" Width="50%" />
        </div>
        <div class="clearfx"></div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="TP_Islem_Dekont_Gonder Çalıştır" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
        
</asp:Content>
