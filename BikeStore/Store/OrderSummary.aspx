<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="BikeStore.Store.OrderSummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label" runat="server" Text="Label" Font-Size="Medium"></asp:Label>


    <h3>Wpisz adres do zamówienia:</h3>
    <dx:ASPxMemo ID="ASPxMemo1" runat="server" Height="200px" Width="200px"></dx:ASPxMemo>

    <asp:Button ID="Btn_SubmitOrder" runat="server" Text="Złóż zamówienie" OnClick="Btn_SubmitOrder_Click" />

</asp:Content>
