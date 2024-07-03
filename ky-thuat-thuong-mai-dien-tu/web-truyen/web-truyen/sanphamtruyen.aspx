<%@ Page Title="" Language="C#" MasterPageFile="~/truyen.Master" AutoEventWireup="true" CodeBehind="sanphamtruyen.aspx.cs" Inherits="web_truyen.sanphamtruyen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenTruyen") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MaTruyen") %>' OnClick="LinkButton2_Click">Chi tiết</asp:LinkButton>
            <br />
        </ItemTemplate>
</asp:DataList>
</asp:Content>

