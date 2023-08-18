<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="IslemIzleme.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.IslemIzleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>TP_Islem_Izleme Metodu</h3>
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
            <asp:Label runat="server">Baslangic Tarihi:</asp:Label>
            <asp:TextBox runat="server" ID="txbBasTarih" Width="50%" placeholder="00.00.0000"/>
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">Bitis Tarihi:</asp:Label>
            <asp:TextBox runat="server" ID="txbBitTarih" Width="50%" placeholder="00.00.0000"/>
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">İşlem Tip:</asp:Label>
            <asp:TextBox runat="server" ID="txbIslemTip" Width="50%" />
        </div>
         <hr />
        <br />
         <div class="center-align">
            <asp:Label runat="server">İşlem Durum:</asp:Label>
            <asp:TextBox runat="server" ID="txbIslemDurum" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="Listele" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
    <br />
    <hr />
    <br />
    <section>
        <asp:GridView runat="server" ID="grdSonuc" AutoGenerateColumns="true" DataKeyNames="">
            
        </asp:GridView>
    </section>
</asp:Content>
