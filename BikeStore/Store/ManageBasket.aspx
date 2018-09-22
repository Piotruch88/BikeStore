<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ManageBasket.aspx.cs" Inherits="BikeStore.Store.ManageBasket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" DataSourceID="ObjectDataSource1">
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="LoadCzyToSiePOkaze" TypeName="BikeStore.Store.ManageBasket"></asp:ObjectDataSource>
</asp:Content>
