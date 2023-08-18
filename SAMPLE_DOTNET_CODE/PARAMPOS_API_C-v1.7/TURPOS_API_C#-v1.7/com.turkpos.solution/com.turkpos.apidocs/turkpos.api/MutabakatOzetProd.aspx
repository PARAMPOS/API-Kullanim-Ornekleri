<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="MutabakatOzetProd.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.MutabakatOzetProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section role="form" class="section-form">
        <legend class="center-align">
            <h3>TP_Mutabakat_Ozet Metodu</h3>
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
            <asp:Label runat="server">Başlangıç Tarihi:</asp:Label>
            <asp:Calendar runat="server" ID="clnBaslangic" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">Bitiş Tarihi:</asp:Label>
            <asp:Calendar runat="server" ID="clnBitis" Width="50%" />
        </div>
        <div class="clearfx"></div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="TP_Mutabakat_Ozet Listele" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
    <br />
    <hr />
    <br />
    <section>
        <asp:GridView runat="server" ID="grdSonuc" AutoGenerateColumns="false" DataKeyNames="Basarili_Islem_Sayi">
            <Columns>
                <asp:BoundField DataField="Basarili_Islem_Sayi" HeaderText="Başarılı İşlem Sayısı"></asp:BoundField>
                <asp:BoundField DataField="Basarili_Islem_Toplam_Tutar" HeaderText="Başarılı İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Iptal_Islem_Sayi" HeaderText="İptal İşlem Sayısı"></asp:BoundField>
                <asp:BoundField DataField="Iptal_Islem_Toplam_Tutar" HeaderText="İptal İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Iade_Islem_Sayi" HeaderText="İade İşlem Sayısı"></asp:BoundField>
                <asp:BoundField DataField="Iade_Islem_Toplam_Tutar" HeaderText="İade İşlem Toplamı"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </section>
</asp:Content>
