<%@ Page Title="" Language="C#" MasterPageFile="~/turkpos.api/ApiForms.Master" AutoEventWireup="true" CodeBehind="BINSanalPos.aspx.cs" Inherits="com.turkpos.apidocs.turkpos.api.BINSanalPos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section role="form" class="section-form">
        <legend class="center-align">
            <h3>BIN_SanalPos Metodu</h3>
        </legend>
        <hr />
        <br />
        <div class="center-align">
            <asp:Button Text="BIN_SanalPos Listele" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Width="70%" />
        </div>
    </section>
    <div class="clearfx"></div>
    <br />
    <hr />
    <br />
    <section>
        <asp:GridView runat="server" ID="grdSonuc" AutoGenerateColumns="false" DataKeyNames="BIN">
            <Columns>
                <asp:BoundField DataField="BIN" HeaderText="BIN"></asp:BoundField>
                <asp:BoundField DataField="SanalPOS_ID" HeaderText="Sanal Pos ID"></asp:BoundField>
                <asp:BoundField DataField="Kart_Banka" HeaderText="Bankası"></asp:BoundField>
                <asp:BoundField DataField="DKK" HeaderText="DKK"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </section>
</asp:Content>
