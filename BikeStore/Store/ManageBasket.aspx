<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="ManageBasket.aspx.cs" Inherits="BikeStore.Store.ManageBasket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxGridView ID="ASPxGridView" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" KeyFieldName="Id">
<SettingsAdaptivity>
<AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
</SettingsAdaptivity>

<EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Id" ShowInCustomizationForm="True" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Name" ShowInCustomizationForm="True" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Producer" ShowInCustomizationForm="True" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="URLToPhoto" ShowInCustomizationForm="True" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Price" ShowInCustomizationForm="True" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Description" ShowInCustomizationForm="True" VisibleIndex="5">
            </dx:GridViewDataTextColumn>
            <dx:GridViewCommandColumn ShowInCustomizationForm="True" ShowSelectCheckbox="True" VisibleIndex="6">
            </dx:GridViewCommandColumn>
        </Columns>
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetBasket" TypeName="BikeStore.Store.ManageBasket"></asp:ObjectDataSource>

<asp:Button ID="Button1" runat="server" Text="Usuń z koszyka" OnClick="Button1_Click" />
<asp:Button ID="btnOrder" runat="server" Text="Złóż zamówienie" OnClick="BtnOrder_Click" />
</asp:Content>
