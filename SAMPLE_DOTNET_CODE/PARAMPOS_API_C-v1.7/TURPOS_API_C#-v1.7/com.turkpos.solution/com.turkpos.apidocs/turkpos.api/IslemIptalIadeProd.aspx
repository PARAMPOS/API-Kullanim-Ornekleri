<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="IslemIptalIadeProd.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.IslemIptalIadeProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section role="form" class="section-form">
        <legend class="center-align">
            <h3>TP_Islem_Iptal_Iade Metodu</h3>
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
            <asp:Label runat="server">Durum:</asp:Label>
            <asp:DropDownList runat="server" ID="drpDurum" Width="50%">
                <asp:ListItem Text="IPTAL" />
                <asp:ListItem Text="IADE" />
            </asp:DropDownList>
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">Dekont ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbDekontID" Width="50%" />
        </div>
        <div class="center-align">
            <asp:Label runat="server">Tutar:</asp:Label>
            <asp:TextBox runat="server" ID="txbTutar" Width="50%" />
        </div>
        <div class="clearfx"></div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="TP_Islem_Iptal_Iade Çalıştır" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
</asp:Content>
