<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="ETSPreIslemOdeme.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.ETSPreIslemOdeme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section role="form" class="section-form">
        <legend class="center-align">
            <h3>ETS_Pre_Islem_Odeme Metodu</h3>
        </legend>
        <hr />


        <div class="center-align">
            <asp:Label runat="server" AssociatedControlID="txbAnahtar">Üye İşyerine ait Anahtar:</asp:Label>
            <asp:TextBox runat="server" ID="txbAnahtar" Width="50%" />
        </div>
         
         
        <div class="clearfx"></div>

        <hr />
        <div class="center-align">
            <asp:Button Text="Listeyi Getir" runat="server" ID="btnList" OnClick="btnList_Click" Width="70%" Height="30px" />
        </div>
    </section>
    <div class="clearfx"></div>

    <hr />

    <section>
        <asp:GridView runat="server" ID="grdOranListe" DataKeyNames="SanalPOS_ID" AutoGenerateSelectButton="true" OnSelectedIndexChanged="grdOranListe_SelectedIndexChanged" AutoGenerateColumns="False" EmptyDataText="Lütfen Listeleme Yapınız">
            <Columns>
                <asp:BoundField DataField="Ozel_Oran_SK_ID" HeaderText="&#214;zel Oran ID"></asp:BoundField>
                <asp:BoundField DataField="GUID" HeaderText="Guid">
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                
                <asp:BoundField DataField="SanalPOS_ID" HeaderText="Sanal Pos ID"></asp:BoundField>
                <asp:BoundField DataField="Kredi_Karti_Banka" HeaderText="Bankası"></asp:BoundField>
                <asp:ImageField DataImageUrlField="Kredi_Karti_Banka_Gorsel" HeaderText="Banka G&#246;rseli"></asp:ImageField>
                <asp:BoundField DataField="MO_01" HeaderText="MO_01"></asp:BoundField>
                <asp:BoundField DataField="MO_02" HeaderText="MO_02"></asp:BoundField>
                <asp:BoundField DataField="MO_03" HeaderText="MO_03"></asp:BoundField>
                <asp:BoundField DataField="MO_04" HeaderText="MO_04"></asp:BoundField>
                <asp:BoundField DataField="MO_05" HeaderText="MO_05"></asp:BoundField>
                <asp:BoundField DataField="MO_06" HeaderText="MO_06"></asp:BoundField>
                <asp:BoundField DataField="MO_07" HeaderText="MO_07"></asp:BoundField>
                <asp:BoundField DataField="MO_08" HeaderText="MO_08"></asp:BoundField>
                <asp:BoundField DataField="MO_09" HeaderText="MO_09"></asp:BoundField>
                <asp:BoundField DataField="MO_10" HeaderText="MO_10"></asp:BoundField>
                <asp:BoundField DataField="MO_11" HeaderText="MO_11"></asp:BoundField>
                <asp:BoundField DataField="MO_12" HeaderText="MO_12"></asp:BoundField>
               
            </Columns>
        </asp:GridView>
    </section>
    <div class="clearfx"></div>
    <br />  
    <div class="center-align">
        <asp:Button Text="Ödeme Yap" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" Height="30px" Visible="false" />
    </div>
</asp:Content>
