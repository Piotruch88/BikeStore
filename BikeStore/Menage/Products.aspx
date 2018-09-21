<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BikeStore.Menage.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
        <%--        <AnonymousTemplate>
            <div>
                Dostęp tylko dla użytkowników z uprawnieniami...
            </div>
        </AnonymousTemplate>
        <LoggedInTemplate>
            jestes zalgowanym
        </LoggedInTemplate>--%>
    </asp:LoginView>

    <dx:ASPxGridView ID="ASPxGridView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" KeyFieldName="Id">
<SettingsAdaptivity>
<AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
</SettingsAdaptivity>

<EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="0">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Producer" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="URLToPhoto" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Price" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ProductType" VisibleIndex="6">
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationServices %>"
        SelectCommand="SELECT [Id], [Name], [Producer], [URLToPhoto], [Price], [Description], [ProductType] FROM [Products]"
        DeleteCommnad="DELETE FORM [Products] WHERE [id]=@id">
    
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
