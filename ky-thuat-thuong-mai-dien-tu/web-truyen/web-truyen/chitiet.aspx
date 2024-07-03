<%@ Page Title="" Language="C#" MasterPageFile="~/truyen.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="web_truyen.chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenTruyen") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' />
            <br />
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
        </ItemTemplate>

    </asp:DataList>
</asp:Content>
