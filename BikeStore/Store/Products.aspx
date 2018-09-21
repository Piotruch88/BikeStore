﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="BikeStore.Store.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxGridView ID="ASPxGridView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2"
        KeyFieldName="Id">
        <SettingsAdaptivity>
            <AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
        </SettingsAdaptivity>

        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />

        <EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
        <Columns>
            <dx:GridViewCommandColumn VisibleIndex="0">
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
            <dx:GridViewCommandColumn Caption="test test" ShowInCustomizationForm="True" ShowSelectCheckbox="True" VisibleIndex="9">
            </dx:GridViewCommandColumn>
        </Columns>


    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationServices %>"
        SelectCommand="SELECT [Id], [Name], [Producer], [URLToPhoto], [Price], [Description], [ProductType] FROM [Products]"></asp:SqlDataSource>
        
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>



    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

</asp:Content>
