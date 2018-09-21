<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="AddingNewProduct.aspx.cs" Inherits="BikeStore.Menage.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
        <%--        <AnonymousTemplate>
            <div>
                Dostęp tylko dla użytkowników z uprawnieniami...
            </div>
        </AnonymousTemplate>
        <LoggedInTemplate>
            jestes zalgowanym dziadem
        </LoggedInTemplate>--%>
    </asp:LoginView>

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


    <dx:ASPxGridView ID="ASPxGridView" runat="server" DataSourceID="SqlDataSource2"></dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
