<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="IslemSorgulama.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.IslemSorgulama" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>TP_Islem_Sorgulama Metodu</h3>
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
            <asp:Label runat="server">Sipariş ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbSiparisID" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Label runat="server">İşlem ID:</asp:Label>
            <asp:TextBox runat="server" ID="txbIslemID" Width="50%" />
        </div>
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="İşlem Listele" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
    <br />
    <hr />
    <br />
    <section>
        <asp:GridView runat="server" ID="grdSonuc" AutoGenerateColumns="false" DataKeyNames="">
            <Columns>
                <asp:BoundField DataField="Odeme_Sonuc" HeaderText="Başarılı İşlem Sayısı"></asp:BoundField>
                <asp:BoundField DataField="Odeme_Sonuc_Aciklama" HeaderText="Başarılı İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Tarih" HeaderText="İptal İşlem Sayısı"></asp:BoundField>
                <asp:BoundField DataField="Dekont_ID" HeaderText="İptal İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Siparis_ID" HeaderText="İade İşlem Sayısı"></asp:BoundField>
                <asp:BoundField DataField="Islem_ID" HeaderText="İade İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Komisyon_Oran" HeaderText="İade İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Komisyon_Tutar" HeaderText="İade İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Toplam_Tutar" HeaderText="İade İşlem Toplamı"></asp:BoundField>
                <asp:BoundField DataField="Taksit" HeaderText="İade İşlem Toplamı"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </section>
</asp:Content>
