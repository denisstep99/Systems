<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="SummaryDB.aspx.cs" Inherits="RSVP.SummaryDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Список участников<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" Width="1069px">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Имя" ReadOnly="True" SortExpression="Name" />
            <asp:BoundField DataField="Email" HeaderText="Электронный адрес" ReadOnly="True" SortExpression="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Телефон" ReadOnly="True" SortExpression="Phone" />
            <asp:CheckBoxField DataField="WillAttend" HeaderText="Присутствие" ReadOnly="True" SortExpression="WillAttend" />
            <asp:BoundField DataField="Rdata" HeaderText="Дата регистрации" ReadOnly="True" SortExpression="Rdata" />
        </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="RSVP.Code.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)" TableName="GuestResponses">
        </asp:LinqDataSource>
    </h2>
</asp:Content>
