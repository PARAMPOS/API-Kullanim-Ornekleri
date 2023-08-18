<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="SHA2B64.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.SHA2B64" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section role="form" class="section-form">
        <legend class="center-align">
            <h3>SHA2B64 Metodu</h3>
        </legend>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">Çevrilecek Metin:</asp:Label>
            <asp:TextBox runat="server" ID="txbMetin" Width="50%" />
        </div>
        <div class="clearfx"></div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server" ID="lblSonuc" ForeColor="Red"></asp:Label>
        </div>
        <div class="clearfx"></div>
        <br />
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="SHA2B64 Çalıştır" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
    <br />
    <hr />
    <br />

</asp:Content>
