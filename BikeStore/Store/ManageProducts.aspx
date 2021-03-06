﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="BikeStore.Store.ManageProducts" %>

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

    <dx:ASPxGridView ID="ASPxGridView" runat="server" AutoGenerateColumns="True" DataSourceID="SqlDataSource2" KeyFieldName="Id">
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
        </Columns>
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationServices %>"
        SelectCommand="SELECT [Id], [Name], [Producer], [URLToPhoto], [Price], [Description] FROM [Products]"
        DeleteCommand="DELETE FROM [Products] WHERE Id=@Id"
        UpdateCommand="UPDATE [Products] SET [Name]=@Name, [Producer]=@Producer, [URLToPhoto]=@URLToPhoto, [Price]=@Price, [Description]=@Description WHERE Id=@Id"
        InsertCommand="INSERT INTO [Products] ([Name], [Producer], [URLToPhoto], [Price], [Description]) VALUES (@name, @Producer, @URLToPhoto, @Price, @Description)"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    </asp:Content>
