<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="BikeStore.Store.Orders" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <dx:ASPxGridView ID="ASPxGridView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource" KeyFieldName="Id" OnCustomButtonCallback="ASPxGridView1_CustomButtonCallback">
        <SettingsAdaptivity>
            <AdaptiveDetailLayoutProperties ColCount="1"></AdaptiveDetailLayoutProperties>
        </SettingsAdaptivity>

        <EditFormLayoutProperties ColCount="1"></EditFormLayoutProperties>
        <Columns>
            <dx:GridViewDataTextColumn FieldName="Id" ReadOnly="True" VisibleIndex="0">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="TimeCreate" VisibleIndex="1">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="Addres" VisibleIndex="2">
            </dx:GridViewDataTextColumn>
            <dx:GridViewCommandColumn VisibleIndex="3">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton Text="Wybierz">
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
            </dx:GridViewCommandColumn>
        </Columns>
    </dx:ASPxGridView>

    <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ApplicationServices %>" SelectCommand="SELECT [Id], [TimeCreate], [Addres] FROM [Orders]"></asp:SqlDataSource>

</asp:Content>
