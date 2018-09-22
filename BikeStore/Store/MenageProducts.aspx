<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="MenageProducts.aspx.cs" Inherits="BikeStore.Menage.WebForm1" %>

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

    <dx:ASPxGridView ID="ASPxGridView" runat="server" AutoGenerateColumns="True" DataSourceID="SqlDataSource2" KeyFieldName="Id" OnInit="ASPxGridView_Init">
        <SettingsAdaptivity>
            <AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
        </SettingsAdaptivity>

        <EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
        <Columns>
            <dx:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Producer" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="URLToPhoto" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Price" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="6">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ProductType" VisibleIndex="7">
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationServices %>"
        SelectCommand="SELECT [Id], [Name], [Producer], [URLToPhoto], [Price], [Description], [ProductType] FROM [Products]"
        DeleteCommand="DELETE FROM [Products] WHERE Id=@Id"
        InsertCommand="INSERT INTO [Products] ([Name], [Producer], [URLToPhoto], [Price], [Description], [ProductType]) VALUES (@name, @Producer, @URLToPhoto, @Price, @Description, @ProductType)"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
