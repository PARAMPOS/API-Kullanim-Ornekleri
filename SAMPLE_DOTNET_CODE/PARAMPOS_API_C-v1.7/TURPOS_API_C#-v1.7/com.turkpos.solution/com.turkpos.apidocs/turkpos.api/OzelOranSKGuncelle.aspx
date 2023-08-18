<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="OzelOranSKGuncelle.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.OzelOranSKGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section role="form" class="section-form">
        <legend class="center-align">
            <h3>TP_Ozel_Oran_SK_Guncelle Metodu</h3>
        </legend>
        <hr />


        <div class="center-align">
            <asp:Label runat="server" AssociatedControlID="txbAnahtar">Üye İşyerine ait Anahtar:</asp:Label>
            <asp:TextBox runat="server" ID="txbAnahtar" Width="50%" />
        </div>
        <div class="clearfx"></div>

        <hr />

        <div class="center-align">
            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO1">MO 1</asp:Label>
                <asp:TextBox runat="server" ID="txbMO1" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO2">MO 2</asp:Label>
                <asp:TextBox runat="server" ID="txbMO2" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO3">MO 3</asp:Label>
                <asp:TextBox runat="server" ID="txbMO3" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO4">MO 4</asp:Label>
                <asp:TextBox runat="server" ID="txbMO4" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO5">MO 5</asp:Label>
                <asp:TextBox runat="server" ID="txbMO5" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO6">MO 6</asp:Label>
                <asp:TextBox runat="server" ID="txbMO6" Width="50%" />
            </div>

            <hr />

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO7">MO 7</asp:Label>
                <asp:TextBox runat="server" ID="txbMO7" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO8">MO 8</asp:Label>
                <asp:TextBox runat="server" ID="txbMO8" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbMO9">MO 9</asp:Label>
                <asp:TextBox runat="server" ID="txbMO9" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbM10">MO 10</asp:Label>
                <asp:TextBox runat="server" ID="txbM10" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbM11">MO 11</asp:Label>
                <asp:TextBox runat="server" ID="txbM11" Width="50%" />
            </div>

            <div class="divbox">
                <asp:Label runat="server" AssociatedControlID="txbM12">MO 12</asp:Label>
                <asp:TextBox runat="server" ID="txbM12" Width="50%" />
            </div>
        </div>


        <hr />

        <div class="center-align">
            <asp:Button Text="Özel Oran Güncelle" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" Height="30px" />
        </div>
    </section>
    <div class="clearfx"></div>

    <hr />

    <section>
        <asp:GridView runat="server" ID="grdSKListe" DataKeyNames="Ozel_Oran_ID" AutoGenerateSelectButton="true" OnSelectedIndexChanged="grdSKListe_SelectedIndexChanged" AutoGenerateColumns="False">
                       <Columns>
                <asp:BoundField DataField="Ozel_Oran_ID" HeaderText="&#214;zel Oran ID"></asp:BoundField>
                <asp:BoundField DataField="GUID" HeaderText="Guid">
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Tarih_Bas" HeaderText="Başlangı&#231; Tarihi"></asp:BoundField>
                <asp:BoundField DataField="Tarih_Bit" HeaderText="Bitiş Tarihi"></asp:BoundField>
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
            </Columns>
        </asp:GridView>
    </section>
</asp:Content>
