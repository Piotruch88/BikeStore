<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="OrderDetails.aspx.cs" Inherits="BikeStore.Store.OrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
    <br>
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" KeyFieldName="Id">
<SettingsAdaptivity>
<AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
</SettingsAdaptivity>

<EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="URLToPhoto" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Price" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="ProductType" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="5">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="Producer" VisibleIndex="6">
            </dx:GridViewDataTextColumn>
        </Columns>
    </dx:ASPxGridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationServices %>" SelectCommand="SELECT [Name], [URLToPhoto], [Price], [Description], [ProductType], [Id], [Producer] FROM [Products]"></asp:SqlDataSource>
</asp:Content>
